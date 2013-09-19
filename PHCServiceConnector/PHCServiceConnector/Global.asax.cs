using System;
using System.Configuration;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using PHCServiceConnector.Utils;

namespace PHCServiceConnector
{
    public class Global : HttpApplication
    {
        #region ClassVars
        private readonly LogFactoryManager _logManager = LogFactoryManager.GetInstance();
        #endregion
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes();
            GetCacheData();
            InitializeLog();
            _logManager.WriteInfo(1333, "A iniciar o webService");
        }

        private void InitializeLog()
        {
            _logManager.InitializeLog();
        }

        private static void GetCacheData()
        {
            var container = new UnityContainer();
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Configure(container, "defaultContainer");
            var serviceLocator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => serviceLocator);
        }

        private static void RegisterRoutes()
        {
            var factory = new WebServiceHostFactory();
            RouteTable.Routes.Add(new ServiceRoute("PHCSC", factory, typeof(PHCConnectorService)));
        }
        

        protected void Application_End(object sender, EventArgs e)
        {
            _logManager.WriteInfo(1000, "A Encerrar o webService");
            _logManager.Dispose();
        }
    }
}