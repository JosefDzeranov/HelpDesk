using HelpDesk.Common.System;

namespace HelpDesk.Common.Application
{
    public class ApplicationDIController
    {
        public void Start()
        {            
            RegisterSystems();                       
        }

        private void RegisterSystems()
        {          
            SystemManager.Register(this);            
            SystemManager.Register<IProvider>(() => new JsonStorage());
        }
    }
}
