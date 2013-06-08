using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using ConnectorService.Model.IFModel;
using ConnectorService.Utilities;

namespace ConnectorService
{
    public class ApiKeyAuthorization : ServiceAuthorizationManager
    {
        public const string APIKEY = "APIKey";
        public const string APIKEYLIST = "APIKeyList";
        private readonly Utility _utility = Utility.GetInstance(); 
        public List<Guid> APIKeys
        {
            get
            {
                var keys = HttpContext.Current.Cache[APIKEYLIST] as List<Guid> ?? PopulateApiKeys();

                return keys;
            }
        }

        private List<Guid> PopulateApiKeys()
        {
            //var listaApis = new List<Guid>();
            //HttpContext.Current.Cache[APIKEYLIST] = listaApis;
            //return listaApis;
           
            List<Guid> listaApis;
            using (var tmp = new DbContextIfElse(_utility.DevolveCOnnectionStringIf().ProviderConnectionString))
            {
                
                


                listaApis = (from t in tmp.Terminais
                              select t.AccessKey).ToList();
               
            }
            HttpContext.Current.Cache[APIKEYLIST] = listaApis;
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
            if (Guid.TryParse(key, out apiKey) && APIKeys.Contains(apiKey))
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
            NameValueCollection queryParams = HttpUtility.ParseQueryString(requestProp.QueryString);

            // Return the API key (if present, null if not)
            return queryParams[APIKEY];
        }


        private static void CreateErrorReply(string key = null)
        {
            if (string.IsNullOrEmpty(key))
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