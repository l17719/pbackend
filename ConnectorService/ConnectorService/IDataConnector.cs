using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using ConnectorService.Model.IFModel.VODadosTerminal;

namespace ConnectorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataConnector" in both code and config file together.
    [ServiceContract]
    public interface IDataConnector
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
       // [AspNetCacheProfile("DataFeed")]
        [FaultContract(typeof (ConnectorServiceFault))]
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
       // [AspNetCacheProfile("DataFeed")]
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
        [FaultContract(typeof (ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/SyncContas/?Vendedor={valueVendedor}")]
        IAsyncResult BeginGetContasCorrentes(string valueVendedor,AsyncCallback callback, object state);

        DadosTerminal EndGetContasCorrentes(IAsyncResult result);
        #endregion



        #region PNS
        
        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped,RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,
            UriTemplate="/SyncPNS/?Vendedor={valueVendedor}")]
        IAsyncResult BeginGetPns(string valueVendedor, AsyncCallback callback, object state);
        DadosTerminal EndGetPns(IAsyncResult result);
        #endregion


        #region Taxas

        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof (ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "/SyncTaxas/")]
        IAsyncResult BeginGetTaxas(AsyncCallback callback, object state);

        DadosTerminal EndGetTaxas(IAsyncResult result);
        #endregion
        #region Clientes e Stocks e Contas Correntes
        /// <summary>
        /// metodo para obter os dados dos clientes e stocks numa unica chamada remota. anteriormente duas
        /// </summary>
        /// <param name="valueStock"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <param name="valueClientes"> </param>
        /// <returns></returns>
       // [OperationContract(AsyncPattern = true)]
       // [AspNetCacheProfile("DataFeed")]
        //[FaultContract(typeof(ConnectorServiceFault))]
       // [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped,
          //  RequestFormat = WebMessageFormat.Json,
           // ResponseFormat = WebMessageFormat.Json,
           // UriTemplate = "/SyncDadosTerminal/?ClientesValue={valueClientes}&StocksValue={valueStock}")]
        //[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped,RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "/SyncDadosTerminal/?ClientesValue={valueClientes}&StocksValue{valueStock}&CCValue={valueCC)")]
        //IAsyncResult BeginSyncDadosTerminal(string valueClientes, string valueStock, string valueCC, AsyncCallback callback, object state);
        //[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        //    UriTemplate = "/SyncDadosTerminal/?ClientesValue={valueClientes}&StocksValue={valueStock}")]
        //IAsyncResult BeginSyncDadosTerminal(string valueClientes, string valueStock,AsyncCallback callback, object state);
        //DadosTerminal EndSyncDadosTerminal(IAsyncResult result);
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
            ResponseFormat = WebMessageFormat.Json,RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        //[WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped,
        //    ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,
        //    UriTemplate = "/SyncEncomenda/?EncValue={valueEncomendas}")]
        IAsyncResult BeginSyncEncomendas(string valueEncomendas, AsyncCallback callback, object state);

        DadosEncomendas EndSyncEncomendas(IAsyncResult result);
        #endregion

        #region Definicoes

        /// <summary>
        /// metodo para obter as definicoes do terminal
        /// </summary>
        /// <param name="valueMACT"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <param name="valueMACW"> </param>
        /// <returns></returns>
        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(ConnectorServiceFault))]
        [WebGet(BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetDef/?MAW={valueMACW}&MAT={valueMACT}")]
        //
        //[WebInvoke(Method = "GET",
        //    RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/GetDef/?AccessKey={valueAk}")]
        IAsyncResult BeginGetDefinicoes(string valueMACW, string valueMACT, AsyncCallback callback, object state);

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
            RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GETKEY/?MCW={valueMacw}&MCT={valueMact}")]
        //[WebInvoke(Method = "GET",
        //    RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
        //    BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/GETKEY/?MCW={valueMacw}&MCT={valueMact}")]
        IAsyncResult BeginGetClientKey(string valueMacw, string valueMact, AsyncCallback callback, object state);
        AcesskeyData EndGetClientKey(IAsyncResult result);


        [OperationContract(AsyncPattern = true)]
        [FaultContract(typeof(ConnectorServiceFault))]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "/RegKey/?ClientKey={valueRk}")]
        IAsyncResult BeginRegisterKey(string valueRk, AsyncCallback callback, object state);
        string EndRegisterKey(IAsyncResult result);
        #endregion
    }
}
