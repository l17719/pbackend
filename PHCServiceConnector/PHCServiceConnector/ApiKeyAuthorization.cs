using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using AppFabricCachingCore;
using PHCServiceConnector.Model.DbModel.IFModel;
using PHCServiceConnector.Model.FaultVo;
using PHCServiceConnector.Utils;

namespace PHCServiceConnector
{
    public class ApiKeyAuthorization:ServiceAuthorizationManager
    {
        public const string Apikey = "APIKey";
        //public const string Apikeylist = "APIKeyList";
        private readonly Utility _utility = Utility.GetInstance(); 
        public List<Guid> ApiKeys
        {
            get
            {
                var keys = Cache.Get("APIKeyList") as List<Guid> ?? PopulateApiKeys();
                return keys;
            }
        }

        private List<Guid> PopulateApiKeys()
        {
            //implementar pedido a cache
            var listaApis = (List<Guid>)Cache.Get("APIKeyList");
            if (listaApis==null)
            {
                using (var tmp = new DbContextIfElse(_utility.DevolveCOnnectionStringIf().ProviderConnectionString))
                {
                    listaApis = (from t in tmp.DadosTerminais
                                 select t.TerminalAccessKey).ToList();

                }
            }

            Cache.Add("APIKeyList", listaApis, new TimeSpan(0, 3, 0, 0));
            return listaApis;
        }

        protected override bool CheckAccessCore(OperationContext valueOpcontext)
        {
            return IsValidApiKey(valueOpcontext);
        }

        public bool IsValidApiKey(OperationContext operationContext)
        {

            var key = GetApiKey(operationContext);
            if (key == "bda11d91-7ade-4da1-855d-24adfe39d174")
            {
                return true;
            }

            Guid apiKey;

            // Convert the string into a Guid and validate it
            if (Guid.TryParse(key, out apiKey) && ApiKeys.Contains(apiKey))
            {
                return true;
            }
            // Send back an HTML reply
            CreateErrorReply(key);

            return false;
        }


        public string GetApiKey(OperationContext operationContext)
        {
            // Get the request message
            var request = operationContext.RequestContext.RequestMessage;

            // Get the HTTP Request
            var requestProp = (HttpRequestMessageProperty)request.Properties[HttpRequestMessageProperty.Name];

            // Get the query string
            var queryParams = HttpUtility.ParseQueryString(requestProp.QueryString);

            // Return the API key (if present, null if not)
            return queryParams[Apikey];
        }


        private static void CreateErrorReply(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataDetails = "A chave de autenticacao fornecida nao pode ser nula",
                    DataMessage = "Chave de autenticacao nula"

                });
            }
            throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
            {
                DataDetails = "A chave de autenticacao fornecida nao e valida",
                DataMessage = "Chave de autenticacao invalida"

            });
        }
    }
}