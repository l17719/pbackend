using System;
using System.ServiceModel.Activation;
using System.Web.Routing;
using BackendConnector.Utils;

namespace BackendConnector
{
    public class Global : System.Web.HttpApplication
    {
        private readonly LogFactoryManager _logManager = LogFactoryManager.GetInstance();
        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes();
            InitializeLog();
            _logManager.WriteInfo(1333, "A iniciar o webService");
        }

        private void InitializeLog()
        {
            _logManager.InitializeLog();
        }


        private static void RegisterRoutes()
       {
           var factory = new WebServiceHostFactory();
           RouteTable.Routes.Add(new ServiceRoute("LicenceCheck",factory, typeof(BackEndService)));
       }

        protected void Application_End(object sender, EventArgs e)
        {
            _logManager.WriteInfo(1000, "A Encerrar o webService");
            _logManager.Dispose();
        }
    }
}