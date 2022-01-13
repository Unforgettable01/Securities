using SecuritiesBusinessLogic.BusinessLogics;
using SecuritiesBusinessLogic.Interfaces;
using SecuritiesDatabase.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;


namespace Securities
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormaAuthorization>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IEmitentStorage, EmitentStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<EmitentBusinessLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IClientStorage, ClientStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ClientBusinessLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IAgentStorage, AgentStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<AgentBusinessLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<IBagStorage, BagStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<BagBusinessLogic>(new HierarchicalLifetimeManager());

            currentContainer.RegisterType<ISecurityStorage, SecurityStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<SecurityBusinessLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
        }
    }
