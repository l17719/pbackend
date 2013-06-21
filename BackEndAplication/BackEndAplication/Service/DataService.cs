using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using BackEndAplication.Events;
using BackEndAplication.Models;
using BackEndAplication.Models.PHCDBModel;
using BackEndAplication.Models.StoredProc;
using BackEndAplication.Models.TerminalDBModel;
using BackEndAplication.Utilities;
using Caliburn.Micro;

namespace BackEndAplication.Service
{
    public class DataService : IDataService
    {
        private static DataService _instance;
        private readonly Utility _utilities = Utility.GetInstance();


        #region ListasDados

        //private static BindableCollection<Cl> _dadosUtilizadores;
        private static BindableCollection<string> _filtrosClientes;
        private static BindableCollection<string> _filtrosStocks;
        private static BindableCollection<Fltcl> _dadosFiltrosClientes;
        private static BindableCollection<Fltst> _dadosFiltrosStocks; 
       // private static BindableCollection<Bo> _listaDossiersInternos;
        private static BindableCollection<Ts> _listaNumerosDescontos;
        private static BindableCollection<int> _listaNumerosDossiers;
        private static BindableCollection<int> _numerosVendedores;

        private static BindableCollection<Us> _listaIniciais; 
        #endregion

        #region ctor

        public static DataService GetInstance()
        {
            return _instance ?? (_instance = new DataService());
        }

        #endregion

        #region DBData

        public BindableCollection<string> GetDataBasesFromInstance(string valueInstance)
        {
            var resultado = new BindableCollection<string>();
            try
            {
                //var t = _utilities.GetSqlConfigData("DbTerminalContext");
                //var t = _utilities.GetIfConnection();
                //var t = GetSqlConfigData("DbTerminalContext");

                using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
                {
                    tmp.Database.Initialize(true);
                    StoredProc ldbStoredProc =
                        new StoredProc().HasName("sp_databases").ReturnsTypes(typeof (ListDataBaseResultSet));
                    ResultsList results = tmp.CallStoredProc(ldbStoredProc);
                    List<ListDataBaseResultSet> tmplst = results.ToList<ListDataBaseResultSet>();

                    List<string> x = (from b in tmplst
                                      where
                                          b.DbName != "master" && b.DbName != "msdb" && b.DbName != "model" &&
                                          b.DbName != "IFDB" && b.DbName != "tempdb" &&
                                          b.DbName != "ReportServer$" + valueInstance &&
                                          b.DbName != "ReportServer$" + valueInstance + "TempDB"
                                      orderby b.DbName ascending
                                      select b.DbName).ToList();

                    if (x.Count > 0)
                    {
                        resultado = new BindableCollection<string>(x);
                    }
                }
            }
            catch (Exception ex)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }

            return resultado;
        }

        #endregion

        #region DbCrudFunctions

