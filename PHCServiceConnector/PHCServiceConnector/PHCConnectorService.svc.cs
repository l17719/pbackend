using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Threading.Tasks;
using AppFabricCachingCore;
using ConnectorService.Model.IFModel.VODadosTerminal;
using ConnectorService.Model.PHCModel;
using ConnectorService.Model.PHCModel.VODadosPHC;
using PHCServiceConnector.Model.DbModel.IFModel;
using PHCServiceConnector.Model.DbModel.PHCMODEL;
using PHCServiceConnector.Model.FaultVo;
using PHCServiceConnector.Utils;
using System.Linq.Dynamic;
namespace PHCServiceConnector
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PHCConnectorService" in code, svc and config file together.

    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class PHCConnectorService : IPHCConnectorService
    {
        #region classvars
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

        #region GetDefinicoes

        /// <summary>
        /// metodos para devolver as definicoes do terminal
        /// </summary>
        /// <param name="valueMact"> </param>
        /// <param name="callback"></param>
        /// <param name="state"></param>
        /// <param name="valueMacw"> </param>
        /// <returns></returns>
        public IAsyncResult BeginGetDefinicoes(string valueMacw, string valueMact, AsyncCallback callback, object state)
        {

            _valueMacG = valueMact;
            _valueMacW = valueMacw;

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


                            Terminais tmptbterminals;
                            if ((!string.IsNullOrEmpty(_valueMacW)) && (!string.IsNullOrEmpty(_valueMacG)))
                            {
                                tmptbterminals = (from t in tmpConn.DadosTerminais
                                                  where t.MacAddress3G == _valueMacG && t.MacAddressWireless == _valueMacW
                                                  select t).SingleOrDefault();
                            }
                            else
                            {
                                tmptbterminals = (string.IsNullOrEmpty(_valueMacG)) &&
                                                 (!string.IsNullOrEmpty(_valueMacW))
                                                     ? (from t in tmpConn.DadosTerminais
                                                        where t.MacAddressWireless == _valueMacW
                                                        select t).SingleOrDefault()
                                                     : (from t in tmpConn.DadosTerminais
                                                        where t.MacAddress3G == _valueMacG
                                                        select t).SingleOrDefault();
                            }

                            OpcoesTerminais tmpOp;
                            if (tmptbterminals != null)
                            {
                                tmpOp = (from t in tmpConn.DadosOpcoesTerminais
                                         where t.ID == tmptbterminals.FkIdot
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
                var tmpClientesCached = (List<Cl>)Cache.Get("Clientes" + _filterClientes);
                if (tmpClientesCached != null)
                {
                    return _utility.SerializeClientes(tmpClientesCached, new List<Cc>());
                }

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



                        Cache.Add("Clientes" + _filterClientes, tmpCl, new TimeSpan(0, 8, 0, 0));
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

                var tmpcacheStocks = (List<St>)Cache.Get("Stocks" + _filterStocks);
                if (tmpcacheStocks != null)
                {
                    return _utility.SerializeStocks(tmpcacheStocks);
                }

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
                                DataDetails =
                                    "Nao foram fornecidos dados para obter os parametros PHC",
                                DataMessage =
                                    "Erro ao obter os parametros PHC"
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
                                        StReferencia =
                                            tmpStReferencia.GetValue(tmpCurrentEnum, null).ToString(),
                                        Tabiva =
                                            decimal.Parse(
                                                tmpTabiva.GetValue(tmpCurrentEnum, null).ToString()),
                                        Bloqueado =
                                            bool.Parse(
                                                tmpBloqueado.GetValue(tmpCurrentEnum, null).ToString()),
                                        Codigo = tmpCodigo.GetValue(tmpCurrentEnum, null).ToString(),
                                        Forref = tmpForref.GetValue(tmpCurrentEnum, null).ToString(),
                                        Design = tmpDesign.GetValue(tmpCurrentEnum, null).ToString(),
                                        Familia = tmpFamilia.GetValue(tmpCurrentEnum, null).ToString(),
                                        Epv1 =
                                            decimal.Parse(
                                                tmpEpv1.GetValue(tmpCurrentEnum, null).ToString()),
                                        Epv2 =
                                            decimal.Parse(
                                                tmpEpv2.GetValue(tmpCurrentEnum, null).ToString()),
                                        Epv3 =
                                            decimal.Parse(
                                                tmpepv3.GetValue(tmpCurrentEnum, null).ToString()),
                                        Epv4 =
                                            decimal.Parse(
                                                tmpepv4.GetValue(tmpCurrentEnum, null).ToString()),
                                        Epv5 =
                                            decimal.Parse(
                                                tmpepv5.GetValue(tmpCurrentEnum, null).ToString())
                                    });
                                }
                            }
                        }

                        Cache.Add("Stocks" + _filterStocks, tmpSt, new TimeSpan(0, 4, 0, 0));
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

                            Terminais tmptbterminals;
                            if ((!string.IsNullOrEmpty(_valueMacW)) && (!string.IsNullOrEmpty(_valueMacG)))
                            {
                                tmptbterminals = (from t in tmpConn.DadosTerminais
                                                  where t.MacAddress3G == _valueMacG && t.MacAddressWireless == _valueMacW
                                                  select t).SingleOrDefault();
                            }
                            else
                            {
                                tmptbterminals = (string.IsNullOrEmpty(_valueMacG)) &&
                                                 (!string.IsNullOrEmpty(_valueMacW))
                                                     ? (from t in tmpConn.DadosTerminais
                                                        where t.MacAddressWireless == _valueMacW
                                                        select t).SingleOrDefault()
                                                     : (from t in tmpConn.DadosTerminais
                                                        where t.MacAddress3G == _valueMacG
                                                        select t).SingleOrDefault();
                            }


                            if (tmptbterminals != null)
                            {
                                resultado = _utility.SerializeAccessKey(tmptbterminals.TerminalAccessKey.ToString());
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


                var tmpCachedContas = (List<Cc>)Cache.Get("Contas" + _valueVendContas);
                if (tmpCachedContas != null)
                {
                    return _utility.SerializeClientes(new List<Cl>(), tmpCachedContas);
                }
                using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
                {
                    try
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = false;


                        var tcc =
                            tmp.Database.SqlQuery<CcFiltradas>(
                                "select cc.ccstamp,cc.cmdesc,cc.nrdoc,cc.nome,cc.no, " +
                                "cc.estab,cc.edeb,cc.edebf,cc.ecred,cc.ecredf,cc.datalc,"
                                + "cc.dataven,cc.evalre,cc.evtmp,cc.evirs,cc.eivav1,cc.eivav2,"
                                + "cc.eivav3,cc.eivav4,cc.eivav5,cc.eivav6," +
                                "cc.eivav7,cc.eivav8,cc.eivav9,cc.moeda,"
                                + "cc.recibado,cc.origem,cc.cm" +
                                " from cc(nolock) inner join cl(nolock) on cl.no=cc.no and" +
                                " cl.estab=cc.estab " +
                                "where abs(-cc.ecred+cc.edeb+cc.ecredf-cc.edebf)>0.1 and cl.vendedor=@paramVend " +
                                "and cl.inactivo <> 1", new SqlParameter("@paramVend", _valueVendContas)
                                ).ToList();


                        var tmpCc = tcc.Select(item => new Cc
                                                           {
                                                               Ccstamp = item.ccstamp,
                                                               Cmdesc = item.cmdesc,
                                                               Nrdoc = item.nrdoc,
                                                               Nome = item.nome,
                                                               No = item.no,
                                                               Estab = item.estab,
                                                               Edeb = item.edeb,
                                                               Edebf = item.edebf,
                                                               Ecred = item.ecred,
                                                               Ecredf = item.ecredf,
                                                               Datalc = item.datalc,
                                                               Dataven = item.dataven,
                                                               Evalre = item.evalre,
                                                               Evtmp = item.evtmp,
                                                               Evirs = item.evirs,
                                                               Eivav1 = item.eivav1,
                                                               Eivav2 = item.eivav2,
                                                               Eivav3 = item.eivav3,
                                                               Eivav4 = item.eivav4,
                                                               Eivav5 = item.eivav5,
                                                               Eivav6 = item.eivav6,
                                                               Eivav7 = item.eivav7,
                                                               Eivav8 = item.eivav8,
                                                               Eivav9 = item.eivav9,
                                                               Moeda = item.moeda,
                                                               Recibado = item.recibado,
                                                               Origem = item.origem,
                                                               Cm = item.cm
                                                           }).ToList();

                        resultado = _utility.SerializeClientes(new List<Cl>(), tmpCc);
                        Cache.Add("Contas" + _valueVendContas, tmpCc, new TimeSpan(0, 6, 0, 0));
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

        #endregion
        #region Taxas
        public IAsyncResult BeginGetTaxas(AsyncCallback callback, object state)
        {
            var taskTaxas = Task<DadosTerminal>.Factory.StartNew(WorkerDevolveTaxas, state);
            return taskTaxas.ContinueWith(res => callback(taskTaxas));

        }


        private DadosTerminal WorkerDevolveTaxas(object state)
        {
            DadosTerminal resultado;

            var tmpTaxas = (List<Taxasiva>)Cache.Get("Taxas");
            if (tmpTaxas != null)
            {
                return _utility.SerializeTaxas(tmpTaxas);
            }
            try
            {
                using (var tmp = new PhcDbContext(_utility.DevolveConnectionStringPhc().ProviderConnectionString))
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
                        if (tmptaxas.Any())
                        {
                            Cache.Add("TaxasIva",tmptaxas, new TimeSpan(0,8,0,0));
                        }
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
            return ((Task<DadosTerminal>)result).Result;
        }


        #endregion

        #endregion
    }
}
