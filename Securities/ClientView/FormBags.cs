using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Securities.ClientView
{
    public partial class FormBags : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly BagBusinessLogic _bagBusinesslogic;
        public FormBags(BagBusinessLogic bagBusinesslogic)
        {
            InitializeComponent();
            _bagBusinesslogic = bagBusinesslogic;
        }

        private void FormBags_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<BagViewModel> list = _bagBusinesslogic.GetFiltredBag(new BagBindingModel
                {
                    ClientId = Program.Client.Id
                });
                if (list != null)
                {
                    dataGridViewBags.DataSource = list;
                    dataGridViewBags.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewBags.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewBags.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewBags.Columns[3].Visible = false;
                    dataGridViewBags.Columns[4].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormBag>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewBags.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormBag>();
                if (dataGridViewBags.SelectedRows.Count == 1)
                {
                    form.Id = Convert.ToInt32(dataGridViewBags.SelectedRows[0].Cells[0].Value);
                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewBags.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridViewBags.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _bagBusinesslogic.Delete(new BagBindingModel { Id = id });
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
    }
}
