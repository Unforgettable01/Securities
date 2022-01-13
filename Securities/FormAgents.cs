using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Unity;

namespace Securities
{
    public partial class FormAgents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly AgentBusinessLogic _agentBusinesslogic;
        AgentViewModel view;
        public int Id { set { id = value; } }
        private int? id;
        public FormAgents(AgentBusinessLogic agentBusinesslogic)
        {
            InitializeComponent();
            _agentBusinesslogic = agentBusinesslogic;
        }

        private void FormAgents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _agentBusinesslogic.Read(null);
                if (list != null)
                {
                    dataGridViewAgents.DataSource = list;
                    dataGridViewAgents.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                try
                {
                    _agentBusinesslogic.Create(new AgentBindingModel
                    {
                        AgentName = textBoxName.Text,
                        AgentLogin = textBoxLogin.Text,
                        AgentPassword = textBoxPassword.Text
                    }); ;
                    MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                textBoxLogin.Clear();
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                LoadData();
            }
        }

        private void dataGridViewAgents_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewAgents.SelectedRows.Count != 0)
            {
                textBoxName.Text = dataGridViewAgents.SelectedRows[0].Cells[1].Value.ToString();
                textBoxLogin.Text = dataGridViewAgents.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPassword.Text = dataGridViewAgents.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private bool CheckValidate()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(textBoxName.Text, @"[А-Я][а-я]+\s[А-Я]+[.]+[А-Я]+[.]"))
            {
                MessageBox.Show("Необходимо проверить правильность ФИО (Фамилия И.О.)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAgents.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewAgents.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _agentBusinesslogic.Delete(new AgentBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                int id = Convert.ToInt32(dataGridViewAgents.SelectedRows[0].Cells[0].Value);
                try
                {
                    _agentBusinesslogic.Create(new AgentBindingModel
                    {
                        Id = id,
                        AgentName = textBoxName.Text,
                        AgentLogin = textBoxLogin.Text,
                        AgentPassword = textBoxPassword.Text
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                textBoxLogin.Clear();
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                LoadData();
            }
        }
    }
}
