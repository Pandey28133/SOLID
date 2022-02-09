using Autofac;
using DependencyInjectionLibrary;
using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            //BusinessLogic businessLogic = new BusinessLogic();
            //businessLogic.ProcessData();
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var uiApp = scope.Resolve<IUIApllication>();

                uiApp.Start();
            }
        }
    }
}
