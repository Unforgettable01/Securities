using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Unity;

namespace Securities
{
    public partial class FormEmitents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly EmitentBusinessLogic _emitentBusinesslogic;
        EmitentViewModel view;
        public int Id { set { id = value; } }
        private int? id;
        public FormEmitents(EmitentBusinessLogic emitentBusinesslogic)
        {
            InitializeComponent();
            _emitentBusinesslogic = emitentBusinesslogic;
        }

        private void FormEmitents_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _emitentBusinesslogic.Read(null);
                if (list != null)
                {
                    dataGridViewEmitents.DataSource = list;
                    dataGridViewEmitents.Columns[0].Visible = false;
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
                    _emitentBusinesslogic.Create(new EmitentBindingModel
                    {
                        EmitentName = textBoxName.Text
                    }); ;
                    MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            textBoxName.Clear();
            LoadData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmitents.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewEmitents.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _emitentBusinesslogic.Delete(new EmitentBindingModel { Id = id });
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
                int id = Convert.ToInt32(dataGridViewEmitents.SelectedRows[0].Cells[0].Value);
                try
                {
                    _emitentBusinesslogic.Create(new EmitentBindingModel 
                    { 
                        Id = id,
                        EmitentName = textBoxName.Text
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                textBoxName.Clear();
                LoadData();
            }

        }

        private void dataGridViewEmitents_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewEmitents.SelectedRows.Count != 0)
            {
                textBoxName.Text = dataGridViewEmitents.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        private bool CheckValidate()
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните Наименование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(textBoxName.Text, @"[а-яА-Я]"))
            {
                MessageBox.Show("Необходимо проверить Наименования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
