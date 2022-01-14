using SecuritiesBusinessLogic.BindingModels;
using SecuritiesBusinessLogic.ViewModels;
using SecuritiesBusinessLogic.BusinessLogics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;
using System.Text.RegularExpressions;
using Securities.ClientView;

namespace Securities
{
    public partial class FormaAuthorization : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientBusinessLogic _clientlogic;
        private readonly AgentBusinessLogic _agentlogic;
        public FormaAuthorization(ClientBusinessLogic clientlogic, AgentBusinessLogic agentlogic)
        {
            InitializeComponent();
            _clientlogic = clientlogic;
            _agentlogic = agentlogic;
        }

        private void buttonEnterSystem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            var client = _clientlogic.GetClientLP(new ClientBindingModel
            {
                ClientLogin = textBoxLogin.Text,
                ClientPassword = textBoxPassword.Text
            })?[0];
            var agent = _agentlogic.GetAgentLP(new AgentBindingModel
            {
                AgentLogin = textBoxLogin.Text,
                AgentPassword = textBoxPassword.Text
            })?[0];
            if (client != null)
            {
                var form = Container.Resolve<MainFormClient>();
                Program.Client = client;
                form.ShowDialog();
                
            }
            else if (agent != null)
            {
                var form = Container.Resolve<MainFormAgent>();
                Program.Agent = agent;
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пользователь не найден, зарегистрируйтесь", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRegistration>();
            form.ShowDialog();
        }
    }
}
