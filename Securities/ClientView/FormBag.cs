using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Securities.ClientView
{
    public partial class FormBag : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly BagBusinessLogic _bagBusinesslogic;
        private readonly SecurityBusinessLogic _securityBusinesslogic;
        private int? id;

        private Dictionary<int?, (string, int?, decimal?)> bagSecurities;
        public FormBag(BagBusinessLogic bagBusinesslogic, SecurityBusinessLogic securityBusinesslogic)
        {
            InitializeComponent();
            _securityBusinesslogic = securityBusinesslogic;
            _bagBusinesslogic = bagBusinesslogic;
        }

        private void FormBag_Load(object sender, EventArgs e)
        {
            List<SecurityViewModel> list = _securityBusinesslogic.Read(null);
            if (list != null)
            {
                comboBoxSecurities.DisplayMember = "Name";
                comboBoxSecurities.ValueMember = "Id";
                comboBoxSecurities.DataSource = list;
                comboBoxSecurities.SelectedItem = null;
            }

            if (id.HasValue)
            {
                try
                {
                    BagViewModel view = _bagBusinesslogic.Read(new BagBindingModel
                    {
                        Id = id.Value
                    })?[0];
                    if (view != null)
                    {
                        bagSecurities = view.BagSecurities;
                        textBoxNumber.Text = view.Id.ToString();
                        textBoxStatus.Text = view.Status;
                        textBoxSum.Text = view.Sum.ToString();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bagSecurities = new Dictionary<int?, (string, int?, decimal?)>();
                textBoxNumber.Visible = false;
                textBoxStatus.Visible = false;
                labelNumber.Visible = false;
                labelStatus.Visible = false;
            }
        }
        private void LoadData()
        {
            decimal result = 0;
            try
            {
                if (bagSecurities != null)
                {
                    dataGridViewSecurities.Rows.Clear();
                    foreach (var pc in bagSecurities)
                    {
                        dataGridViewSecurities.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2, pc.Value.Item3 });
                        result += (decimal)pc.Value.Item3;
                    }
                    textBoxSum.Text = result.ToString();
                    textBoxCount.Text = null;
                    textBoxSumma.Text = null;
                    comboBoxSecurities.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (bagSecurities.ContainsKey((int)comboBoxSecurities.SelectedValue))
            {
                bagSecurities[(int)comboBoxSecurities.SelectedValue] = (comboBoxSecurities.Text, Convert.ToInt32(textBoxCount.Text), Math.Round(Convert.ToDecimal(textBoxSumma.Text), 2));
            }
            else
            {
                bagSecurities.Add(Convert.ToInt32(comboBoxSecurities.SelectedValue), (comboBoxSecurities.Text, Convert.ToInt32(textBoxCount.Text), Math.Round(Convert.ToDecimal(textBoxSumma.Text), 2)));
            }
            LoadData();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            bagSecurities[(int)comboBoxSecurities.SelectedValue] = (comboBoxSecurities.Text, Convert.ToInt32(textBoxCount.Text), Math.Round(Convert.ToDecimal(textBoxSumma.Text), 2));
            LoadData();

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewSecurities.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        bagSecurities.Remove(Convert.ToInt32(dataGridViewSecurities.SelectedRows[0].Cells[0].Value));
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

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (bagSecurities.Count == 0)
            {
                MessageBox.Show("Выберите ценные бумаги", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                string status = "";
                if (textBoxStatus.Text == "")
                {
                    status = "Не куплен";
                }
                else
                {
                    status = textBoxStatus.Text;
                }
                _bagBusinesslogic.Create(new BagBindingModel
                {
                    Id = id,
                    Status = status,
                    Sum = Math.Round(Convert.ToDecimal(textBoxSum.Text), 2),
                    ClientId = Program.Client.Id,
                BagSecurities = bagSecurities
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSumma();
        }

        private void comboBoxSecurities_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSumma();
        }
        private void CalcSumma()
        {
            if (comboBoxSecurities.SelectedValue != null && !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxSecurities.SelectedValue);
                    SecurityViewModel securities = _securityBusinesslogic.Read(new SecurityBindingModel
                    {
                        Id = id
                    })?[0];
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSumma.Text = (count * securities?.SalePrice ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewSecurities_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewSecurities.SelectedRows[0].Cells[0].Value != null)
            {
                int id = Convert.ToInt32(dataGridViewSecurities.SelectedRows[0].Cells[0].Value);
                comboBoxSecurities.SelectedValue = id;
                textBoxCount.Text = bagSecurities[id].Item2.ToString();
            }
        }
    }
}
