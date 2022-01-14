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

namespace Securities.AgentView
{
    public partial class Form__Requests__ForAgent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RequestBusinessLogic _requestBusinesslogic;
        public int Id { set { id = value; } }
        private int? id;
        RequestViewModel view;
        public Form__Requests__ForAgent(RequestBusinessLogic requestBusinesslogic)
        {
            InitializeComponent();
            _requestBusinesslogic = requestBusinesslogic;
        }
        private void FormRequestsForAgent_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            var requestList = _requestBusinesslogic.GetModelRequestsForAgents(new RequestBindingModel
            {
                AgentId = 0
            })?[0];
            if (requestList != null)
            {
                dataGridViewRequestsWithOutPayments.DataSource = requestList;
                dataGridViewRequestsWithOutPayments.Columns[0].Visible = false;
            }
        }
        private void buttonCheckRequest_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRequestsWithOutPayments_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewRequestsWithOutPayments.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormRequestForAgent>();
                form.Id = Convert.ToInt32(dataGridViewRequestsWithOutPayments.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
