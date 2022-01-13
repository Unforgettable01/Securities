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
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Securities
{
    public partial class FormSecurities : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SecurityBusinessLogic _securitiesBusinesslogic;
        private readonly EmitentBusinessLogic _emitentBusinesslogic;

        SecurityViewModel view;
        public int Id { set { id = value; } }
        private int? id;
        public FormSecurities(SecurityBusinessLogic securitiesBusinesslogic, EmitentBusinessLogic emitentBusinesslogic)
        {
            InitializeComponent();
            _securitiesBusinesslogic = securitiesBusinesslogic;
            _emitentBusinesslogic = emitentBusinesslogic;
        }

        private void FormSecuritiess_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {   
            try
            {
                List<EmitentViewModel> listEmitents = _emitentBusinesslogic.Read(null);
                if (listEmitents != null)
                {
                    comboBoxEmitents.DisplayMember = "EmitentName";
                    comboBoxEmitents.ValueMember = "Id";
                    comboBoxEmitents.DataSource = listEmitents;
                    comboBoxEmitents.SelectedItem = null;
                }

                var list = _securitiesBusinesslogic.Read(null);
                if (list != null)
                {
                    dataGridViewSecurities.DataSource = list;
                    dataGridViewSecurities.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(textBoxName.Text))
            //{
            //    MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (!Regex.IsMatch(textBoxName.Text, @"[А-Я][а-я]+\s[А-Я]+[.]+[А-Я]+[.]"))
            //{
            //    MessageBox.Show("Необходимо проверить правильность ФИО", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (string.IsNullOrEmpty(textBoxLogin.Text))
            //{
            //    MessageBox.Show("Заполните логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (string.IsNullOrEmpty(textBoxPassword.Text))
            //{
            //    MessageBox.Show("Заполните пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (string.IsNullOrEmpty(textBoxPassportNumber.Text))
            //{
            //    MessageBox.Show("Заполните номер паспорта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (!Regex.IsMatch(textBoxPassportNumber.Text, @"[0-9]{10}"))
            //{
            //    MessageBox.Show("Необходимо проверить правильность вводимого номера паспорта (должны быть только цифры)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            try
            {
                _securitiesBusinesslogic.Create(new SecurityBindingModel
                {
                    BuyPrice = Convert.ToDecimal(textBoxBuyPrice.Text),
                    SalePrice = Convert.ToDecimal(textBoxSalePrice.Text),
                    Name = textBoxName.Text,
                    EmitentId = Convert.ToInt32(comboBoxEmitents.SelectedValue)
                }); ;
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

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
