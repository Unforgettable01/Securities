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
    public partial class FormClients : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientBusinessLogic _emitentBusinesslogic;
        ClientViewModel view;
        public int Id { set { id = value; } }
        private int? id;
        public FormClients(ClientBusinessLogic emitentBusinesslogic)
        {
            InitializeComponent();
            _emitentBusinesslogic = emitentBusinesslogic;
        }

        private void FormClients_Load(object sender, EventArgs e)
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
                    dataGridViewAgents.DataSource = list;
                    dataGridViewAgents.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
