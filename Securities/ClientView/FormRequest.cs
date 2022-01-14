using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Securities.ClientView
{
    public partial class FormRequest : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RequestBusinessLogic _requestBusinesslogic;
        private readonly BagBusinessLogic _bagBusinesslogic;
        private int? id;
        public FormRequest(RequestBusinessLogic requestBusinesslogic, BagBusinessLogic bagBusinesslogic)
        {
            InitializeComponent();
            _requestBusinesslogic = requestBusinesslogic;
            _bagBusinesslogic = bagBusinesslogic;
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<BagViewModel> listBag = _bagBusinesslogic.Read(new BagBindingModel
                {
                    ClientId = Program.Client.Id,
                    Status = "Не куплен"
                });
                if (listBag != null)
                {
                    comboBoxBag.DisplayMember = "Id";
                    comboBoxBag.ValueMember = "Id";
                    comboBoxBag.DataSource = listBag;
                    comboBoxBag.SelectedItem = null;
                }
                List<RequestViewModel> list = _requestBusinesslogic.GetFiltredRequestClient(Program.Client.Id);
                if (list != null)
                {
                    dataGridViewRequest.DataSource = list;
                    dataGridViewRequest.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewRequest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewRequest.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewRequest.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewRequest.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewRequest.Columns[3].Visible = false;
                }
                dateTimePicker.Text = null;
                textBoxSum.Text = null;
                comboBoxBag.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxBag.SelectedValue == null)
            {
                MessageBox.Show("Выберите портфель", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;
            }
            try
            {
                _requestBusinesslogic.Create(new RequestBindingModel
                {
                    Id = id,
                    RequestDate = dateTimePicker.Value,
                    RequestSum = Math.Round(Convert.ToDecimal(textBoxSum.Text), 2),
                    BagId = Convert.ToInt32(comboBoxBag.SelectedValue)
                });
                BagViewModel bag = _bagBusinesslogic.Read(new BagBindingModel
                {
                    Id = Convert.ToInt32(comboBoxBag.SelectedValue)
                })[0];
                _bagBusinesslogic.Create(new BagBindingModel
                {
                    Id = bag.Id,
                    Status = "Идет покупка",
                    Sum = bag.Sum,
                    ClientId = bag.ClientId,
                    BagSecurities = bag.BagSecurities
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BagViewModel bag = _bagBusinesslogic.Read(new BagBindingModel
                    {
                        Id = Convert.ToInt32(dataGridViewRequest.SelectedRows[0].Cells[5].Value)
                    })[0];
                    if (bag.Status == "Идет покупка")
                    {
                        _bagBusinesslogic.Create(new BagBindingModel
                        {
                            Id = bag.Id,
                            Status = "Не куплен",
                            Sum = bag.Sum,
                            ClientId = bag.ClientId,
                            BagSecurities = bag.BagSecurities
                        });
                    }
                    int id = Convert.ToInt32(dataGridViewRequest.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _requestBusinesslogic.Delete(new RequestBindingModel { Id = id });
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

        private void dataGridViewRequest_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewRequest.SelectedRows[0].Cells[0].Value != null)
            {
                int id = Convert.ToInt32(dataGridViewRequest.SelectedRows[0].Cells[0].Value);
                RequestViewModel request = _requestBusinesslogic.Read(new RequestBindingModel
                {
                    Id = id
                })[0];
                comboBoxBag.Text = request.BagId.ToString();
                dateTimePicker.Value = request.RequestDate;
                textBoxSum.Text = request.RequestSum.ToString();
            }
        }

        private void comboBoxBag_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void CalcSum()
        {
            if (comboBoxBag.SelectedValue != null)
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxBag.SelectedValue);
                    BagViewModel bag = _bagBusinesslogic.Read(new BagBindingModel
                    {
                        Id = id
                    })?[0];
                    textBoxSum.Text = bag.Sum.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
