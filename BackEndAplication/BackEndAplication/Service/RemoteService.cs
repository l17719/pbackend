using System;
using BackEndAplication.Events;
using BackEndAplication.Models;
using RestSharp;
using RestSharp.Deserializers;

namespace BackEndAplication.Service
{
    public class RemoteService : IRemoteService
    {
        #region properties

        private static RemoteService _instance;
        private string _tempMail;
        private string _tempSerial;

        #endregion

        #region ctor

        public static RemoteService GetInstance()
        {
            return _instance ?? (_instance = new RemoteService());
        }

        #endregion

        #region SerialValidation

        /// <summary>
        /// faz o pedido remoto para validar a chave e o mail do cliente
        /// </summary>
        /// <param name="valueSerial"></param>
        /// <param name="valueMail"></param>
        public void ValidateData(string valueSerial, string valueMail)
        {
            _tempMail = valueMail;
            _tempSerial = valueSerial;

            try
            {
                var rClient = new RestClient("http://localhost:5358/");
                var req = new RestRequest("LicenceCheck/LicService/", Method.GET);
                req.AddParameter("Chave", valueSerial);
                req.AddParameter("MailCliente", valueMail);
                req.AddUrlSegment("Chave", valueSerial);
                req.AddUrlSegment("MailCliente", valueMail);
                req.AddHeader("Content-type", "application/json; charset=utf-8");
                req.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                rClient.AddHandler("text/plain", new JsonDeserializer());
                rClient.Timeout = 120000;
                req.RequestFormat = DataFormat.Json;

                rClient.ExecuteAsync<ResultadoRemoto>(req, clientResponse =>
                                                               {
                                                                   if (clientResponse.ResponseStatus ==
                                                                       ResponseStatus.Completed)
                                                                   {
                                                                       ValidationHandler(clientResponse.Data);
                                                                   }
                                                                   if ((clientResponse.ResponseStatus ==
                                                                        ResponseStatus.None) ||
                                                                       (clientResponse.ResponseStatus ==
                                                                        ResponseStatus.Error))
                                                                   {
                                                                       TimeoutHandler();
                                                                   }
                                                               });
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
        }

        private static void TimeoutHandler()
        {
            EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                          "O servico validacao nao respondeu a tempo"));
        }


        private void ValidationHandler(ResultadoRemoto resp)
        {
            try
            {
                if (resp.CheckLicenceResult.ResultMessage == "OK")
                {
                    var x = new {RegistoAppOK = true, SerialCliente = _tempSerial, ClienteMail = _tempMail};
                    EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.RegistoAplicacao, x));
                }
                else
                {
                    EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                                  "Nao foi possivel registar a aplicacao. digite os dados de novo"));
                }
            }
            catch (Exception ex)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }
        }

        #endregion
    }
}