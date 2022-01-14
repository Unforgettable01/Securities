using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Securities.ClientView
{
    public partial class FormBagCheck : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly BagBusinessLogic _bagBusinesslogic;
        private readonly SecurityBusinessLogic _securityBusinesslogic;
        private int? id;
        private Dictionary<int?, (string, int?, decimal?)> bagSecurities;
        public FormBagCheck(BagBusinessLogic bagBusinesslogic, SecurityBusinessLogic securityBusinesslogic)
        {
            InitializeComponent();
            _securityBusinesslogic = securityBusinesslogic;
            _bagBusinesslogic = bagBusinesslogic;
        }

        private void FormBagCheck_Load(object sender, EventArgs e)
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
        private void LoadData()
        {
            try
            {
                if (bagSecurities != null)
                {
                    dataGridViewSecurities.Rows.Clear();
                    foreach (var pc in bagSecurities)
                    {
                        dataGridViewSecurities.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2, pc.Value.Item3 });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
