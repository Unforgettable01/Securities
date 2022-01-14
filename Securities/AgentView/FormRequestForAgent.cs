using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Securities.AgentView
{
    public partial class FormRequestForAgent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RequestBusinessLogic _requestBusinesslogic;
        private readonly BagBusinessLogic _bagBusinesslogic;
        public int Id { set { id = value; } }
        private int? id;

        private Dictionary<int?, (string, int?, decimal?)> bagSecurities;
        public FormRequestForAgent(RequestBusinessLogic requestBusinesslogic, BagBusinessLogic bagBusinesslogic)
        {
            InitializeComponent();
            _requestBusinesslogic = requestBusinesslogic;
            _bagBusinesslogic = bagBusinesslogic;
        }
        private void FormRequestsForAgent_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {

            var requestList = _requestBusinesslogic.Read(null);

            for (int i = 0; i < requestList.Count; i++)
            {
                if (requestList[i].Id != id)
                {
                    requestList.RemoveAt(i);
                    i--;
                }
            }
            if (requestList != null)
            {
                dataGridViewRequest.DataSource = requestList;
                dataGridViewRequest.Columns[0].Visible = false;
            }

            BagViewModel view = _bagBusinesslogic.Read(new BagBindingModel
            {
                Id = requestList[0].BagId
            })?[0];
            if (view != null)
            {
                bagSecurities = view.BagSecurities;
            }
                if (bagSecurities != null)
            {
                dataGridViewSecuritiesInBag.Rows.Clear();
                foreach (var pc in bagSecurities)
                {
                    dataGridViewSecuritiesInBag.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2, pc.Value.Item3 });
                   // result += (decimal)pc.Value.Item3;
                }
            }
        }

        private void buttonContractWithEmitents_Click(object sender, EventArgs e)
        {

        }
    }
}
