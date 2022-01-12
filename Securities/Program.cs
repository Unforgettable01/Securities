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
            Application.Run(container.Resolve<FormEmitents>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IEmitentStorage, EmitentStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<EmitentBusinessLogic>(new HierarchicalLifetimeManager());

            return currentContainer;
        }
        }
    }
