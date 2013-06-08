using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace BackendConnector
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBackEndService" in both code and config file together.
    [ServiceContract]
    public interface IBackEndService
    {
        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(BackendConnectorFault))]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/LicService/?Chave={valorChave}&MailCliente={valorMail}")]
        IAsyncResult BeginCheckLicence(string valorChave, string valorMail, AsyncCallback callback, object state);
        ConnectorResponse EndCheckLicence(IAsyncResult result);
        //string EndCheckLicence(IAsyncResult result);


        [OperationContract]
        [FaultContract(typeof (BackendConnectorFault))]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SincLicService/?Chave={Chave}&?MailCliente={Mail}")]

        string SincService(string Chave, string Mail);

    }
}
