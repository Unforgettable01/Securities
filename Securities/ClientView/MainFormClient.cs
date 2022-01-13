using Securities.ClientView;
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
    public partial class MainFormClient : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public MainFormClient()
        {
            InitializeComponent();
        }

        private void моиПортфелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormBags>();
            form.ShowDialog();
        }

        private void приобретенныеЦенныеБумагиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormBuySecureties>();
            form.ShowDialog();
        }

        private void эмитентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormEmitenty>();
            form.ShowDialog();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRequest>();
            form.ShowDialog();
        }

        private void договораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormContractBuySale>();
            form.ShowDialog();
        }

        private void оплатаДоговоровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPaymentContractBuySale>();
            form.ShowDialog();
        }
    }
}
