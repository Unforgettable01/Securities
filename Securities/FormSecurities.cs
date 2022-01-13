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
            if (CheckValidate())
            {
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
                textBoxBuyPrice.Clear();
                textBoxSalePrice.Clear();
                textBoxName.Clear();
                comboBoxEmitents.SelectedIndex = -1;
                LoadData();
            }
        }
        private bool CheckValidate()
        {
            if (string.IsNullOrEmpty(textBoxBuyPrice.Text))
            {
                MessageBox.Show("Заполните цену покупки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(textBoxBuyPrice.Text, @"[0-9]+[,]+[0-9]{2}"))
            {
                MessageBox.Show("Необходимо проверить правильность цены покупки (поличтельное число + 2 цифры после запятой)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxSalePrice.Text))
            {
                MessageBox.Show("Заполните цену продажи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Regex.IsMatch(textBoxSalePrice.Text, @"[0-9]+[,]+[0-9]{2}"))
            {
                MessageBox.Show("Необходимо проверить правильность цены продажи (поличтельное число + 2 цифры после запятой)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните наименование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(comboBoxEmitents.Text))
            {
                MessageBox.Show("Необходимо выбрать эмитента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSecurities.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewSecurities.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _securitiesBusinesslogic.Delete(new SecurityBindingModel { Id = id });
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
                int id = Convert.ToInt32(dataGridViewSecurities.SelectedRows[0].Cells[0].Value);
                try
                {
                    _securitiesBusinesslogic.Create(new SecurityBindingModel
                    {
                        Id = id,
                        BuyPrice = Convert.ToDecimal(textBoxBuyPrice.Text),
                        SalePrice = Convert.ToDecimal(textBoxSalePrice.Text),
                        Name = textBoxName.Text,
                        EmitentId = Convert.ToInt32(comboBoxEmitents.SelectedValue)
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                textBoxBuyPrice.Clear();
                textBoxSalePrice.Clear();
                textBoxName.Clear();
                comboBoxEmitents.SelectedIndex = -1;
                LoadData();
            }
        }
        public void FormEmitentName()
        {
            var viewSecurities = _securitiesBusinesslogic.Read(new SecurityBindingModel { Id = Convert.ToInt32(dataGridViewSecurities.SelectedRows[0].Cells[0].Value) })?[0];
            var viewEmitent = _emitentBusinesslogic.Read(new EmitentBindingModel { Id = Convert.ToInt32(viewSecurities.EmitentName) })?[0];
            if (viewEmitent != null)
            {
                comboBoxEmitents.Text = viewEmitent.EmitentName;
            }
        }
        private void dataGridViewSecurities_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewSecurities.SelectedRows.Count != 0)
            {
                textBoxBuyPrice.Text = dataGridViewSecurities.SelectedRows[0].Cells[2].Value.ToString();
                textBoxSalePrice.Text = dataGridViewSecurities.SelectedRows[0].Cells[3].Value.ToString();
                FormEmitentName();
                textBoxName.Text = dataGridViewSecurities.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
