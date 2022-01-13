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
    public partial class FormaAuthorization : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public FormaAuthorization()
        {
            InitializeComponent();
        }

        private void buttonEnterSystem_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "admin")
            {
                var form = Container.Resolve<MainFormAgent>();
                form.ShowDialog();
            }
            else if (textBoxLogin.Text == "client")
            {
                var form = Container.Resolve<MainFormClient>();
                form.ShowDialog();
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRegistration>();
            form.ShowDialog();
        }
    }
}
