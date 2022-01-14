using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.ViewModels;
using System;
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
            var requestList = _requestBusinesslogic.Read(null);
            for (int i = 0; i < requestList.Count; i++)
            {
                if (requestList[i].AgentName != "")
                {
                    requestList.RemoveAt(i);
                    i--;
                }
            }
            if (requestList != null)
            {
                dataGridViewRequestsWithOutPayments.DataSource = requestList;
                dataGridViewRequestsWithOutPayments.Columns[0].Visible = false;
            }

            var requestListFull = _requestBusinesslogic.Read(null);
            for (int i = 0; i < requestListFull.Count; i++)
            {
                if (requestListFull[i].AgentName != Program.Agent.AgentName)
                {
                    requestListFull.RemoveAt(i);
                    i--;
                }
            }
            if (requestListFull != null)
            {
                dataGridViewRequestsWithPayments.DataSource = requestListFull;
                dataGridViewRequestsWithPayments.Columns[0].Visible = false;
            }
        }
        private void buttonCheckRequest_Click(object sender, EventArgs e)
        {

                int id = Convert.ToInt32(dataGridViewRequestsWithOutPayments.SelectedRows[0].Cells[0].Value);
            
            RequestViewModel requestList = _requestBusinesslogic.Read(new RequestBindingModel { Id = id })?[0];
            try
            {
                _requestBusinesslogic.Create(new RequestBindingModel
                {
                    Id = id,
                    RequestSum = requestList.RequestSum,
                    RequestDate = requestList.RequestDate,
                    BagId = requestList.BagId,
                    AgentId = Program.Agent.Id
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }            
            if (dataGridViewRequestsWithOutPayments.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormRequestForAgent>();
                form.Id = (int)id;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }           
        }

        private void dataGridViewRequestsWithOutPayments_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
