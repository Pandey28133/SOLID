using Autofac;
using DependencyInjectionLibrary;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using DependencyInjectionLibrary.Utilities;

namespace Dependency_Injection
{
  public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UIApllication>().As<IUIApllication>();

            // Regirster one class from Library
            builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterType<DataAccess>().As<IDataAccess>();

            // Regirster all classes in a folder from Library.

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependencyInjectionLibrary)))
            //    .Where(lib => lib.Namespace.Contains("Utilites"))
            //    .As(lib => lib.GetInterfaces().FirstOrDefault(i => i.Name == "I" + lib.Name));




            return builder.Build();
        }
    }
}
 