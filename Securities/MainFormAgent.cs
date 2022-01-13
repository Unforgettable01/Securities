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
    public partial class MainFormAgent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public MainFormAgent()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClients>();
            form.ShowDialog();
        }

        private void эмитентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormEmitents>();
            form.ShowDialog();
        }

        private void ценныеБумагиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSecurities>();
            form.ShowDialog();
        }
    }
}
