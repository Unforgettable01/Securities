using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Securities
{
    public partial class FormClients : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientBusinessLogic _clientBusinesslogic;
        ClientViewModel view;
        public int Id { set { id = value; } }
        private int? id;
        public FormClients(ClientBusinessLogic clientBusinesslogic)
        {
            InitializeComponent();
            _clientBusinesslogic = clientBusinesslogic;
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _clientBusinesslogic.Read(null);
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

        private void dataGridViewAgents_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewAgents.SelectedRows.Count != 0)
            {
                textBoxPassportNumber.Text = dataGridViewAgents.SelectedRows[0].Cells[1].Value.ToString();
                textBoxName.Text = dataGridViewAgents.SelectedRows[0].Cells[2].Value.ToString();
                textBoxLogin.Text = dataGridViewAgents.SelectedRows[0].Cells[3].Value.ToString();
                textBoxPassword.Text = dataGridViewAgents.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                try
                {
                    _clientBusinesslogic.Create(new ClientBindingModel
                    {
                        PassportNumber = textBoxPassportNumber.Text,
                        ClientName = textBoxName.Text,
                        ClientLogin = textBoxLogin.Text,
                        ClientPassword = textBoxPassword.Text
                    }); ;
                    MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                textBoxPassportNumber.Clear();
                textBoxLogin.Clear();
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                LoadData();
            }
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
            if (!Regex.IsMatch(textBoxPassportNumber.Text, @"[0-9]{10}"))
            {
                MessageBox.Show("Необходимо проверить правильность пспортных данных (10 цифр)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxPassportNumber.Text))
            {
                MessageBox.Show("Заполните паспортные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        _clientBusinesslogic.Delete(new ClientBindingModel { Id = id });
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

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (CheckValidate())
            {
                int id = Convert.ToInt32(dataGridViewAgents.SelectedRows[0].Cells[0].Value);
                try
                {
                    _clientBusinesslogic.Create(new ClientBindingModel
                    {
                        Id = id,
                        PassportNumber = textBoxPassportNumber.Text,
                        ClientName = textBoxName.Text,
                        ClientLogin = textBoxLogin.Text,
                        ClientPassword = textBoxPassword.Text
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                textBoxPassportNumber.Clear();
                textBoxLogin.Clear();
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                LoadData();
            }
        }
    }
}