        public BindableCollection<TbTerminal> LoadTerminais()
        {
            BindableCollection<TbTerminal> resultado = null;
            try
            {
                //using (var tmp= new DbTerminalContext(_utilities.GetSqlConfigData("DbTerminalContext").ProviderConnectionString))
                using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
                {
                    var x = (from t in tmp.Terminais
                                          select t).ToList();
                    resultado = x.Any() ? new BindableCollection<TbTerminal>(x) : new BindableCollection<TbTerminal>();
                }
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            return resultado;
        }


        public bool CreateTerminal(TbTerminal valuet, TbOpcoesTerminal valueOp)
        {
            try
            {
                //using (var tmp = new DbTerminalContext(_utilities.GetSqlConfigData("DbTerminalContext").ProviderConnectionString))
                using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
                {
                    if (valueOp != null)
                    {
                        valuet.FkIDOT = valueOp.Id;
                        tmp.OpcoesTerminais.Add(valueOp);
                    }


                    tmp.Terminais.Add(valuet);
                    tmp.SaveChanges();
                }
            }
                //catch(DbEntityValidationException dbex)
                //{
                //    foreach (var validationErrors in dbex.EntityValidationErrors)
                //    {
                //        foreach (var Errovalidacao in validationErrors.ValidationErrors)
                //        {
                //            Debug.WriteLine("Property:{0} Error{1}",Errovalidacao.PropertyName,Errovalidacao.ErrorMessage);
                //        }
                //    }
                //}
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            return true;
        }

        public void UpdateTerminal(TbTerminal value, TbOpcoesTerminal valueop)
        {
            try
            {
                //using (var tmp = new DbTerminalContext(_utilities.GetSqlConfigData("DbTerminalContext").ProviderConnectionString))
                using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
                {
                    if (valueop != null)
                    {
                        
                        var tmpOp = (from t in tmp.OpcoesTerminais
                                     where t.Id == valueop.Id
                                     select t).SingleOrDefault();
                        if (tmpOp != null)
                        {
                            tmpOp.PhcNomeFiltroClientes = valueop.PhcNomeFiltroClientes;
                            tmpOp.PhcNomeFiltroArtigos = valueop.PhcNomeFiltroArtigos;
                            tmpOp.ArmazemEnvio = valueop.ArmazemEnvio;
                            tmpOp.ArmazemRegisto = valueop.ArmazemRegisto;
                            tmpOp.TipoRetencaoEncomendas = valueop.TipoRetencaoEncomendas;
                            tmpOp.NumeroEncomendasRetidas = valueop.NumeroEncomendasRetidas;
                            tmpOp.NumeroInicioEncomendas = valueop.NumeroInicioEncomendas;
                            tmpOp.NumeroFimEncomendas = valueop.NumeroFimEncomendas;
                            tmpOp.EliminarEncomendas = valueop.EliminarEncomendas;
                            tmpOp.AlterarPrecoVenda = valueop.AlterarPrecoVenda;
                            tmpOp.IntroduzComponentes = valueop.IntroduzComponentes;
                            tmpOp.MostrarDataLinhas = valueop.MostrarDataLinhas;
                            tmpOp.CriaLinhaEncomenda = valueop.CriaLinhaEncomenda;
                            tmpOp.NomeVendedor = valueop.NomeVendedor;
                            tmpOp.NumVendedor = valueop.NumVendedor;
                            tmpOp.NumeroInicioClientes = valueop.NumeroInicioClientes;
                            tmpOp.NumeroFimClientes = valueop.NumeroFimClientes;
                            tmpOp.SincronizaCcNaoRegula = valueop.SincronizaCcNaoRegula;
                            tmpOp.PhcNomeDossierInterno = valueop.PhcNomeDossierInterno;
                            tmpOp.PhcNumDossierInterno = valueop.PhcNumDossierInterno;
                            tmpOp.NumeroInicioClientes = valueop.NumeroInicioClientes;
                            tmpOp.NumeroFimClientes = valueop.NumeroFimClientes;
                            tmpOp.NumMaxDescontos = valueop.NumMaxDescontos;
                            tmpOp.UsaPreco1 = valueop.UsaPreco1;
                            tmpOp.UsaPreco2 = valueop.UsaPreco2;
                            tmpOp.UsaPreco3 = valueop.UsaPreco3;
                            tmpOp.UsaPreco4 = valueop.UsaPreco4;
                            tmpOp.UsaPreco5 = valueop.UsaPreco5;
                            tmpOp.NumMaxDescontos = valueop.NumMaxDescontos;
                            tmpOp.IniciaisUs = valueop.IniciaisUs;
                            //tmp.SaveChanges();
                        }
                    }
                    var tmpterminal = (from t in tmp.Terminais
                                       where t.IDTerminal == value.IDTerminal
                                       select t).SingleOrDefault();
                    if (tmpterminal != null)
                    {
                        tmpterminal.NumPda = value.NumPda;
                        tmpterminal.MacAddress3G = value.MacAddress3G;
                        tmpterminal.MacAddressWireless = value.MacAddressWireless;
                        tmpterminal.TerminalAccessKey = value.TerminalAccessKey;
                    }

                    tmp.SaveChanges();
                }
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
        }


        public void DeleteTerminal(Guid value)
        {
            try
            {
                using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
                {
                    var e = tmp.Terminais.Find(value);

                    if (e == null) return;
                    var tmpTerminals = tmp.OpcoesTerminais.Find(e.FkIDOT);

                    tmp.OpcoesTerminais.Remove(tmpTerminals);
                    tmp.Terminais.Remove(e);

                    tmp.SaveChanges();
                }
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            //using (var tmp=new DbTerminalContext(_utilities.GetSqlConfigData("DbTerminalContext").ProviderConnectionString))
        }

        public BindableCollection<TbOpcoesTerminal> LoadOpcoesTerminal()
        {
            BindableCollection<TbOpcoesTerminal> resultado = null;
            try
            {
                //using (var tmp = new DbTerminalContext(_utilities.GetSqlConfigData("DbTerminalContext").ProviderConnectionString))7
                using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
                {
                    var x = (from t in tmp.OpcoesTerminais
                                                select t).ToList();

                    resultado = x.Any()
                                    ? new BindableCollection<TbOpcoesTerminal>(x)
                                    : new BindableCollection<TbOpcoesTerminal>();
                }
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            return resultado;
        }

        public string SetNomeVendedor(int valueNumVendedor)
        {
            var tmp = (from t in _listaIniciais
                       where t.Vendedor == valueNumVendedor
                       select t.Vendnm).FirstOrDefault();

            return string.IsNullOrEmpty(tmp) ? "Sem Vendedor Associado" : tmp;
        }

        #region GetTbOpcoesEntity

        public TbOpcoesTerminal GetEntityOpcoes(Guid opcoesTerminalId)
        {
            using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
            {
                var tmpData = (from t in tmp.OpcoesTerminais
                                            where t.Id == opcoesTerminalId
                                            select t).SingleOrDefault();

                return tmpData;
            }
        }

        #endregion

        #endregion

        #region LoadPHCDATABulK
        /// <summary>
        /// Carrega os dados da phc
        /// </summary>
        public void LoadBulkData()
        {
            try
            {
                using (var tmp = new PdbContext(_utilities.GetPhcConnection()))
                {
                    try
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = false;

                        //var tmpFiltrosClientes = (from x in tmp.FiltrosClientes
                        //         select x.Ftitulo
                        //            ).ToList();




                        var tmpFiltrosClientes = (from t in tmp.FiltrosClientes
                                                  select new
                                                  {
                                                      _tStamp = t.Fltclstamp,
                                                      _tFiltroTitulo = t.Ftitulo
                                                  }).AsEnumerable().Select(tmpf => new Fltcl
                                                  {
                                                      Fltclstamp = tmpf._tStamp,
                                                      Ftitulo = tmpf._tFiltroTitulo
                                                  }).ToList();

                        _dadosFiltrosClientes = tmpFiltrosClientes.Any()
                                             ? new BindableCollection<Fltcl>(tmpFiltrosClientes)
                                             : new BindableCollection<Fltcl>();






                        var tmpFiltrosStocks = (from t in tmp.FiltrosStocks
                                                select new
                                                {
                                                    _tStamp = t.Fltststamp,
                                                    _tFiltroTitulo = t.Ftitulo
                                                }).AsEnumerable().Select(tmpf => new Fltst
                                                {
                                                    Fltststamp = tmpf._tStamp,
                                                    Ftitulo = tmpf._tFiltroTitulo
                                                }).ToList();




                        _dadosFiltrosStocks = tmpFiltrosStocks.Any()
                                             ? new BindableCollection<Fltst>(tmpFiltrosStocks)
                                             : new BindableCollection<Fltst>();






                        var tmpDataUs = (from t in tmp.DadosUs
                                         where t.Vendedor != 0 && t.Inactivo == false
                                         select new
                                         {
                                             _tVendedor = t.Vendedor,
                                             _tUsIniciais = t.Iniciais,
                                             _tNomeVendedor= t.Vendnm
                                         }).Distinct().AsEnumerable().Select(tmpUs => new Us
                                         {
                                             Vendedor = tmpUs._tVendedor,
                                             Iniciais = tmpUs._tUsIniciais,
                                             Vendnm = tmpUs._tNomeVendedor
                                         }).ToList();

                        _listaIniciais = tmpDataUs.Any()
                                             ? new BindableCollection<Us>(tmpDataUs)
                                             : new BindableCollection<Us>();




                        var tmpBosConfig = (from t in tmp.DadosTs
                                            select new
                                            {
                                                _tNdos = t.Ndos,
                                                _tNdos2 = t.Ndos2,
                                                _tNomeDossier = t.Nmdos,
                                                _tNdescs = t.Ndescs,
                                                _tArmazem= t.Armazem
                                            }).AsEnumerable().Select(tmpConfigBo => new Ts
                                            {
                                                Ndos = tmpConfigBo._tNdos,
                                                Ndos2 = tmpConfigBo._tNdos2,
                                                Nmdos = tmpConfigBo._tNomeDossier,
                                                Ndescs = tmpConfigBo._tNdescs,
                                                Armazem = tmpConfigBo._tArmazem
                                            }).ToList();

                        //var tmpBos = (from t in tmp.DossiersInternos
                        //         where t.Boclose == false && t.Fechada == false
                        //         select new
                        //         {
                        //             _tBostamp = t.Bostamp,
                        //             _tNo = t.No,
                        //             _tNmdos = t.Nmdos
                        //         }).Distinct().AsEnumerable().Select(tmpBo => new Bo
                        //         {
                        //             Bostamp = tmpBo._tBostamp,
                        //             No = tmpBo._tNo,
                        //             Nmdos = tmpBo._tNmdos

                        //         }).ToList();

                        _listaNumerosDescontos = tmpBosConfig.Any()
                                                     ? new BindableCollection<Ts>(tmpBosConfig)
                                                     : new BindableCollection<Ts>();

                        //var tmpUsr = (from t in tmp.DadosClientes
                        //              where t.Inactivo == false
                        //              select new
                        //              {
                        //                  _Vendedor = t.Vendedor,
                        //                  _VendNm = t.Vendnm
                        //              }).Distinct().AsEnumerable().Select(tmpCl => new Cl
                        //              {
                        //                  Vendnm = tmpCl._VendNm,
                        //                  Vendedor = tmpCl._Vendedor
                        //              }).ToList();


                        //_dadosUtilizadores = tmpUsr.Any()
                        //                         ? new BindableCollection<Cl>(tmpUsr)
                        //                         : new BindableCollection<Cl>();
                    }
                    finally
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = true;
                    }
                }
            }
            catch (Exception e)
            {

                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
        }
        #endregion

        #region LoadPHCFILTERS

        


        #region PHCFILTERCL

        public BindableCollection<string> LoadFiltrosClientes()
        {
            //return _filtrosClientes ?? new BindableCollection<string>();

            if (_filtrosClientes!=null)
            {
                return _filtrosClientes;
            }
            _filtrosClientes= new BindableCollection<string>();
            foreach (var item in _dadosFiltrosClientes)
            {
                _filtrosClientes.Add(item.Ftitulo);
            }
            return _filtrosClientes;
        }


        public string DevolveStampFiltroClientes(string value)
        {
            return (from item in _dadosFiltrosClientes
                    where item.Ftitulo == value
                    select item.Fltclstamp).FirstOrDefault();
        }

        public string DevolveNomeFiltroClientes(string value)
        {
            var tmp= (from item in _dadosFiltrosClientes
                    where item.Fltclstamp.Trim() == value
                      select item.Ftitulo).SingleOrDefault();

            return string.IsNullOrEmpty(tmp) ? "Sem Valor Definido" : tmp;
        }
        //private BindableCollection<string> LoadFiltrosClientesPhc()
        //{
        //    BindableCollection<string> resultado = null;
        //    try
        //    {
        //        using (var tmp = new PdbContext(_utilities.GetPhcConnection()))
        //            //using (var tmp = new PdbContext(_utilities.GetSqlConfigData("PHC").ProviderConnectionString))
        //        {
        //            try
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = false;
        //                var t = (from x in tmp.FiltrosClientes
        //                         select x.Ftitulo
        //                            ).ToList();

        //                resultado = t.Any()
        //                            ? new BindableCollection<string>(t)
        //                            : new BindableCollection<string>();
        //            }
        //            finally
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = true;
        //            }
                   

                    
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
        //    }
        //    return resultado;
        //}

        #endregion

        #region PHCFILTERST

        public BindableCollection<string> LoadFiltrosStocks()
        {
            
            if (_filtrosStocks != null)
            {
                return _filtrosStocks;
            }
            _filtrosStocks = new BindableCollection<string>();
            foreach (var item in _dadosFiltrosStocks)
            {
                _filtrosStocks.Add(item.Ftitulo);
            }
            return _filtrosStocks;
        }


        public string DevolveStampFiltroStocks(string value)
        {
            return (from item in _dadosFiltrosStocks where item.Ftitulo == value select item.Fltststamp).SingleOrDefault();
        }

        public string DevolveNomeFiltroStocks(string value)
        {
            var tmp = (from t in _dadosFiltrosStocks
                       where t.Fltststamp.Trim()==value
                       select t.Ftitulo).SingleOrDefault();

            return string.IsNullOrEmpty(tmp) ? "Sem Valor Definido" : tmp;
        }
        //private BindableCollection<string> LoadFiltrosStocksPhc()
        //{
        //    BindableCollection<string> resultado = null;
        //    try
        //    {
        //        //using (var tmp= new PdbContext(_utilities.GetSqlConfigData("PHC").ProviderConnectionString))
        //        using (var tmp = new PdbContext(_utilities.GetPhcConnection()))
        //        {
        //            try
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = true;
        //                var x = (from t in tmp.FiltrosStocks
        //                         select t.Ftitulo).ToList();
        //                resultado = x.Any()
        //                                ? new BindableCollection<string>()
        //                                : new BindableCollection<string>(x);
        //            }
        //            finally
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = false;
        //            }
                   
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
        //    }
        //    return resultado;
        //}

        #endregion

        #region oldDevolveDadosUS


        //public void GetDadosUs()
        //{
        //    if (_listaIniciais!=null)return;
        //    try
        //    {

        //        using (var tmp = new PdbContext(_utilities.GetPhcConnection()))
        //        {
        //            try
        //            {
        //                var tmpData = (from t in tmp.DadosUs
        //                                  where t.Vendedor != 0
        //                                  select new
        //                                             {
        //                                                 _tVendedor = t.Vendedor,
        //                                                 _tUsIniciais = t.Iniciais
        //                                             }).Distinct().AsEnumerable().Select(tmpUs => new Us
        //                                                                                              {
        //                                                                                                  Vendedor = tmpUs._tVendedor,
        //                                                                                                  Iniciais = tmpUs._tUsIniciais
        //                                                                                              }).ToList();


        //                _listaIniciais = new BindableCollection<Us>(tmpData);
                        


        //            }
        //            finally
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = true;
        //            }
                   
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
        //    }

            
        //} 
        public string GetIniciaisPhc(int value)
        {
            var resultado = "NOV";
            try
            {
                //using (var tmp = new PdbContext(_utilities.GetPhcConnection()))
                //{
                //    string tmpData = (from t in tmp.DadosUs
                //                      where t.Vendedor != 0 && t.Vendedor == value
                //                      select t.Iniciais).SingleOrDefault();

                //    if (tmpData != null)
                //    {
                //        resultado = tmpData;
                //    }

                
                var tmp = (from t in _listaIniciais
                           where t.Vendedor == value
                           select t.Iniciais).FirstOrDefault();

                if (!string.IsNullOrEmpty(tmp))
                {
                    resultado = tmp;
                }
               
                
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }

            return resultado;
        }

        #endregion

        #region LoadDossiersInternos

        public BindableCollection<int> CarregaDossiersInternos()
        {
           
            if (_listaNumerosDossiers != null) return _listaNumerosDossiers;

            _listaNumerosDossiers = new BindableCollection<int>();

            foreach (var item in _listaNumerosDescontos)
            {
                _listaNumerosDossiers.Add((int) item.Ndos);
            }


            return _listaNumerosDossiers;
        }

        //alterar os dossiers internos para conter o numero dossier interno nao somente o nome(tem que ser guardado tambem)

        public string GetNomeDossier(int valueDossier)
        {
            var resultado = "";
            if (_listaNumerosDossiers == null)
            {
                resultado = "Nao existem item para devolver";
            }
            else
            {
                var tmpNome = (from t in _listaNumerosDescontos
                               where t.Ndos == valueDossier
                               select t.Nmdos).FirstOrDefault();

                resultado = string.IsNullOrEmpty(tmpNome) ? "Nao existe item para devolver" : tmpNome;
            }

            return resultado;
        }

        #region olddossiers
        //private BindableCollection<Bo> LoadDossiersInternos()
        //{
        //    BindableCollection<Bo> resultado = null;
        //    try
        //    {
        //        using (var tmp = new PdbContext(_utilities.GetPhcConnection()))
        //        //using (var tmp= new PdbContext(_utilities.GetSqlConfigData("PHC").ConnectionString))
        //        {
        //            try
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = false;
        //                var x = (from t in tmp.DossiersInternos
        //                         where t.Boclose == false && t.Fechada == false
        //                         select new
        //                         {
        //                             _tBostamp = t.Bostamp,
        //                             _tNo = t.No,
        //                             _tNmdos = t.Nmdos
        //                         }).Distinct().AsEnumerable().Select(tmpBo => new Bo
        //                         {
        //                             Bostamp = tmpBo._tBostamp,
        //                             No = tmpBo._tNo,
        //                             Nmdos = tmpBo._tNmdos

        //                         }).ToList();


        //                //var x = (from t in tmp.DossiersInternos
        //                //         where t.Boclose == false && t.Fechada == false
        //                //         select t).Distinct().ToList();

        //                //var tmpLista = x.Select(item => new Bo
        //                //                                    {
        //                //                                        Bostamp = item.Bostamp, No = item.No, Nmdos = item.Nmdos
        //                //                                    }).ToList();

        //                resultado = x.Any()
        //                                ? new BindableCollection<Bo>()
        //                                : new BindableCollection<Bo>(x);

        //            }
        //            finally
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = true;
        //            }





        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        EventAggregationProvider.Aggregator.Publish(e.InnerException != null
        //                                                        ? new EventoBackend(EventoTipo.Erro, e.InnerException + "n" + "Connection String:\n" + _utilities.GetPhcConnection() + "\n")
        //                                                        : new EventoBackend(EventoTipo.Erro, e.Message));
        //    }
        //    return resultado;
        //}
        #endregion

        #endregion

        #region DataVendedores

        public BindableCollection<int> LoadVendedores()
        {
            //if (_dadosUtilizadores == null)
            //{
            //    _dadosUtilizadores = LoadNumVendedor();
            //}
            //if (_numerosVendedores != null) return _numerosVendedores;

            //_numerosVendedores = new BindableCollection<int>();

            //if (_dadosUtilizadores == null) return _numerosVendedores;


            //foreach (var item in _dadosUtilizadores.Where(item => !_numerosVendedores.Contains((int)item.Vendedor)))
            //{
            //    _numerosVendedores.Add((int)item.Vendedor);
            //}
            //return _numerosVendedores;


            if (_numerosVendedores != null) return _numerosVendedores;
            _numerosVendedores= new BindableCollection<int>();

            foreach (var item in _listaIniciais)
            {
                _numerosVendedores.Add((int) item.Vendedor);
            }
            return _numerosVendedores;
        }

        #region OldVendedor
        //private BindableCollection<Cl> LoadNumVendedor()
        //{
        //    BindableCollection<Cl> resultado = null;
        //    try
        //    {
        //        using (var tmp = new PdbContext(_utilities.GetPhcConnection()))
        //        {
        //            try
        //            {

        //                tmp.Configuration.AutoDetectChangesEnabled = false;


        //                //var tmpUsr = (from t in tmp.DadosClientes
        //                //                   where t.Inactivo == false
        //                //                   select t).Distinct().ToList();


        //                var tmpUsr = (from t in tmp.DadosClientes
        //                              where t.Inactivo == false
        //                              select new
        //                              {
        //                                  _Vendedor = t.Vendedor,
        //                                  _VendNm = t.Vendnm
        //                              }).Distinct().AsEnumerable().Select(tmpCl => new Cl
        //                              {
        //                                  Vendnm = tmpCl._VendNm,
        //                                  Vendedor = tmpCl._Vendedor
        //                              }).ToList();

        //                resultado = tmpUsr.Any()
        //                                ? new BindableCollection<Cl>()
        //                                : new BindableCollection<Cl>(tmpUsr);
        //            }
        //            finally
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = true;
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
        //    }
        //    return resultado;
        //}
        #endregion
        #endregion

        #region TSData

       


        public int DevolveValorDesconto(decimal value)
        {
            try
            {
                if (_listaNumerosDescontos == null) return 0;



                var tmp = (from t in _listaNumerosDescontos
                           where t.Ndos == value
                           select t.Ndescs).FirstOrDefault();

                return (int)tmp;
            }
            catch(Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(e.InnerException != null
                                                                ? new EventoBackend(EventoTipo.Erro, e.InnerException)
                                                                : new EventoBackend(EventoTipo.Erro, e.Message));
            }

            return 0;
            

        }
        public decimal DevolveArmazem(int value)
        {
            if (_listaNumerosDescontos == null) return 0;

            var tmpData = (from t in _listaNumerosDescontos
                           where t.Ndos == value
                           select t.Armazem).FirstOrDefault();
            return tmpData;
        }

        #region OldDesconto

        //public int DevolveDesconto(decimal value)
        //{
        //    if (_listaNumerosDescontos == null)
        //    {
        //        _listaNumerosDescontos = DevolveListaDescontos();
        //    }
        //    return DevolveValorDesconto(value);
        //}


        //private BindableCollection<Ts> DevolveListaDescontos()
        //{
        //    var resultado = new BindableCollection<Ts>();
        //    try
        //    {
        //        using (var tmp = new PdbContext(_utilities.GetPhcConnection()))
        //        {
        //            try
        //            {
        //                tmp.Configuration.AutoDetectChangesEnabled = false;
        //                var tmpd = (from t in tmp.DadosTs
        //                            select t).ToList();



        //                if (tmpd.Any())
        //                {
        //                    foreach (var tse in tmpd)
        //                    {
        //                        resultado.Add(tse);
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
        //        EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
        //    }
        //    return resultado;
        //}
        #endregion
        

        #endregion

        #endregion

       
        #region MockData

        public ObservableCollection<Terminal> LoadMockTerminals()
        {
            return _mockService.GenerateMockData();
        }

        public void CreateMockTerminal(Terminal value)
        {
        }

        public void UpdateTerminal(Terminal value)
        {
        }

        public void DeleteMockTerminal(Terminal vaue)
        {
        }
        private readonly MockService _mockService = new MockService();
        //

        public string DevolveNumTerminal(Guid value)
        {
            var resultado = "Sem Numero";
            try
            {
                using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
                {
                    try
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = false;
                        var tmpd = (from t in tmp.Terminais
                                    where t.FkIDOT == value
                                    select t.NumPda).SingleOrDefault();


                        if (tmpd != null)
                        {
                            resultado = tmpd;
                        }

                    }
                    finally
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = true;
                    }
                    return resultado;
                }
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            return resultado;
        }

        public bool VerificaTerminalNum(string value)
        {
            var resultado = false;
            try
            {
                using (var tmp = new DbTerminalContext(_utilities.GetIfConnection()))
                {
                    try
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = false;
                        var tmpd = (from t in tmp.Terminais
                                    where t.NumPda == value
                                    select t.NumPda).SingleOrDefault();


                        resultado = tmpd != null;

                    }
                    finally
                    {
                        tmp.Configuration.AutoDetectChangesEnabled = true;
                    }

                }
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            return resultado;
        }
        #endregion

       
    }
}