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
    public partial class FormRequestForAgent : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public FormRequestForAgent()
        {
            InitializeComponent();
        }
        public int Id { set { id = value; } }
        private int? id;
    }
}
