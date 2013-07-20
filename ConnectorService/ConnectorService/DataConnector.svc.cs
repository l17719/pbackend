using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Threading.Tasks;
using ConnectorService.Model.IFModel;
using ConnectorService.Model.IFModel.VODadosTerminal;
using ConnectorService.Model.PHCModel;
using ConnectorService.Model.PHCModel.VODadosPHC;
using ConnectorService.Utilities;
using System.Linq.Dynamic;
namespace ConnectorService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class DataConnector : IDataConnector
    {
        #region classvars

        // private string _valueAkDef;
        // private string _valueMt;
        // private string _valueMw;
        private readonly Utility _utility = Utility.GetInstance();
        private string _filterClientes;
        private string _filterStocks;
        private string _valueVendContas;

        private string _valueEncomendas;
        private string _valueMacW;
        private string _valueMacG;
        private readonly LogFactoryManager _logManager = LogFactoryManager.GetInstance();
        #endregion
        #region Implementation of IDataService


        #region Encomendas

        

        /// <summary>
        /// metodo para sincronizar as encomendas
        /// </summary>
        /// <param name="value"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>

        public IAsyncResult BeginSyncEncomendas(string value, AsyncCallback callback, object state)
        {


            _valueEncomendas = value;
            var t = Task<DadosEncomendas>.Factory.StartNew(WorkerRegistaEncomendas, state);
            return t.ContinueWith(res => callback(t));


        }

        private DadosEncomendas WorkerRegistaEncomendas(object state)
        {
            
            var resultado = new DadosEncomendas();
            try
            {
                var listBiResult = new List<VoBi>();
                var listBoResult = new List<Vobo>();
                if (string.IsNullOrEmpty(_valueEncomendas))
                {
                    _logManager.WriteError(1200, "Erro ao registar encomendas nao existem parametros a registar");
                    throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                    {
                        DataDetails = "Nao foram introduzidos valores para a as encomendas",
                        DataMessage = "Sem valores para encomendas"
                    });
                }


                using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
                {
                    //old code
                    var tmpBi = _utility.DeserializeBi(_valueEncomendas);
                    var tmpBo = _utility.DeserializeBo(_valueEncomendas);
                    //
                   // var tmpBi = _utility.DeserializeRemoteBi(_valueEncomendas);
                   // var tmpBo = _utility.DeserializeRemotebBo(_valueEncomendas);

                    _valueEncomendas = "";
                    foreach (var item in tmpBo)
                    {
                        var tmpitembo = _utility.ConvertVoBoTbBo(item);
                        //var tmpItembo = _utility.ConvertRemoteBoToTb(item);
                         tmp.DadosCabecalhosEncomendas.Add(tmpitembo);
                        //tmp.DadosCabecalhosEncomendas.Add(tmpItembo);
                        //tmp.DadosCabecalhosEncomendasExt.Add(_utility.GenerateBo2(item.BOstamp));
                        tmp.DadosCabecalhosEncomendasExt.Add(_utility.GenerateBo2(tmpitembo.Bostamp));
                        listBoResult.Add(item);

                    }
                    //tmp.SaveChanges();

                    foreach (var item in tmpBi)
                    {
                       var tmpitem = _utility.ConvertVoTb(item);
                        //var tmpitem = _utility.ConvertRemoveBiTb(item);
                        tmp.DadosLinhasEncomendas.Add(tmpitem);
                        //tmp.LinhasEncomendas.Add(_utility.ConvertVoTb(item));
                        //tmp.DadosLinhasEncomendas.Add(_utility.ConvertVoTb(item));
                        tmp.DadosLinhasEncomendasExt.Add(_utility.GenerateBi2(tmpitem.Bistamp));
                        listBiResult.Add(item);
                    }


                    tmp.SaveChanges();
                    resultado.DadosCabeca = listBoResult;
                    resultado.DadosLinhas = listBiResult;

                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationError in ex.EntityValidationErrors.SelectMany(validationE => validationE.ValidationErrors))
                {
                    //Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    _logManager.WriteError(1200, "Erro ao registar as encomendas na base de dados ocorreu o seguinte erro:" + validationError.PropertyName + " \n" + validationError.ErrorMessage);
                    throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                    {
                        DataDetails = "Nao foi possivel introduzir as encomendas, por favor contacte o administrador da plataforma",
                        DataMessage = "Erro ao introduzir as encomendas os campos nao foram preenchidos correctamente"
                    });
                }
            }
            catch (Exception e)
            {
                if (e.InnerException == null)
                {
                    _logManager.WriteError(1200, "Erro ao registar encomendas ocorreu o seguinte erro:" + e.Source + " \n" + e.Message);
                }
                else
                {
                    _logManager.WriteError(1200, "Erro ao registar encomendas ocorreu o seguinte erro:" +
                                           e.Source + " \n" + e.InnerException);
                }

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataDetails = "Nao foi possivel introduzir as encomendas, por favor contacte o administrador da plataforma",
                    DataMessage = "Erro ao introduzir as encomendas"
                });
            }

            return resultado;
        }
        public DadosEncomendas EndSyncEncomendas(IAsyncResult result)
        {
            return ((Task<DadosEncomendas>)result).Result;

        }
        #endregion

        #region LinhasRecibos
        public IAsyncResult BeginSyncLinhasRecibos(string value, AsyncCallback callback, object state)
        {
            try
            {
                var t = Task<string>.Factory.StartNew(WorkerRegistaLinhasRecibos, state);
                return t.ContinueWith(res => callback(t));
            }
            catch (Exception e)
            {

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataDetails = e.Message,
                    DataMessage = "Ocorreu uma excepcao no servico ao sincronizar as Linhas Recibos "
                });
            }

        }

        private string WorkerRegistaLinhasRecibos(object state)
        {
            return "";
        }
        public string EndSyncLinhasRecibos(IAsyncResult result)
        {
            try
            {
                return ((Task<string>)result).Result;
            }
            catch (Exception e)
            {

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataDetails = e.Message,
                    DataMessage = "Ocorreu uma excepcao no servico ao sincronizar as Linhas Recibos "
                });
            }

        }



        #endregion


        #region GetDefinicoes

        /// <summary>
        /// metodos para devolver as definicoes do terminal
        /// </summary>
        /// <param name="valueMACT"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <param name="valueMACW"> </param>
        /// <returns></returns>
        public IAsyncResult BeginGetDefinicoes(string valueMACW, string valueMACT, AsyncCallback callback, object state)
        {

            _valueMacG = valueMACT;
            _valueMacW = valueMACW;

            var task = Task<ConfiguracaoTerminal>.Factory.StartNew(WorkerDevolveDefinicoes, state);
            return task.ContinueWith(res => callback(task));



        }

        private ConfiguracaoTerminal WorkerDevolveDefinicoes(object state)
        {
            var resultado = new ConfiguracaoTerminal();
            try
            {
                if ((!string.IsNullOrEmpty(_valueMacG)) || (!string.IsNullOrEmpty(_valueMacW)))
                {
                    //var tmpConnStr=_utility.DevolveCOnnectionStringIf().ConnectionString;
                    using (var tmpConn = new DbContextIfElse(_utility.DevolveCOnnectionStringIf().ProviderConnectionString))
                    {


                        try
                        {
                            tmpConn.Configuration.AutoDetectChangesEnabled = false;


                            TbTerminais tmptbterminals;
                            if ((!string.IsNullOrEmpty(_valueMacW)) && (!string.IsNullOrEmpty(_valueMacG)))
                            {
                                tmptbterminals = (from t in tmpConn.Terminais
                                                  where t.MacAddressG == _valueMacG && t.MacAddressW == _valueMacW
                                                  select t).SingleOrDefault();
                            }
                            else
                            {
                                tmptbterminals = (string.IsNullOrEmpty(_valueMacG)) &&
                                                 (!string.IsNullOrEmpty(_valueMacW))
                                                     ? (from t in tmpConn.Terminais
                                                        where t.MacAddressW == _valueMacW
                                                        select t).SingleOrDefault()
                                                     : (from t in tmpConn.Terminais
                                                        where t.MacAddressG == _valueMacG
                                                        select t).SingleOrDefault();
                            }

                            TbOpcoesTerminal tmpOp;
                            if (tmptbterminals != null)
                            {
                                tmpOp = (from t in tmpConn.OpcoesTerminais
                                         where t.Id == tmptbterminals.OpcoesTerminalId
                                         select t).SingleOrDefault();
                            }
                            else
                            {
                                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                                                                                    {
                                                                                        DataMessage = "Nao existem dados para transferir",
                                                                                        DataDetails = "Erro ao obter os dados para o terminal"
                                                                                    });
                            }

                            resultado = _utility.SerializeConfigTerminal(tmptbterminals, tmpOp);

                            //resultado = tmptbterminals == null ? "Sem valores encontrados" : _utility.SerializeConfigTerminal(tmptbterminals, tmpOp);
                        }
                        finally
                        {
                            tmpConn.Configuration.AutoDetectChangesEnabled = true;
                        }



                    }

                }
                return resultado;
            }
            catch (Exception e)
            {
                if (e.InnerException == null)
                {
                    _logManager.WriteError(1200, "Erro ao obter as definicoes do terminal,ocorreu o seguinte erro:" + e.Source + " \n" + e.Message);
                }
                else
                {
                    _logManager.WriteError(1200, "Erro ao obter as definicoes do terminal,ocorreu o seguinte erro:" + e.Source + " \n" + e.InnerException);
                }

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataDetails = "Nao foi possivel obter as definicoes do terminal por favor volte a tentar mais tarde",
                    DataMessage = "Ocorreu um erro ao obter a informacao do terminal"
                });
            }
        }
        public ConfiguracaoTerminal EndGetDefinicoes(IAsyncResult result)
        {
            return ((Task<ConfiguracaoTerminal>)result).Result;
        }

        #endregion

        

        #region DadosClientes

        /// <summary>
        /// metodo para devolver os clientes
        /// </summary>
        /// <param name="valueFiltroCl"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public IAsyncResult BeginSyncDadosClientes(string valueFiltroCl, AsyncCallback callback, object state)
        {
            _filterClientes = valueFiltroCl;
            var t = Task<DadosTerminal>.Factory.StartNew(WorkerSyncClientes, state);
            return t.ContinueWith(res => callback(t));
        }

        private DadosTerminal WorkerSyncClientes(object state)
        {
            DadosTerminal resultado;
            try
            {
                using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
                {
                    try
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = false;
                        var tmpCl = new List<Cl>();
                        var tfiltercl = (from t in tmp.DadosFiltrosClientes
                                         where t.Fltclstamp == _filterClientes
                                         select t.Xbase).Single();


                        if ((string.IsNullOrEmpty(tfiltercl)))
                        {
                            throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                            {
                                DataDetails = "Nao foram fornecidos dados para obter os parametros PHC CL",
                                DataMessage = "Erro ao obter os parametros PHC CL"
                            });
                        }

                        var tmpArrCl = new string[0];
                        if (!string.IsNullOrEmpty(tfiltercl))
                        {

                            tmpArrCl = tfiltercl.Split(',');
                        }

                        if (tmpArrCl.Any())
                        {
                            var tmpQueryCl = tmpArrCl[0];
                            var clParams = _utility.ConvertDataQuery(tmpArrCl);
                            var filteredCl = tmp.DadosClientes
                                .Where(tmpQueryCl, clParams)
                                .Select("New(clstamp as ClStamp,preco as Preco," +
                                         "tabiva as TabIva,desconto as Desconto, " +
                                         "nocredit as Nocredit,no as No, estab as Estab,nome as Nome,nome2 as Nome2," +
                                         " morada as Morada,local as Local, codpost as CodPost, obs as Obs,tlmvl as Tlmvl, " +
                                         "telefone as Telefone, email as Email," +
                                         " esaldo as Esaldo,statuspda as Statuspda, vendedor as Vendedor,vendnm as Vendnm, " +
                                         "ncont as Ncont, tipo as Tipo, contacto as Contacto, inactivo as Inactivo)");


                            if (filteredCl.Any())
                            {

                                Array.Clear(tmpArrCl, 0, tmpArrCl.Length);
                                var tmpEnum = filteredCl.GetEnumerator();
                                while (tmpEnum.MoveNext())
                                {
                                    var tmpCurrentEnum = tmpEnum.Current;
                                    var tmpStamp = tmpCurrentEnum.GetType().GetProperty("ClStamp");
                                    var tmpPreco = tmpCurrentEnum.GetType().GetProperty("Preco");
                                    var tmpTabiva = tmpCurrentEnum.GetType().GetProperty("TabIva");
                                    var tmpDesconto = tmpCurrentEnum.GetType().GetProperty("Desconto");
                                    var tmpNocredit = tmpCurrentEnum.GetType().GetProperty("Nocredit");
                                    var tmpNo = tmpCurrentEnum.GetType().GetProperty("No");
                                    var tmpEstab = tmpCurrentEnum.GetType().GetProperty("Estab");
                                    var tmpNome = tmpCurrentEnum.GetType().GetProperty("Nome");
                                    var tmpNome2 = tmpCurrentEnum.GetType().GetProperty("Nome2");
                                    var tmpMorada = tmpCurrentEnum.GetType().GetProperty("Morada");
                                    var tmpLocal = tmpCurrentEnum.GetType().GetProperty("Local");
                                    var tmpCodPost = tmpCurrentEnum.GetType().GetProperty("CodPost");
                                    var tmpObs = tmpCurrentEnum.GetType().GetProperty("Obs");
                                    var tmpTlmvl = tmpCurrentEnum.GetType().GetProperty("Tlmvl");
                                    var tmpTelefone = tmpCurrentEnum.GetType().GetProperty("Telefone");
                                    var tmpEmail = tmpCurrentEnum.GetType().GetProperty("Email");
                                    var tmpEsaldo = tmpCurrentEnum.GetType().GetProperty("Esaldo");
                                    var tmpStatuspda = tmpCurrentEnum.GetType().GetProperty("Statuspda");
                                    var tmpVendedor = tmpCurrentEnum.GetType().GetProperty("Vendedor");
                                    var tmpVendnm = tmpCurrentEnum.GetType().GetProperty("Vendnm");
                                    var tmpNcont = tmpCurrentEnum.GetType().GetProperty("Ncont");
                                    var tmpTipo = tmpCurrentEnum.GetType().GetProperty("Tipo");
                                    var tmpContacto = tmpCurrentEnum.GetType().GetProperty("Contacto");
                                    var tmpInactivo = tmpCurrentEnum.GetType().GetProperty("Inactivo");
                                    tmpCl.Add(new Cl
                                    {
                                        Clstamp = tmpStamp.GetValue(tmpCurrentEnum, null).ToString(),
                                        Preco = decimal.Parse(tmpPreco.GetValue(tmpCurrentEnum, null).ToString()),
                                        Tabiva = decimal.Parse(tmpTabiva.GetValue(tmpCurrentEnum, null).ToString()),
                                        Desconto = decimal.Parse(tmpDesconto.GetValue(tmpCurrentEnum, null).ToString()),
                                        Nocredit = bool.Parse(tmpNocredit.GetValue(tmpCurrentEnum, null).ToString()),
                                        No = decimal.Parse(tmpNo.GetValue(tmpCurrentEnum, null).ToString()),
                                        Estab = decimal.Parse(tmpEstab.GetValue(tmpCurrentEnum, null).ToString()),
                                        Nome = tmpNome.GetValue(tmpCurrentEnum, null).ToString(),
                                        Nome2 = tmpNome2.GetValue(tmpCurrentEnum, null).ToString(),
                                        Morada = tmpMorada.GetValue(tmpCurrentEnum, null).ToString(),
                                        Local = tmpLocal.GetValue(tmpCurrentEnum, null).ToString(),
                                        Codpost = tmpCodPost.GetValue(tmpCurrentEnum, null).ToString(),
                                        Obs = tmpObs.GetValue(tmpCurrentEnum, null).ToString(),
                                        Tlmvl = tmpTlmvl.GetValue(tmpCurrentEnum, null).ToString(),
                                        Telefone = tmpTelefone.GetValue(tmpCurrentEnum, null).ToString(),
                                        Email = tmpEmail.GetValue(tmpCurrentEnum, null).ToString(),
                                        Esaldo = decimal.Parse(tmpEsaldo.GetValue(tmpCurrentEnum, null).ToString()),
                                        Statuspda = tmpStatuspda.GetValue(tmpCurrentEnum, null).ToString(),
                                        Vendedor = decimal.Parse(tmpVendedor.GetValue(tmpCurrentEnum, null).ToString()),
                                        Vendnm = tmpVendnm.GetValue(tmpCurrentEnum, null).ToString(),
                                        Ncont = tmpNcont.GetValue(tmpCurrentEnum, null).ToString(),
                                        Tipo = tmpTipo.GetValue(tmpCurrentEnum, null).ToString(),
                                        Contacto = tmpContacto.GetValue(tmpCurrentEnum, null).ToString(),
                                        Inactivo = bool.Parse(tmpInactivo.GetValue(tmpCurrentEnum, null).ToString())
                                    });
                                }

                            }
                        }

                        


                        resultado = _utility.SerializeClientes(tmpCl, new List<Cc>());

                    }
                    finally
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = true;
                    }
                }
            }
            catch (Exception e)
            {
                if (e.InnerException == null)
                {
                    _logManager.WriteError(1200, "WorkerSyncClientes: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
                }
                else
                {
                    _logManager.WriteError(1200, "WorkerSyncClientes: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException);
                }

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
                    DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
                });
            }
            return resultado;
        }
        public DadosTerminal EndSyncDadosClientes(IAsyncResult result)
        {
            return ((Task<DadosTerminal>)result).Result;
        }


        #endregion

        #region Stocks

        /// <summary>
        /// metodo para sincronizar os stocks
        /// </summary>
        /// <param name="valueFiltro"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public IAsyncResult BeginSyncStocks(string valueFiltro, AsyncCallback callback, object state)
        {
            _filterStocks = valueFiltro;
            var tsk = Task<DadosTerminal>.Factory.StartNew(WorkerDevolveStocks, state);
            return tsk.ContinueWith(res => callback(tsk));

        }

        private DadosTerminal WorkerDevolveStocks(object arg)
        {
            DadosTerminal resultado;


            try
            {
                using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
                {
                    try
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = false;

                        


                        var tmpSt = new List<St>();
                        var tmpfilterst = (from t in tmp.DadosFiltrosStocks
                                           where t.Fltststamp == _filterStocks
                                           select t.Xbase).SingleOrDefault();


                        if (string.IsNullOrEmpty(tmpfilterst))
                        {
                            throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                            {
                                DataDetails = "Nao foram fornecidos dados para obter os parametros PHC",
                                DataMessage = "Erro ao obter os parametros PHC"
                            });
                        }
                        var tmpArrSt = new string[0];
                        if (!string.IsNullOrEmpty(tmpfilterst))
                        {

                            tmpArrSt = tmpfilterst.Split(',');
                        }
                        if (tmpArrSt.Any())
                        {
                            var tmpQuerySt = tmpArrSt[0];

                            var stParams = _utility.ConvertDataQuery(tmpArrSt);
                            var filtereredstock = tmp.DadosStocks.
                                Where(tmpQuerySt, stParams).Select("New(ststamp as Stamp,StReferencia " +
                                                                   "as StReferencia,tabiva as Tabiva,bloqueado as Bloqueado, " +
                                                                   "codigo as Codigo,forref as Forref, design as Design,familia as " +
                                                                   "Familia,epv1 as Epv1,epv2 as Epv2,epv3 as Epv3, epv4 as Epv4, epv5 as Epv5)");




                            if (filtereredstock.Any())
                            {


                                Array.Clear(tmpArrSt, 0, tmpArrSt.Length);
                                var tmpEnum = filtereredstock.GetEnumerator();
                                while (tmpEnum.MoveNext())
                                {
                                    var tmpCurrentEnum = tmpEnum.Current;
                                    var sStamp = tmpCurrentEnum.GetType().GetProperty("Stamp");
                                    var tmpStReferencia = tmpCurrentEnum.GetType().GetProperty("StReferencia");
                                    var tmpTabiva = tmpCurrentEnum.GetType().GetProperty("Tabiva");
                                    var tmpBloqueado = tmpCurrentEnum.GetType().GetProperty("Bloqueado");
                                    var tmpCodigo = tmpCurrentEnum.GetType().GetProperty("Codigo");
                                    var tmpForref = tmpCurrentEnum.GetType().GetProperty("Forref");
                                    var tmpDesign = tmpCurrentEnum.GetType().GetProperty("Design");
                                    var tmpFamilia = tmpCurrentEnum.GetType().GetProperty("Familia");
                                    var tmpEpv1 = tmpCurrentEnum.GetType().GetProperty("Epv1");
                                    var tmpEpv2 = tmpCurrentEnum.GetType().GetProperty("Epv2");
                                    var tmpepv3 = tmpCurrentEnum.GetType().GetProperty("Epv3");
                                    var tmpepv4 = tmpCurrentEnum.GetType().GetProperty("Epv4");
                                    var tmpepv5 = tmpCurrentEnum.GetType().GetProperty("Epv5");
                                    tmpSt.Add(new St
                                    {
                                        Ststamp = sStamp.GetValue(tmpCurrentEnum, null).ToString(),
                                        StReferencia = tmpStReferencia.GetValue(tmpCurrentEnum, null).ToString(),
                                        Tabiva = decimal.Parse(tmpTabiva.GetValue(tmpCurrentEnum, null).ToString()),
                                        Bloqueado = bool.Parse(tmpBloqueado.GetValue(tmpCurrentEnum, null).ToString()),
                                        Codigo = tmpCodigo.GetValue(tmpCurrentEnum, null).ToString(),
                                        Forref = tmpForref.GetValue(tmpCurrentEnum, null).ToString(),
                                        Design = tmpDesign.GetValue(tmpCurrentEnum, null).ToString(),
                                        Familia = tmpFamilia.GetValue(tmpCurrentEnum, null).ToString(),
                                        Epv1 = decimal.Parse(tmpEpv1.GetValue(tmpCurrentEnum, null).ToString()),
                                        Epv2 = decimal.Parse(tmpEpv2.GetValue(tmpCurrentEnum, null).ToString()),
                                        Epv3 = decimal.Parse(tmpepv3.GetValue(tmpCurrentEnum, null).ToString()),
                                        Epv4 = decimal.Parse(tmpepv4.GetValue(tmpCurrentEnum, null).ToString()),
                                        Epv5 = decimal.Parse(tmpepv5.GetValue(tmpCurrentEnum, null).ToString())
                                    });


                                }
                            }
                        

                        }


                      
                        resultado = _utility.SerializeStocks(tmpSt);
                    }
                    finally
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = true;
                    }
                }

            }
            catch (Exception e)
            {
                if (e.InnerException == null)
                {
                    _logManager.WriteError(1200, "WorkerDevolveStocks: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
                }
                else
                {
                    _logManager.WriteError(1200, "WorkerDevolveStocks: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException);
                }

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
                    DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
                });
            }
            return resultado;
        }


        public DadosTerminal EndSyncStocks(IAsyncResult result)
        {
            return ((Task<DadosTerminal>)result).Result;
        }
        #endregion

        #region DadosChave
        /// <summary>
        /// metodo para obter os dados da api key
        /// </summary>
        /// <param name="valueMacw"></param>
        /// <param name="valueMact"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public IAsyncResult BeginGetClientKey(string valueMacw, string valueMact, AsyncCallback callback, object state)
        {

            _valueMacG = valueMact;
            _valueMacW = valueMacw;

            var task = Task<AcesskeyData>.Factory.StartNew(WorkerGetKeyClient, state);
            return task.ContinueWith(res => callback(task));


        }

        private AcesskeyData WorkerGetKeyClient(object state)
        {
            var resultado = new AcesskeyData();
            try
            {
                if ((!string.IsNullOrEmpty(_valueMacG)) || (!string.IsNullOrEmpty(_valueMacW)))
                {
                    using (var tmpConn = new DbContextIfElse(_utility.DevolveCOnnectionStringIf().ProviderConnectionString))
                    {
                        try
                        {
                            tmpConn.Configuration.AutoDetectChangesEnabled = false;

                            TbTerminais tmptbterminals;
                            if ((!string.IsNullOrEmpty(_valueMacW)) && (!string.IsNullOrEmpty(_valueMacG)))
                            {
                                tmptbterminals = (from t in tmpConn.Terminais
                                                  where t.MacAddressG == _valueMacG && t.MacAddressW == _valueMacW
                                                  select t).SingleOrDefault();
                            }
                            else
                            {
                                tmptbterminals = (string.IsNullOrEmpty(_valueMacG)) &&
                                                 (!string.IsNullOrEmpty(_valueMacW))
                                                     ? (from t in tmpConn.Terminais
                                                        where t.MacAddressW == _valueMacW
                                                        select t).SingleOrDefault()
                                                     : (from t in tmpConn.Terminais
                                                        where t.MacAddressG == _valueMacG
                                                        select t).SingleOrDefault();
                            }


                            if (tmptbterminals != null)
                            {
                                resultado = _utility.SerializeAccessKey(tmptbterminals.AccessKey.ToString());
                            }
                            else
                            {
                                resultado.DataAccessKey = "NO DATA";
                            }
                        }
                        finally
                        {
                            tmpConn.Configuration.AutoDetectChangesEnabled = true;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                if (e.InnerException == null)
                {
                    _logManager.WriteError(1200,
                                           "Erro ao obter a chave de acesso do terminal,ocorreu o seguinte erro:" +
                                           e.Source + " \n" + e.Message);
                }
                else
                {
                    _logManager.WriteError(1200,
                                           "Erro ao obter a chave de acesso do terminal,ocorreu o seguinte erro:" +
                                           e.Source + " \n" + e.InnerException);
                }

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataDetails = "Nao foi possivel obter a chave de acesso do terminal por favor volte a tentar mais tarde",
                    DataMessage = "Ocorreu um erro ao obter a chave para o terminal"
                });
            }
            return resultado;
        }

        public AcesskeyData EndGetClientKey(IAsyncResult result)
        {
            return ((Task<AcesskeyData>)result).Result;
        }
        #endregion

        #region Contas

        /// <summary>
        /// DEvolve as contas correntes
        /// </summary>
        /// <param name="valueVendedor"></param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public IAsyncResult BeginGetContasCorrentes(string valueVendedor, AsyncCallback callback, object state)
        {
            _valueVendContas = valueVendedor;
            var taskCc = Task<DadosTerminal>.Factory.StartNew(WorkerDevolveContas, state);
            return taskCc.ContinueWith(res => callback(taskCc));

        }

        private DadosTerminal WorkerDevolveContas(object state)
        {
            DadosTerminal resultado;
            try
            {
                if (string.IsNullOrEmpty(_valueVendContas))
                {
                    throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                    {
                        DataDetails = "Nao foram fornecidos dados para obter os parametros PHC Contas",
                        DataMessage = "Erro ao obter os parametros PHC Contas"
                    });

                }
                 using (var tmp= new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
                    {

                        try
                        {
                            tmp.Configuration.AutoDetectChangesEnabled = false;



                            var tcc = tmp.Database.SqlQuery<CcFiltradas>("select cc.ccstamp,cc.cmdesc,cc.nrdoc,cc.nome,cc.no, " +
                                                      "cc.estab,cc.edeb,cc.edebf,cc.ecred,cc.ecredf,cc.datalc,"
                                                      + "cc.dataven,cc.evalre,cc.evtmp,cc.evirs,cc.eivav1,cc.eivav2,"
                                                      + "cc.eivav3,cc.eivav4,cc.eivav5,cc.eivav6," +
                                                      "cc.eivav7,cc.eivav8,cc.eivav9,cc.moeda,"
                                                      + "cc.recibado,cc.origem,cc.cm" +
                                                      " from cc(nolock) inner join cl(nolock) on cl.no=cc.no and"+
                                                      " cl.estab=cc.estab "+
                                                      "where abs(-cc.ecred+cc.edeb+cc.ecredf-cc.edebf)>0.1 and cl.vendedor=@paramVend " +
                                                                "and cl.inactivo <> 1", new SqlParameter("@paramVend", _valueVendContas)
                                                      ).ToList();


                            var tmpCc = tcc.Select(item => new Cc
                                                               {
                                                                   Ccstamp = item.ccstamp, Cmdesc = item.cmdesc, Nrdoc = item.nrdoc, Nome = item.nome, No = item.no, Estab = item.estab, Edeb = item.edeb, Edebf = item.edebf, Ecred = item.ecred, Ecredf = item.ecredf, Datalc = item.datalc, Dataven = item.dataven, Evalre = item.evalre, Evtmp = item.evtmp, Evirs = item.evirs, Eivav1 = item.eivav1, Eivav2 = item.eivav2, Eivav3 = item.eivav3, Eivav4 = item.eivav4, Eivav5 = item.eivav5, Eivav6 = item.eivav6, Eivav7 = item.eivav7, Eivav8 = item.eivav8, Eivav9 = item.eivav9, Moeda = item.moeda, Recibado = item.recibado, Origem = item.origem, Cm = item.cm
                                                               }).ToList();

                            resultado = _utility.SerializeClientes(new List<Cl>(),tmpCc );


                        }
                        finally
                        {
                            tmp.Configuration.AutoDetectChangesEnabled = true;
                        }
                    }
            }
            catch (Exception e)
            {

                if (e.InnerException == null)
                {
                    _logManager.WriteError(1200,
                                           "Erro ao obter as contas correntes do terminal,ocorreu o seguinte erro:" +
                                           e.Source + " \n" + e.Message);
                }
                else
                {
                    _logManager.WriteError(1200,
                                           "Erro ao obter as contas correntes do terminal,ocorreu o seguinte erro:" +
                                           e.Source + " \n" + e.InnerException);
                }

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataDetails = "Nao foi possivel obter a chave de acesso do terminal por favor volte a tentar mais tarde",
                    DataMessage = "Ocorreu um erro ao obter a chave para o terminal"
                });
            }
            return resultado;
        }
        public DadosTerminal EndGetContasCorrentes(IAsyncResult result)
        {
            return ((Task<DadosTerminal>)result).Result;
        }


        #region PNS

        /// <summary>
        /// DEvolve as pns
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        //public IAsyncResult BeginGetPns(string valueVendedor, AsyncCallback callback, object state)
        //{
        //    _valueVendContas = valueVendedor;
        //    var taskPns = Task<DadosTerminal>.Factory.StartNew(WorkerDevolvePns, state);
        //    return taskPns.ContinueWith(res => callback(taskPns));
        //}

        //private DadosTerminal WorkerDevolvePns(object state)
        //{
        //    DadosTerminal resultado;
        //    try
        //    {
              
        //            if (string.IsNullOrEmpty(_valueVendContas))
        //            {
        //                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
        //                {
        //                    DataDetails = "Nao foram fornecidos dados para obter os parametros PHC PNS",
        //                    DataMessage = "Erro ao obter os parametros PHC PNS"
        //                });

                    
        //        }

        //        using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
        //        {

        //            try
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = false;
        //                //var tpns = tmp.Database.SqlQuery<PnsFiltradas>("select distinct pn.ref as PNReferencia,cl.no,pn.design " +
        //                //                                              "from pn inner join cl on pn.no=cl.no inner join st on pn.ref=st.ref" +
        //                //                                              " where (cl.vendedor=@vendedor and cl.inactivo<>1 and st.bloqueado<>1) order by cl.no ",
        //                //                                              new SqlParameter("@vendedor", _valueVendContas)).ToList();



        //                var tpns = tmp.Database.SqlQuery<PnsFiltradas>("select distinct pn.ref as PNReferencia,cl.no,pn.design " +
        //                                                             "from pn inner join cl on pn.no=cl.no inner join st on pn.ref=st.ref" +
        //                                                             " where (cl.vendedor=@vendedor and cl.inactivo<>1 and st.bloqueado<>1) order by cl.no ",
        //                                                             new SqlParameter("@vendedor", _valueVendContas))
        //                                                             .OrderByDescending(t=>t.no).Take(25).ToList();


                        

        //                resultado = _utility.SerializePns(tpns);

        //            }
        //            finally
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = true;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        if (e.InnerException == null)
        //        {
        //            _logManager.WriteError(1200,
        //                                   "Erro ao obter as pns do terminal,ocorreu o seguinte erro:" +
        //                                   e.Source + " \n" + e.Message);
        //        }
        //        else
        //        {
        //            _logManager.WriteError(1200,
        //                                   "Erro ao obter pns do terminal,ocorreu o seguinte erro:" +
        //                                   e.Source + " \n" + e.InnerException);
        //        }

        //        throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
        //        {
        //            DataDetails = "Nao foi possivel obter a chave de acesso do terminal por favor volte a tentar mais tarde",
        //            DataMessage = "Ocorreu um erro ao obter a chave para o terminal"
        //        });
        //    }
        //    return resultado;
        //}


        //public DadosTerminal EndGetPns(IAsyncResult result)
        //{
            
        //    return ((Task<DadosTerminal>)result).Result;
        //}
        #endregion
        #endregion

        #region Taxas
        public IAsyncResult BeginGetTaxas(AsyncCallback callback,object state)
        {
            var taskTaxas = Task<DadosTerminal>.Factory.StartNew(WorkerDevolveTaxas, state);
            return taskTaxas.ContinueWith(res => callback(taskTaxas));

        }


        private DadosTerminal WorkerDevolveTaxas(object state)
        {
            DadosTerminal resultado;

            try
            {
                using (var tmp= new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
                {
                    try
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = false;
                        var tmptaxas = (from t in tmp.DadosTaxasIva
                                        select new
                                        {
                                            _Taxasivastamp = t.Taxasivastamp,
                                            _codigo = t.Codigo,
                                            _taxa = t.Taxa
                                        }).AsEnumerable().Select(tmpdatataxa => new Taxasiva
                                        {
                                            Taxasivastamp = tmpdatataxa._Taxasivastamp,
                                            Codigo = tmpdatataxa._codigo,
                                            Taxa = tmpdatataxa._taxa
                                        }).ToList();

                        resultado = tmptaxas.Any() ? _utility.SerializeTaxas(tmptaxas) : new DadosTerminal();
                    }
                    finally
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = true;
                    }
                
                }
            }
            catch (Exception e)
            {

                if (e.InnerException == null)
                {
                    _logManager.WriteError(1200, "WorkerDevolveTaxas: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
                }
                else
                {
                    _logManager.WriteError(1200, "WorkerDevolveTaxas: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException);
                }

                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
                {
                    DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
                    DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
                });
            }
            return resultado;
        }

        public DadosTerminal EndGetTaxas(IAsyncResult result)
        {
            return ((Task<DadosTerminal>) result).Result;
        }


        #endregion

        #region Metodosnaoimplementadosainda


        public IAsyncResult BeginRegisterKey(string valueRk, AsyncCallback callback, object state)
        {
            throw new NotImplementedException();
        }

        public string EndRegisterKey(IAsyncResult result)
        {
            throw new NotImplementedException();
        }
        #endregion

        



    }
        #endregion

    #region Todelete
    #region DadosTerminal

    //public IAsyncResult BeginSyncDadosTerminal(string valueClientes, string valueStock,string valueCC, AsyncCallback callback, object state)


    //public IAsyncResult BeginSyncDadosTerminal(string valueClientes, string valueStock, AsyncCallback callback, object state)
    //{

    //    _filterClientes = valueClientes;
    //    _filterStocks = valueStock;


    //    var t = Task<DadosTerminal>.Factory.StartNew(WorkerDevolveDadosTerminal, state);
    //    return t.ContinueWith(res => callback(t));


    //}

    //private DadosTerminal WorkerDevolveDadosTerminal(object state)
    //{

    //    var resultado = new DadosTerminal();
    //    if ((!string.IsNullOrEmpty(_filterStocks)) && (!string.IsNullOrEmpty(_filterClientes)))
    //    {
    //        if ((_filterClientes != "NO FILTER") || (_filterStocks != "NO FILTER"))
    //        {
    //            try
    //            {
    //                var tmpsts = new List<St>();
    //                var tmpTaskSts = Task<List<St>>.Factory.StartNew(DevolveSts);
    //                tmpTaskSts.Wait();


    //                if (tmpTaskSts.Result.Any())
    //                {
    //                    tmpsts = tmpTaskSts.Result;
    //                }
    //                var tmpTaskCls = Task<List<Cl>>.Factory.StartNew(DevolveCls);
    //                tmpTaskCls.Wait();
    //                var tmpCls = new List<Cl>();
    //                //var tmpsts = tmpTaskSts.Result;
    //                if(tmpTaskCls.Result.Any())
    //                {
    //                    tmpCls = tmpTaskCls.Result;
    //                }
    //                var tmpTaskContas = Task<List<Cc>>.Factory.StartNew(()=>DevolveCCs(tmpCls));
    //                tmpTaskContas.Wait();
    //                var tmpSts = new List<Cc>();
    //                if(tmpTaskContas.Result.Any())
    //                {
    //                    tmpSts = tmpTaskContas.Result;
    //                }


    //                var tmpTaxas = DevolveTaxas();
    //                var tmpPns = DevolvePns();
    //                resultado = _utility.SerializeDadosTerminal(tmpsts, tmpCls, tmpSts, tmpTaxas, tmpPns);




    //            }
    //            catch (Exception e)
    //            {
    //                if (e.InnerException == null)
    //                {
    //                    _logManager.WriteError(1200, "WorkerDevolveDadosFiltros: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
    //                }
    //                else
    //                {
    //                    _logManager.WriteError(1200, "WorkerDevolveDadosFiltros: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException.Message);
    //                }

    //                throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    //                {
    //                    DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
    //                    DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
    //                });
    //            }
    //        }
    //    }
    //    return resultado;
    //}

    //private List<Pn> DevolvePns()
    //{
    //   return new List<Pn>();
    //}
    //#region DataPNS
    //private List<Cc> DevolveCCs(IEnumerable<Cl> value)
    //{
    //    var resultado = new List<Cc>();

    //    try
    //    {
    //        using (var tmp= new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    //        {
    //            try
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = false;


    //                var tmpContas = (from t in tmp.DadosContasCorrentes
    //                                 join q in value
    //                                     on new { CCNo = t.No, CCEstab = t.Estab, CCVend= t.Vendedor}
    //                                     equals new { CCNo = q.No, CCEstab = q.Estab, CCVend = q.Vendedor }
    //                                 where Math.Abs(-t.Ecred + t.Edeb + t.Ecredf - t.Edebf) > (decimal)0.1
    //                                 && q.Inactivo == false 
    //                                 select t).ToList();



    //                if (tmpContas.Any())
    //                {
    //                    resultado = tmpContas;
    //                }
    //            }
    //            finally
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = true;
    //            }
    //        }
    //    }
    //    catch (Exception e)
    //    {

    //        if (e.InnerException == null)
    //        {
    //            _logManager.WriteError(1200, "DevolveCC: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
    //        }
    //        else
    //        {
    //            _logManager.WriteError(1200, "DevolveCC: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException.Message);
    //        }

    //        throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    //        {
    //            DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
    //            DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
    //        });
    //    }
    //    return resultado;
    //}
    //#endregion
    //private List<Taxasiva> DevolveTaxas()
    //{
    //    var resultado =new List<Taxasiva>() ;
    //    try
    //    {
    //        using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    //        {
    //            try
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = false;
    //                var tmptaxas = (from t in tmp.DadosTaxasIva
    //                                select new
    //                                {
    //                                    _Taxasivastamp = t.Taxasivastamp,
    //                                    _codigo = t.Codigo,
    //                                    _taxa = t.Taxa
    //                                }).AsEnumerable().Select(tmpdatataxa => new Taxasiva
    //                                {
    //                                    Taxasivastamp = tmpdatataxa._Taxasivastamp,
    //                                    Codigo = tmpdatataxa._codigo,
    //                                    Taxa = tmpdatataxa._taxa
    //                                }).ToList();


    //                if (tmptaxas.Any())
    //                {
    //                    resultado = tmptaxas;
    //                }

    //            }
    //            finally
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = true;
    //            }

    //        }


    //    }
    //    catch (Exception e)
    //    {

    //        if (e.InnerException == null)
    //        {
    //            _logManager.WriteError(1200, "DevolveTaxas: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
    //        }
    //        else
    //        {
    //            _logManager.WriteError(1200, "DevolveTaxas: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException.Message);
    //        }

    //        throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    //        {
    //            DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
    //            DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
    //        });
    //    }
    //    return resultado;
    //}

    //#region DataSts
    //private List<St> DevolveSts()
    //{
    //    var resultado = new List<St>();
    //    try
    //    {
    //        using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    //        {
    //            try
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = false;
    //                var tmpfilterst = (from t in tmp.DadosFiltrosStocks
    //                                   where t.Fltststamp == _filterStocks
    //                                   select t.Xbase).SingleOrDefault();

    //                if (string.IsNullOrEmpty(tmpfilterst))
    //                {
    //                    throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    //                    {
    //                        DataDetails = "Nao foram fornecidos dados para obter os parametros PHC",
    //                        DataMessage = "Erro ao obter os parametros PHC"
    //                    });
    //                }
    //                var tmpArrSt = new string[0];
    //                if (!string.IsNullOrEmpty(tmpfilterst))
    //                {

    //                    tmpArrSt = tmpfilterst.Split(',');
    //                }
    //                if (tmpArrSt.Any())
    //                {
    //                    var tmpQuerySt = tmpArrSt[0];

    //                    var stParams = _utility.ConvertDataQuery(tmpArrSt);
    //                    var filtereredstock = tmp.DadosStocks.
    //                        Where(tmpQuerySt, stParams).Select("New(ststamp as Stamp,StReferencia " +
    //                                                           "as StReferencia,tabiva as Tabiva,bloqueado as Bloqueado, " +
    //                                                           "codigo as Codigo,forref as Forref, design as Design,familia as " +
    //                                                           "Familia,epv1 as Epv1,epv2 as Epv2,epv3 as Epv3, epv4 as Epv4, epv5 as Epv5)");




    //                    if (filtereredstock.Any())
    //                    {


    //                        Array.Clear(tmpArrSt, 0, tmpArrSt.Length);
    //                        var tmpEnum = filtereredstock.GetEnumerator();
    //                        while (tmpEnum.MoveNext())
    //                        {
    //                            var tmpCurrentEnum = tmpEnum.Current;
    //                            var sStamp = tmpCurrentEnum.GetType().GetProperty("Stamp");
    //                            var tmpStReferencia = tmpCurrentEnum.GetType().GetProperty("StReferencia");
    //                            var tmpTabiva = tmpCurrentEnum.GetType().GetProperty("Tabiva");
    //                            var tmpBloqueado = tmpCurrentEnum.GetType().GetProperty("Bloqueado");
    //                            var tmpCodigo = tmpCurrentEnum.GetType().GetProperty("Codigo");
    //                            var tmpForref = tmpCurrentEnum.GetType().GetProperty("Forref");
    //                            var tmpDesign = tmpCurrentEnum.GetType().GetProperty("Design");
    //                            var tmpFamilia = tmpCurrentEnum.GetType().GetProperty("Familia");
    //                            var tmpEpv1 = tmpCurrentEnum.GetType().GetProperty("Epv1");
    //                            var tmpEpv2 = tmpCurrentEnum.GetType().GetProperty("Epv2");
    //                            var tmpepv3 = tmpCurrentEnum.GetType().GetProperty("Epv3");
    //                            var tmpepv4 = tmpCurrentEnum.GetType().GetProperty("Epv4");
    //                            var tmpepv5 = tmpCurrentEnum.GetType().GetProperty("Epv5");
    //                            resultado.Add(new St
    //                            {
    //                                Ststamp = sStamp.GetValue(tmpCurrentEnum, null).ToString(),
    //                                StReferencia = tmpStReferencia.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Tabiva = decimal.Parse(tmpTabiva.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Bloqueado = bool.Parse(tmpBloqueado.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Codigo = tmpCodigo.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Forref = tmpForref.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Design = tmpDesign.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Familia = tmpFamilia.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Epv1 = decimal.Parse(tmpEpv1.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Epv2 = decimal.Parse(tmpEpv2.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Epv3 = decimal.Parse(tmpepv3.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Epv4 = decimal.Parse(tmpepv4.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Epv5 = decimal.Parse(tmpepv5.GetValue(tmpCurrentEnum, null).ToString())
    //                            });


    //                        }
    //                    }
    //                }

    //            }
    //            finally
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = true;
    //            }

    //        }
    //    }
    //    catch (Exception e)
    //    {

    //        if (e.InnerException == null)
    //        {
    //            _logManager.WriteError(1200, "DevolveSts: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
    //        }
    //        else
    //        {
    //            _logManager.WriteError(1200, "DevolveSts: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException.Message);
    //        }

    //        throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    //        {
    //            DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
    //            DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
    //        });
    //    }

    //    return resultado;
    //}

    //#endregion

    //#region DataCls
    //private List<Cl> DevolveCls()
    //{
    //    var resultado = new List<Cl>();

    //    try
    //    {
    //        using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    //        {
    //            try
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = false;

    //                var tfiltercl = (from t in tmp.DadosFiltrosClientes
    //                                 where t.Fltclstamp == _filterClientes
    //                                 select t.Xbase).SingleOrDefault();

    //                if ((string.IsNullOrEmpty(tfiltercl)))
    //                {
    //                    throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    //                    {
    //                        DataDetails = "Nao foram fornecidos dados para obter os parametros PHC CL",
    //                        DataMessage = "Erro ao obter os parametros PHC CL"
    //                    });
    //                }

    //                var tmpArrCl = new string[0];
    //                if (!string.IsNullOrEmpty(tfiltercl))
    //                {

    //                    tmpArrCl = tfiltercl.Split(',');
    //                }
    //                if (tmpArrCl.Any())
    //                {
    //                    var tmpQueryCl = tmpArrCl[0];
    //                    var clParams = _utility.ConvertDataQuery(tmpArrCl);
    //                    var filteredCl = tmp.DadosClientes
    //                        .Where(tmpQueryCl, clParams)
    //                        .Select("New(clstamp as ClStamp,preco as Preco," +
    //                                 "tabiva as TabIva,desconto as Desconto, " +
    //                                 "nocredit as Nocredit,no as No, estab as Estab,nome as Nome,nome2 as Nome2," +
    //                                 " morada as Morada,local as Local, codpost as CodPost, obs as Obs,tlmvl as Tlmvl, " +
    //                                 "telefone as Telefone, email as Email," +
    //                                 " esaldo as Esaldo,statuspda as Statuspda, vendedor as Vendedor,vendnm as Vendnm, " +
    //                                 "ncont as Ncont, tipo as Tipo, contacto as Contacto, inactivo as Inactivo)");



    //                    if (filteredCl.Any())
    //                    {

    //                        Array.Clear(tmpArrCl, 0, tmpArrCl.Length);
    //                        var tmpEnum = filteredCl.GetEnumerator();
    //                        while (tmpEnum.MoveNext())
    //                        {
    //                            var tmpCurrentEnum = tmpEnum.Current;
    //                            var tmpStamp = tmpCurrentEnum.GetType().GetProperty("ClStamp");
    //                            var tmpPreco = tmpCurrentEnum.GetType().GetProperty("Preco");
    //                            var tmpTabiva = tmpCurrentEnum.GetType().GetProperty("TabIva");
    //                            var tmpDesconto = tmpCurrentEnum.GetType().GetProperty("Desconto");
    //                            var tmpNocredit = tmpCurrentEnum.GetType().GetProperty("Nocredit");
    //                            var tmpNo = tmpCurrentEnum.GetType().GetProperty("No");
    //                            var tmpEstab = tmpCurrentEnum.GetType().GetProperty("Estab");
    //                            var tmpNome = tmpCurrentEnum.GetType().GetProperty("Nome");
    //                            var tmpNome2 = tmpCurrentEnum.GetType().GetProperty("Nome2");
    //                            var tmpMorada = tmpCurrentEnum.GetType().GetProperty("Morada");
    //                            var tmpLocal = tmpCurrentEnum.GetType().GetProperty("Local");
    //                            var tmpCodPost = tmpCurrentEnum.GetType().GetProperty("CodPost");
    //                            var tmpObs = tmpCurrentEnum.GetType().GetProperty("Obs");
    //                            var tmpTlmvl = tmpCurrentEnum.GetType().GetProperty("Tlmvl");
    //                            var tmpTelefone = tmpCurrentEnum.GetType().GetProperty("Telefone");
    //                            var tmpEmail = tmpCurrentEnum.GetType().GetProperty("Email");
    //                            var tmpEsaldo = tmpCurrentEnum.GetType().GetProperty("Esaldo");
    //                            var tmpStatuspda = tmpCurrentEnum.GetType().GetProperty("Statuspda");
    //                            var tmpVendedor = tmpCurrentEnum.GetType().GetProperty("Vendedor");
    //                            var tmpVendnm = tmpCurrentEnum.GetType().GetProperty("Vendnm");
    //                            var tmpNcont = tmpCurrentEnum.GetType().GetProperty("Ncont");
    //                            var tmpTipo = tmpCurrentEnum.GetType().GetProperty("Tipo");
    //                            var tmpContacto = tmpCurrentEnum.GetType().GetProperty("Contacto");
    //                            var tmpInactivo = tmpCurrentEnum.GetType().GetProperty("Inactivo");
    //                            resultado.Add(new Cl
    //                            {
    //                                Clstamp = tmpStamp.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Preco = decimal.Parse(tmpPreco.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Tabiva = decimal.Parse(tmpTabiva.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Desconto = decimal.Parse(tmpDesconto.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Nocredit = bool.Parse(tmpNocredit.GetValue(tmpCurrentEnum, null).ToString()),
    //                                No = decimal.Parse(tmpNo.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Estab = decimal.Parse(tmpEstab.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Nome = tmpNome.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Nome2 = tmpNome2.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Morada = tmpMorada.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Local = tmpLocal.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Codpost = tmpCodPost.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Obs = tmpObs.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Tlmvl = tmpTlmvl.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Telefone = tmpTelefone.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Email = tmpEmail.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Esaldo = decimal.Parse(tmpEsaldo.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Statuspda = tmpStatuspda.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Vendedor = decimal.Parse(tmpVendedor.GetValue(tmpCurrentEnum, null).ToString()),
    //                                Vendnm = tmpVendnm.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Ncont = tmpNcont.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Tipo = tmpTipo.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Contacto = tmpContacto.GetValue(tmpCurrentEnum, null).ToString(),
    //                                Inactivo = bool.Parse(tmpInactivo.GetValue(tmpCurrentEnum, null).ToString())
    //                            });
    //                        }

    //                    }
    //                }

    //            }
    //            finally
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = true;
    //            }
    //        }
    //    }
    //    catch (Exception e)
    //    {

    //        if (e.InnerException == null)
    //        {
    //            _logManager.WriteError(1200, "DevolveCls: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
    //        }
    //        else
    //        {
    //            _logManager.WriteError(1200, "DevolveCls: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException.Message);
    //        }

    //        throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    //        {
    //            DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
    //            DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
    //        });
    //    }
    //    return resultado;
    //} 
    //#endregion

    //#region DadosComFiltros
    ///// <summary>
    ///// metodo para devolver os dados com ambos os filtros
    ///// </summary>
    ///// <returns></returns>
    ////private DadosTerminal WorkerDevolveDadosFiltros()
    ////{

    ////    DadosTerminal resultado;
    ////    try
    ////    {

    ////        using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    ////        {

    ////            try
    ////            {
    ////                tmp.Configuration.AutoDetectChangesEnabled = false;
    ////                var tmpContas = new List<Cc>();
    ////               var tmpPns= new List<Pn>();
    ////                 var tmpSt=new List<St>();

    ////                var tmpCl= new List<Cl>();
    ////                var tmpStObs= new List<Stobs>();


    ////                var tmpfilterst = (from t in tmp.DadosFiltrosStocks
    ////                                   where t.Fltststamp == _filterStocks
    ////                                   select t.Xbase).SingleOrDefault();


    ////                var tfiltercl = (from t in tmp.DadosFiltrosClientes
    ////                                 where t.Ftitulo == _filterClientes
    ////                                 select t.Xbase).SingleOrDefault();



    ////                //if ((string.IsNullOrEmpty(tfiltercl)) && (string.IsNullOrEmpty(tmpfilterst)))
    ////                //{
    ////                //    throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    ////                //                                                        {
    ////                //                                                            DataDetails = "Nao foram fornecidos dados para obter os parametros PHC",
    ////                //                                                            DataMessage = "Erro ao obter os parametros PHC"
    ////                //                                                        });
    ////                //}


    ////                var tmpArrSt = tmpfilterst.Split(',');
    ////                //var tmpArrCl = tfiltercl.Split(',');

    ////                var tmpQuerySt="";
    ////                var tmpQueryCl = "";
    ////                var stParams = new object[0];
    ////                var clParams = new object[0];
    ////                if (tmpArrSt!=null)
    ////                {
    ////                    tmpQuerySt = tmpArrSt[0];
    ////                    stParams=_utility.ConvertDataQuery(tmpArrSt);
    ////                    var filtereredstock = tmp.DadosStocks.
    ////                        Where(tmpQuerySt, stParams).Select(
    ////                            ("New(ststamp as Stamp,StReferencia as StReferencia,tabiva as Tabiva,bloqueado as Bloqueado, codigo as Codigo,forref as Forref, design as Design,familia as Familia,epv1 as Epv1,epv2 as Epv2,epv3 as Epv3, epv4 as Epv4, epv5 as Epv5)")).AsQueryable();

    ////                    var m = filtereredstock.Count();
    ////                    if (filtereredstock.Any())
    ////                    {
    ////                        tmpSt = new List<St>(filtereredstock as IEnumerable<St>);
    ////                    }


    ////                }

    ////                //if(tmpArrCl!=null)
    ////                //{
    ////                //    tmpQueryCl = tmpArrCl[0];
    ////                //    clParams = _utility.ConvertDataQuery(tmpArrCl);
    ////                //    var filteredCl = tmp.DadosClientes
    ////                //        .Where(tmpQueryCl, clParams)
    ////                //        .Select(("New(clstamp as ClStamp,preco as Preco," +
    ////                //                 "tabiva as TabIva,desconto as Desconto, nocredit as Nocredit,no as No, estab as Estab,nome as Nome,nome2 as Nome2," +
    ////                //                 " morada as Morada,local as Local, codpost as CodPost, obs as Obs,tlmvl as Tlmvl, telefone as Telefone, email as Email," +
    ////                //                 " esaldo as Esaldo,statuspda as Statuspda, vendedor as Vendedor,vendnm as Vendnm, " +
    ////                //                 "ncont as Ncont, tipo as Tipo, contacto as Contacto"));




    ////                //}


    ////                ////
    ////                ////taxas iva
    ////                var tmptaxas = (from t in tmp.DadosTaxasIva
    ////                                select new
    ////                                           {
    ////                                               _Taxasivastamp = t.Taxasivastamp,
    ////                                               _codigo = t.Codigo,
    ////                                               _taxa = t.Taxa
    ////                                           }).AsEnumerable().Select(tmpdatataxa => new Taxasiva
    ////                                                                                       {
    ////                                                                                           Taxasivastamp = tmpdatataxa._Taxasivastamp,
    ////                                                                                           Codigo = tmpdatataxa._codigo,
    ////                                                                                           Taxa = tmpdatataxa._taxa
    ////                                                                                       }).ToList();





    ////                resultado = _utility.SerializeDadosTerminal(tmpSt, tmpCl, tmpContas, tmptaxas, tmpPns, tmpStObs);


    ////            }
    ////            finally
    ////            {
    ////                tmp.Configuration.AutoDetectChangesEnabled = true;

    ////            }

    ////        }
    ////    }
    ////    catch (Exception e)
    ////    {
    ////        if(e.InnerException==null)
    ////        {
    ////            _logManager.WriteError(1200, "WorkerDevolveDadosFiltros: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.Message);
    ////        }
    ////        else
    ////        {
    ////            _logManager.WriteError(1200, "WorkerDevolveDadosFiltros: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException.Message );
    ////        }

    ////        throw new FaultException<ConnectorServiceFault>(new ConnectorServiceFault
    ////        {
    ////            DataMessage = "Ocorreu um erro ao obter os dados para devolver para o terminal",
    ////            DataDetails = "Nao foi possivel completar o pedido a base de dados. Tente mais tarde"
    ////        });
    ////    }
    ////    return resultado;
    ////}
    //#endregion


    //public DadosTerminal EndSyncDadosTerminal(IAsyncResult result)
    //{
    //    return ((Task<DadosTerminal>)result).Result;
    //}
    #endregion







    //private string WorkerDevolveFiltroClientes()
    //{
    //    string resultado;
    //    try
    //    {
    //        using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    //        {
    //            try
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = false;
    //                var tmptaxas = (tmp.DadosTaxasIva.Select(tmptx => new
    //                {

    //                    tmptx.Taxasivastamp,
    //                    tmptx.Codigo,
    //                    tmptx.Taxa

    //                })).ToList();

    //                var tfilter = (from t in tmp.DadosFiltrosClientes
    //                               where t.Ftitulo == _filterClientes
    //                               select t.Xbase).Single();


    //                var tmpClientes = tmp.DadosClientes.Where(tfilter).ToList();
    //                var tmpSt = (tmp.DadosStocks.Select(tempst => new { })).ToList();

    //            }
    //            finally
    //            {
    //                tmp.Configuration.AutoDetectChangesEnabled = true;
    //            }
    //        }
    //    }
    //    catch (Exception)
    //    {
    //        _logManager.WriteError(1200, "WorkerDevolveDadosFiltros: Ocorreu o seguinte erro ao devolver os dados para o terminal:" + e.Source + " \n" + e.InnerException.Message + "\n" + e.Message);
    //        throw;
    //    }
    //    return resultado;
    //}




    // private string WorkerDevolveFiltroStocks()
    // {
    // using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    // {
    // var tfilter = (from t in tmp.DadosFiltrosStocks
    // where t.Ftitulo == _filterStocks
    // select t.Xbase).Single();

    // var filtereredstock = tmp.DadosStocks.Where(tfilter).ToList();

    // var x = (from t in tmp.DadosClientes
    // where t.Inactivo == false
    // select t).ToList();
    //var cc = (from t in tmp.ContasCorrentes

    // select t).ToList();


    // var contas =
    // (from t in tmp.DadosContasCorrentes
    // join o in tmp.DadosClientes on
    // t.Nome equals o.Nome
    // select t).ToList();
    // var contas = (from item in x from itemconta in cc where item.TbClNome == itemconta.TbCCnome select itemconta).ToList();


    // var txiva = (from t in tmp.DadosTaxasIva
    // select t).ToList();

    // return _utility.SerializeDadosTerminal(filtereredstock, x, contas, txiva);
    // }

    // }


    //private string WorkerDevolveFiltroClientes()
    //{
    //    using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    //    {
    //        var tfilter = (from t in tmp.DadosFiltrosClientes
    //                       where t.Ftitulo == _filterClientes
    //                       select t.Xbase).Single();

    //        var filterclient = tmp.DadosClientes.Where(tfilter).ToList();

    //        var c = (from t in tmp.DadosStocks
    //                 select t).ToList();
    //        //var cc = (from t in tmp.ContasCorrentes
    //        //          select t).ToList();
    //        //var contas =
    //        //    (from t in tmp.DadosContasCorrentes
    //        //     join o in tmp.DadosClientes on
    //        //     t.nome equals o.nome
    //        //     select t).ToList();

    //        var txiva = (from t in tmp.DadosTaxasIva
    //                     select t).ToList();

    //        var contas =
    //            (from t in tmp.DadosContasCorrentes
    //             join o in filterclient on
    //             t.Nome equals o.Nome
    //             select t).ToList();
    //        return _utility.SerializeDadosTerminal(c, filterclient, contas, txiva);
    //    }
    // }
    //private string WorkerDevolveDadosDefault()
    //{
    //    using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
    //    {

    //        var c = (from t in tmp.DadosStocks
    //                 where t.Inactivo == false && t.Bloqueado == false
    //                 select t).ToList();


    //        //var tmps = tmp.DadosStocks.Where(z => z.Inactivo == false && z.Bloqueado == false)
    //        //    .Select(z => new
    //        //                     {
    //        //                         z.Ststamp,
    //        //                         z.Tabiva,
    //        //                         z.Bloqueado,
    //        //                         z.Codigo,
    //        //                         z.Forref,


    //        //                     }).


    //        var x = (from t in tmp.DadosClientes
    //                 where t.Inactivo == false
    //                 select t).ToList();


    //        //var cc = (from t in tmp.ContasCorrentes
    //        //          select t).ToList();

    //        var contas =
    //               (from t in tmp.DadosContasCorrentes
    //                join o in tmp.DadosClientes on
    //                t.Nome equals o.Nome
    //                select t).ToList();

    //        var txiva = (from t in tmp.DadosTaxasIva
    //                     select t).ToList();
    //        return _utility.SerializeDadosTerminal(c, x, contas, txiva);
    //    }
    //}
    #endregion

}
