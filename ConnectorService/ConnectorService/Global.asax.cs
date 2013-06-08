using System;
using System.Web;
using System.ServiceModel.Activation;
using System.Web.Routing;
using ConnectorService.Utilities;

namespace ConnectorService
{
    public class Global : HttpApplication
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

        private void RegisterRoutes()
        {
            var factory = new WebServiceHostFactory();
            RouteTable.Routes.Add(new ServiceRoute("DataFeed", factory, typeof(DataConnector)));
           
           
        }
        //protected void Session_Start(object sender, EventArgs e)
        //{

        //}

        //protected void Application_BeginRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_AuthenticateRequest(object sender, EventArgs e)
        //{

        //}

        //protected void Application_Error(object sender, EventArgs e)
        //{

        //}

        //protected void Session_End(object sender, EventArgs e)
        //{

        //}

        protected void Application_End(object sender, EventArgs e)
        {
            _logManager.WriteInfo(1000, "A Encerrar o webService");
            _logManager.Dispose();
        }
    }
}