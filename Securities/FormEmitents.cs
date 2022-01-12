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
    public partial class FormEmitents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly EmitentBusinessLogic _emitentBusinesslogic;
        EmitentViewModel view;
        public int Id { set { id = value; } }
        private int? id;
        public FormEmitents(EmitentBusinessLogic emitentBusinesslogic)
        {
            InitializeComponent();
            _emitentBusinesslogic = emitentBusinesslogic;
        }

        private void FormEmitents_Load(object sender, EventArgs e)
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
                    dataGridViewEmitents.DataSource = list;
                    dataGridViewEmitents.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
