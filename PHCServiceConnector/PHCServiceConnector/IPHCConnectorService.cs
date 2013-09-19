using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using ConnectorService.Model.IFModel.VODadosTerminal;
using PHCServiceConnector.Model.FaultVo;

namespace PHCServiceConnector
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPHCConnectorService" in both code and config file together.
    [ServiceContract]
    public interface IPHCConnectorService
    {
        #region Clientes

        /// <summary>
        /// metodo para devolver os clientes
        /// </summary>
        /// <param name="valueFiltroCl"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [OperationContract(AsyncPattern = true)]
       
        [FaultContract(typeof(ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SyncClientes/?DataFilter={valueFiltroCl}")]
        IAsyncResult BeginSyncDadosClientes(string valueFiltroCl, AsyncCallback callback, object state);

        DadosTerminal EndSyncDadosClientes(IAsyncResult result);

        #endregion

        #region Stocks

        /// <summary>
        /// metodo para sincronizar os stocks
        /// </summary>
        /// <param name="valueFiltro"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [OperationContract(AsyncPattern = true)]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SyncStocks/?DataFilter={valueFiltro}")]
        IAsyncResult BeginSyncStocks(string valueFiltro, AsyncCallback callback, object state);

        DadosTerminal EndSyncStocks(IAsyncResult result);
        #endregion

        #region ContasCorrentes

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valueVendedor"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SyncContas/?Vendedor={valueVendedor}")]
        IAsyncResult BeginGetContasCorrentes(string valueVendedor, AsyncCallback callback, object state);

        DadosTerminal EndGetContasCorrentes(IAsyncResult result);
        #endregion
        #region Taxas

        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "/SyncTaxas/")]
        IAsyncResult BeginGetTaxas(AsyncCallback callback, object state);

        DadosTerminal EndGetTaxas(IAsyncResult result);
        #endregion

        

        #region LinhasEncomendas
        /// <summary>
        /// metodo para registar as encomendas efectuadas
        /// </summary>
        /// <param name="valueEncomendas"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(ConnectorServiceFault))]
       
        [WebGet(UriTemplate = "/SyncEncomenda/?EncValue={valueEncomendas}",
            ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        IAsyncResult BeginSyncEncomendas(string valueEncomendas, AsyncCallback callback, object state);

        DadosEncomendas EndSyncEncomendas(IAsyncResult result);
        #endregion

        #region Definicoes

        /// <summary>
        /// metodo para obter as definicoes do terminal
        /// </summary>
        /// <param name="valueMact"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <param name="valueMacw"> </param>
        /// <returns></returns>
        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetDef/?MAW={valueMacw}&MAT={valueMact}")]
       
        IAsyncResult BeginGetDefinicoes(string valueMacw, string valueMact, AsyncCallback callback, object state);

        ConfiguracaoTerminal EndGetDefinicoes(IAsyncResult result);
        #endregion

        #region Chavedeacesso
        /// <summary>
        /// metodo para obter a chave de acesso
        /// </summary>
        /// <param name="valueMacw"></param>
        /// <param name="valueMact"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GETKEY/?MCW={valueMacw}&MCT={valueMact}")]
        
        IAsyncResult BeginGetClientKey(string valueMacw, string valueMact, AsyncCallback callback, object state);
        AcesskeyData EndGetClientKey(IAsyncResult result);


       
        #endregion
    }
}
