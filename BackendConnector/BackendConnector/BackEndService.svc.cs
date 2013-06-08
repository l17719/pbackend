using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Threading.Tasks;
using System.Linq;
using BackendConnector.Model;
using BackendConnector.Utils;
namespace BackendConnector
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BackEndService" in code, svc and config file together.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class BackEndService : IBackEndService
    {
        #region Propriedades
        private readonly Utility _utility = Utility.GetInstance();
        private Licenca _licenca;
        private readonly LogFactoryManager _logManager = LogFactoryManager.GetInstance();
        #endregion

        #region Metodos

        public IAsyncResult BeginCheckLicence(string valorChave, string valorMail, AsyncCallback callback, object state)
        {
           
            try
            {
                _licenca = new Licenca
                               {
                                   ChaveSerial = valorChave,
                                   Mail = valorMail
                               };


                var task = Task<ConnectorResponse>.Factory.StartNew(VerificaDadosLicenca, state);
                //var task = Task<string>.Factory.StartNew(VerificaDadosLicenca, state);
                return task.ContinueWith(res => callback(task));
               

            }
            catch(Exception ex)
            {
                _logManager.WriteError(1200, "Erro ao registar encomendas ocorreu o seguinte erro:" + ex.Source + " \n" + ex.InnerException.Message + "\n" + ex.Message);
                throw new FaultException<BackendConnectorFault>(new BackendConnectorFault
                {

                    ErrorDetails = ex.Message,
                    ErrorMessage = "Ocorreu uma excepcao no servico Backend Connector",
                    Result = false
                });
            }
           
        }


        private ConnectorResponse VerificaDadosLicenca(object state)
        //private string VerificaDadosLicenca(object state)
        {
           // var resultado="";
            var resultado = new ConnectorResponse();
            if ((_licenca.Mail == null) || (_licenca.Mail == null))
            {
                _logManager.WriteError(1200, "Erro ao obter os dados da licenca, nao foram introduzidos parametros");
                resultado.ResultMessage = "NO DATA INSERTED";
                //resultado = "NO DATA INSERTED";
                


            }
            else
            {
               resultado.ResultMessage = "OK";
                //resultado = "OK";
               using (var contextolic=new LicModelDbContext(_utility.DevolveCOnnectionString().ProviderConnectionString))
               {

                   try
                   {
                       contextolic.Configuration.AutoDetectChangesEnabled = false;
                       var query = (from c in contextolic.DadosLicenca
                                    where c.MailCliente == _licenca.Mail && c.SerialCliente == _licenca.ChaveSerial
                                    select c.Id).First();

                       if (query != null)
                       {
                           resultado.ResultMessage = "OK";
                       }

                   }
                   finally
                   {
                       contextolic.Configuration.AutoDetectChangesEnabled = true;
                   }
                   
               }

            }

            return resultado;
        }


        public ConnectorResponse EndCheckLicence(IAsyncResult resultado)
        //public string EndCheckLicence(IAsyncResult resultado)
        {
            
            return ((Task<ConnectorResponse>)resultado).Result;
            //return ((Task<string>)resultado).Result;
            
        }
        #region SyncOperation
        public string SincService(string Chave, string Mail)
        {
            var resultado = "";
            if ((Chave == null) || (Mail == null))
            {
                resultado = "NO DATA INSERTED";
            }
            else
            {
                resultado = "OK";
            }

            return resultado;
        }
        #endregion
        #endregion
    }
}
