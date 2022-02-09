using DependencyInjectionLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Injection
{
    public class UIApllication : IUIApllication
    {
        private readonly IBusinessLogic _businessLogic;

        public UIApllication(IBusinessLogic businessLogic)
        {
            this._businessLogic = businessLogic;
        }

        public void Start()
        {
            _businessLogic.ProcessData();
        }
    }
}
