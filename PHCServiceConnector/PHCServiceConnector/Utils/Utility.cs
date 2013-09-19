using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Web.Configuration;
using ConnectorService.Model.IFModel.VODadosTerminal;
using ConnectorService.Model.PHCModel;
using ConnectorService.Model.PHCModel.VODadosPHC;
using Newtonsoft.Json;
using System.Linq;
using PHCServiceConnector.Model.DbModel.IFModel;
using PHCServiceConnector.Model.DbModel.PHCMODEL;

namespace PHCServiceConnector.Utils
{
    public class Utility
    {
        #region ClassVars

        private static Utility _instance;
        private static EntityConnectionStringBuilder _phcConnStrBuilder;
        private static EntityConnectionStringBuilder _ifConnStrBuilder;

        #endregion

        #region Ctor
        private Utility()
        {

        }
        public static Utility GetInstance()
        {
            return _instance ?? (_instance = new Utility());
        }
        #endregion


        #region ConnectionStringData
        public static EntityConnectionStringBuilder GetSqlConfigData(string value)
        {
            var resultado = new EntityConnectionStringBuilder();
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var config = WebConfigurationManager.OpenWebConfiguration("~");
            var connString = config.ConnectionStrings.ConnectionStrings[value].ConnectionString;
            var sqlbuilder = new SqlConnectionStringBuilder(connString);
            resultado.Metadata = @"res://*/";
            resultado.Provider = "System.Data.SqlClient";
            resultado.ProviderConnectionString = sqlbuilder.ToString();
            return resultado;
        }

        public static void IniciaPhConnection()
        {
            _phcConnStrBuilder = GetSqlConfigData("PHCDATA");
        }
        public static void IniciaIfConnection()
        {
            _ifConnStrBuilder = GetSqlConfigData("DbTerminalContext");
        }

        public EntityConnectionStringBuilder DevolveConnectionStringPhc()
        {
            if (_phcConnStrBuilder == null)
            {
                IniciaPhConnection();
            }
            return _phcConnStrBuilder;
        }

        public EntityConnectionStringBuilder DevolveCOnnectionStringIf()
        {
            if (_ifConnStrBuilder == null)
            {
                IniciaIfConnection();
            }
            return _ifConnStrBuilder;
        }
        #endregion

        #region SerializaDadosEncomendas

        /// <summary>
        /// metodo para deserializar os dados das encomendas
        /// </summary>
        /// <param name="valueBo" />
        /// <param name="valueBi"> </param>
        /// <returns></returns>
        /// 
        public string SerializeEncomendas(List<Vobo> valueBo, List<VoBi> valueBi)
        {
            var resultCollection = new Dictionary<string, object>
                                       {
                                           {"DadosBo",valueBo},
                                           {"DadosBi",valueBi}
                                       };
            return JsonConvert.SerializeObject(resultCollection, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling =
                    TypeNameHandling.
                    All,
                TypeNameAssemblyFormat
                    =
                    FormatterAssemblyStyle
                    .Simple
            });
        }
#endregion

        #region SerializeConfigTerminal
        /// <summary>
        /// serializa as configuracoes do terminal
        /// </summary>
        /// <param name="valueIft"></param>
        /// <param name="valueOpT"></param>
        /// <returns></returns>
        public ConfiguracaoTerminal SerializeConfigTerminal(Terminais valueIft, OpcoesTerminais valueOpT)
        {
            var config = ConvertTbConfigVoConfig(valueIft, valueOpT);
            //return JsonConvert.SerializeObject(config);
            return config;
        }
        #endregion

        #region SerializeAccessKey
        /// <summary>
        /// Serializacao da access key, deste modo esconde o nome do metodo quando a funcao retorna
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public AcesskeyData SerializeAccessKey(string value)
        {
            var tmpResultKey = new AcesskeyData
            {
                DataAccessKey = value
            };

            return tmpResultKey;
            // return JsonConvert.SerializeObject(tmpResultKey);
        }
        #endregion

        #region SerializeClientes

        /// <summary>
        /// serializa somente a lista de clientes /testar
        /// </summary>
        /// <param name="value"></param>
        /// <param name="valueCc"> </param>
        /// <returns></returns>
        public DadosTerminal SerializeClientes(List<Cl> value, List<Cc> valueCc)
        {
            var resultado = new DadosTerminal
            {
                DadosClientes = value.Select(ConvertTbClVoCl).ToList(),
                DadosStocks = new List<VOst>(),
                DadosContasCorrentes = valueCc.Select(ConvertTbCcvoCc).ToList(),
                DadosTaxasIva = new List<VOtaxasIva>(),
                DadosPn = new List<Vopn>(),
                //DadosStobs = new List<VoStObs>()
            };

            return resultado;
            //return JsonConvert.SerializeObject(resultado, Formatting.Indented, new JsonSerializerSettings
            //{
            //    TypeNameHandling =
            //        TypeNameHandling.
            //        All,
            //    TypeNameAssemblyFormat
            //        =
            //        FormatterAssemblyStyle
            //        .Simple
            //});
        }
        #endregion

        #region SerializeStocks

        /// <summary>
        /// serializa somente a lista de stocks /testar
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DadosTerminal SerializeStocks(List<St> value)
        {
            var resultado = new DadosTerminal
            {

                DadosStocks = value.Select(ConvertTbStVoSt).ToList(),

                //DadosStobs = valueStobs.Select(ConverTbStobsVoStobs).ToList()

            };

            return resultado;
            //return JsonConvert.SerializeObject(resultado, Formatting.Indented, new JsonSerializerSettings
            //{
            //    TypeNameHandling =
            //        TypeNameHandling.
            //        All,
            //    TypeNameAssemblyFormat
            //        =
            //        FormatterAssemblyStyle
            //        .Simple
            //});
        }
        #endregion

        #region SerializeTaxas
        public DadosTerminal SerializeTaxas(List<Taxasiva> value)
        {
            return new DadosTerminal
            {
                DadosTaxasIva = value.Select(ConvertTbTaxasIvaVoTaxasIva).ToList()
            };
        }
        #endregion
        #region DeserializationVO

        #region DeSerializeBI
        /// <summary>
        /// metodo para deserializar os dados da bi
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public IList<VoBi> DeserializeBi(string value)
        {


            var tmp = JsonConvert.DeserializeObject<RootElement>(value);

            return tmp.VoBiList;
        }

        //public IList<RemoteBi> DeserializeRemoteBi(string value)
        //{
        //    var tmp = JsonConvert.DeserializeObject<RootElement>(value);
        //    return new List<RemoteBi>();
        //    //return tmp.VoBiList;
        //}
        #endregion

        #region DeSerializeBO
        /// <summary>
        /// metodo para deserializar os dados da bo
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public IList<Vobo> DeserializeBo(string value)
        {
            var tmp = JsonConvert.DeserializeObject<RootElement>(value);
            return tmp.VoBoList;
        }

        //public IList<RemoteBo> DeserializeRemotebBo(string value)
        //{
        //    var tmp = JsonConvert.DeserializeObject<RootElement>(value);
        //    return new List<RemoteBo>();
        //    // return tmp.VoBoList;
        //}
        #endregion
        #endregion

        #region ConvertConfigurationVO
        /// <summary>
        /// metodo para converter a entidade para vo (configuracao terminal)
        /// </summary>
        /// <param name="valueT"></param>
        /// <param name="valueop"></param>
        /// <returns></returns>
        #region ConvertTbConfigToVOConfig
        public ConfiguracaoTerminal ConvertTbConfigVoConfig(Terminais valueT, OpcoesTerminais valueop)
        {
            return new ConfiguracaoTerminal
            {
                IdConfiguracao = valueT.IDTerminal.ToString(),
                NumPda = valueT.NumPda,
                NomeVendedor = valueop.NomeVendedor,
                NumVendedor = valueop.NumVendedor,

                FiltroCliente = valueop.PhcNomeFiltroClientes,
                FiltroStock = valueop.PhcNomeFiltroArtigos,

                ArmazemEnvioEncomenda = valueop.ArmazemEnvio,
                ArmazemRegistoEncomenda = valueop.ArmazemRegisto,
                PhcNumDossier = valueop.PhcNumDossierInterno,
                PhcNomeDossier = valueop.PhcNomeDossierInterno,
                TipoRetencaoEncomendas = valueop.TipoRetencaoEncomendas,
                NumeroEncomendasRetidas = valueop.NumeroEncomendasRetidas,
                NumeroInicioClientes = valueop.NumeroInicioClientes,
                NumeroFimClientes = valueop.NumeroFimClientes,
                NumeroFimEncomendas = valueop.NumeroFimEncomendas,
                NumeroInicioEncomendas = valueop.NumeroInicioEncomendas,

                EliminarEncomendas = Convert.ToInt32(valueop.EliminarEncomendas),
                AlterarPrecoVenda = Convert.ToInt32(valueop.AlterarPrecoVenda),
                IntroduzComponentes = Convert.ToInt32(valueop.IntroduzComponentes),
                MostrarDataLinhas = Convert.ToInt32(valueop.MostrarDataLinhas),
                CriaLinhaEncomenda = Convert.ToInt32(valueop.CriaLinhaEncomenda),
                NumMaxDescontos = valueop.NumMaxDescontos,
                UsaPrecoUm = Convert.ToInt32(valueop.UsaPreco1),
                UsaPrecoDois = Convert.ToInt32(valueop.UsaPreco2),
                UsaPrecoTres = Convert.ToInt32(valueop.UsaPreco3),
                UsaPrecoQuatro = Convert.ToInt32(valueop.UsaPreco4),
                UsaPrecoCinco = Convert.ToInt32(valueop.UsaPreco5),
                PhcInitials = valueop.IniciaisUs
            };
        }
        #endregion


        #endregion

        #region Convert BI


        #region ConvertVOTOTB
        /// <summary>
        /// metod para converter os dados da vo para entidade (vo bi -> para bi)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Bi ConvertVoTb(VoBi value)
        {
            return new Bi
            {
                Bistamp = value.BIstamp,
                Ivaincl = ConvertDecimaltoBool(value.Ivaincl),
                Vendnm = value.Vendnm,
                Vendedor = value.Vendedor,
                Iva = value.Iva,
                Lordem = value.Lordem,
                Tabiva = value.Tabiva,
                Txiva = value.Txiva,
                Familia = value.Familia,
                Promo = Convert.ToBoolean(value.Promo),
                Epromo = Convert.ToBoolean(value.Epromo),
                Bostamp = value.Bostamp,
                Nmdos = value.Nmdos,
                Ndos = value.Ndos,
                //ver este campo
                Obrano = value.Obrano,
                Referencia = value.Ref,
                Design = value.Design,
                Edebito = value.Edebito,
                Desconto = value.Desconto,
                Desc2 = value.Desc2,
                Desc3 = value.Desc3,
                Desc4 = value.Desc4,
                Desc5 = value.Desc5,
                Desc6 = value.Desc6,
                Ettdeb = value.Ettdeb,
                Qtt = value.Qtt,
                Stipo = value.Stipo,
                //ver este campo no trace
                Armazem = value.Armazem,
                //
                //ver esta conversao
                Rdata = Convert.ToDateTime(value.Rdata),
                //
                //campos que nao vem preenchidos da vo do pda comparar com o trace


                Qtt2 = 0,
                Pu = 0,
                Debito = 0,
                Prorc = 0,
                No = 0,
                Pcusto = 0,
                Serie = " ",
                Nomquina = 0,
                Nopat = 0,
                Fno = 0,
                Fdata = DateTime.UtcNow,
                Nmdoc = " ",
                Ndoc = 0,
                Forref = " ",
                Dedata = DateTime.UtcNow,
                Atedata = DateTime.UtcNow,
                Lobs = " ",
                Ldossier = 0,
                //teste para obter o bo obranome

                //
                Fechada = false,
                Datafinal = DateTime.UtcNow,
                Dataobra = DateTime.UtcNow,
                Dataopen = DateTime.UtcNow,
                Datafecho = DateTime.UtcNow,
                Tecnico = 0,
                Maquina = " ",
                Marca = " ",
                Zona = " ",
                Litem = " ",
                Vumoeda = 0,
                Resfor = false,
                Rescli = false,
                Resrec = false,
                Iprint = false,
                Lobs2 = " ",
                Litem2 = " ",
                Lobs3 = " ",
                Estab = 0,
                Resusr = false,
                Ar2Mazem = 0,
                Composto = false,
                Compostoori = false,
                Lrecno = " ",
                Fmarcada = false,
                Producao = false,
                Local = " ",
                Morada = " ",
                Codpost = " ",
                Nome = " ",
                Tabfor = false,
                Tabela1 = " ",
                Descli = false,
                Reff = " ",
                Lote = " ",
                Cor = " ",
                Tam = " ",
                Segmento = " ",
                Bofref = " ",
                Bifref = " ",
                Grau = 0,
                Partes = 0,
                Partes2 = 0,
                Altura = 0,
                Largura = 0,
                Espessura = 0,
                Biserie = " ",
                Infref = false,
                Lifref = false,
                Uni2Qtt = 0,
                Epu = 0,
                Eprorc = 0,
                Epcusto = 0,
                Ttdeb = 0,
                Ttmoeda = 0,
                Adoc = " ",
                Binum1 = 0,
                Binum2 = 0,
                Codigo = " ",
                Cpoc = 0,
                Stns = false,
                Obistamp = " ",
                Oobistamp = " ",
                Usr1 = " ",
                Usr2 = " ",
                Usr3 = " ",
                Usr4 = " ",
                Usr5 = " ",
                Usr6 = " ",
                Usalote = false,
                Texteis = false,
                Unidade = " ",
                Unidad2 = " ",
                Oftstamp = " ",
                Ofostamp = " ",
                Sattotal = false,
                Noserie = false,
                Slvu = 0,
                Eslvu = 0,
                Sltt = 0,
                Esltt = 0,
                Slvumoeda = 0,
                Slttmoeda = 0,
                Ncmassa = 0,
                Ncunsup = 0,
                Ncvest = 0,
                Encvest = 0,
                Nccod = " ",
                Ncinteg = " ",
                Classif = 0,
                Classifc = " ",
                Posic = " ",

                Series = " ",
                Series2 = " ",
                Ccusto = " ",
                Ncusto = " ",
                Num1 = 0,
                Fechabo = false,
                Oobostamp = " ",
                Ltab1 = " ",
                Ltab2 = " ",
                Ltab3 = " ",
                Ltab4 = " ",
                Ltab5 = " ",
                Fami = " ",
                Pctfami = 0,
                Adjudicada = false,
                Tieca = 0,
                Etieca = 0,
                Mtieca = 0,
                Volume = 0,
                Iecasug = false,
                Iecagrad = 0,
                Iecacodisen = " ",
                Peso = 0,
                Pbruto = 0,
                Codfiscal = " ",
                Dgeral = " ",
                Temoci = false,
                Temomi = false,
                Temsubemp = false,
                Encargo = 0,
                Eencargo = 0,
                Custoind = 0,
                Tiposemp = " ",
                Pvok = false,
                Boclose = false,
                Dtclose = DateTime.UtcNow,
                Quarto = " ",
                Emconf = false,
                Efornecedor = " ",
                Efornec = 0,
                Efornestab = 0,
                Cativo = false,
                Optstamp = " ",
                Oristamp = " ",
                Temeco = false,
                Ecoval = 0,
                Tecoval = 0,
                Etecoval = 0,
                Eecoval = 0,
                Eecoval2 = 0,
                Etecoval2 = 0,
                Econotcalc = false,
                Ousrinis = " ",
                Ousrdata = DateTime.UtcNow,
                Ousrhora = " ",
                Usrinis = " ",
                Usrdata = DateTime.UtcNow,
                Usrhora = " ",
                Marcada = false,
                Mntencargos = false,
                Debitoori = 0,
                Edebitoori = 0,
                Trocaequi = false,
                Tpromo = 0,
                Valdesc = 0,
                Evaldesc = 0,
                Ecoval2 = 0,
                Ecustoind = 0,
                Tecoval2 = 0,
                Obranome = ""
                //

            };

        }



        #endregion


        #region ConvertRemoteVOTOTB

        /// <summary>
        /// metodo para converter as vo's streamed
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Bi ConvertRemoveBiTb(RemoteBi value)
        {
            return new Bi
            {
                Bistamp = value.BIstamp,
                Ivaincl = ConvertDecimaltoBool(value.Ivaincl),
                //Vendnm = value.Vendnm,
                //Vendedor = value.Vendedor,
                Iva = value.Iva,
                Lordem = value.Lordem,
                Tabiva = value.Tabiva,
                Txiva = value.Txiva,
                //Familia = value.Familia,
                Promo = Convert.ToBoolean(value.Promo),
                Epromo = Convert.ToBoolean(value.Epromo),
                Bostamp = value.Bostamp,
                //Nmdos = value.Nmdos,
                //Ndos = value.Ndos,
                //ver este campo
                Obrano = value.Obrano,
                Referencia = value.Ref,
                //Design = value.Design,
                Edebito = value.Edebito,
                Desconto = value.Desconto,
                Desc2 = value.Desc2,
                Desc3 = value.Desc3,
                Desc4 = value.Desc4,
                Desc5 = value.Desc5,
                Desc6 = value.Desc6,
                Ettdeb = value.Ettdeb,
                Qtt = value.Qtt,
                Stipo = value.Stipo,
                //ver este campo no trace
                Armazem = value.Armazem,
                //
                //ver esta conversao
                Rdata = Convert.ToDateTime(value.Rdata),
                //
                //campos que nao vem preenchidos da vo do pda comparar com o trace


                Qtt2 = 0,
                Pu = 0,
                Debito = 0,
                Prorc = 0,
                No = 0,
                Pcusto = 0,
                Serie = " ",
                Nomquina = 0,
                Nopat = 0,
                Fno = 0,
                Fdata = DateTime.UtcNow,
                Nmdoc = " ",
                Ndoc = 0,
                Forref = " ",
                Dedata = DateTime.UtcNow,
                Atedata = DateTime.UtcNow,
                Lobs = " ",
                Ldossier = 0,
                //teste para obter o bo obranome

                //
                Fechada = false,
                Datafinal = DateTime.UtcNow,
                Dataobra = DateTime.UtcNow,
                Dataopen = DateTime.UtcNow,
                Datafecho = DateTime.UtcNow,
                Tecnico = 0,
                Maquina = " ",
                Marca = " ",
                Zona = " ",
                Litem = " ",
                Vumoeda = 0,
                Resfor = false,
                Rescli = false,
                Resrec = false,
                Iprint = false,
                Lobs2 = " ",
                Litem2 = " ",
                Lobs3 = " ",
                Estab = 0,
                Resusr = false,
                Ar2Mazem = 0,
                Composto = false,
                Compostoori = false,
                Lrecno = " ",
                Fmarcada = false,
                Producao = false,
                Local = " ",
                Morada = " ",
                Codpost = " ",
                Nome = " ",
                Tabfor = false,
                Tabela1 = " ",
                Descli = false,
                Reff = " ",
                Lote = " ",
                Cor = " ",
                Tam = " ",
                Segmento = " ",
                Bofref = " ",
                Bifref = " ",
                Grau = 0,
                Partes = 0,
                Partes2 = 0,
                Altura = 0,
                Largura = 0,
                Espessura = 0,
                Biserie = " ",
                Infref = false,
                Lifref = false,
                Uni2Qtt = 0,
                Epu = 0,
                Eprorc = 0,
                Epcusto = 0,
                Ttdeb = 0,
                Ttmoeda = 0,
                Adoc = " ",
                Binum1 = 0,
                Binum2 = 0,
                Codigo = " ",
                Cpoc = 0,
                Stns = false,
                Obistamp = " ",
                Oobistamp = " ",
                Usr1 = " ",
                Usr2 = " ",
                Usr3 = " ",
                Usr4 = " ",
                Usr5 = " ",
                Usr6 = " ",
                Usalote = false,
                Texteis = false,
                Unidade = " ",
                Unidad2 = " ",
                Oftstamp = " ",
                Ofostamp = " ",
                Sattotal = false,
                Noserie = false,
                Slvu = 0,
                Eslvu = 0,
                Sltt = 0,
                Esltt = 0,
                Slvumoeda = 0,
                Slttmoeda = 0,
                Ncmassa = 0,
                Ncunsup = 0,
                Ncvest = 0,
                Encvest = 0,
                Nccod = " ",
                Ncinteg = " ",
                Classif = 0,
                Classifc = " ",
                Posic = " ",

                Series = " ",
                Series2 = " ",
                Ccusto = " ",
                Ncusto = " ",
                Num1 = 0,
                Fechabo = false,
                Oobostamp = " ",
                Ltab1 = " ",
                Ltab2 = " ",
                Ltab3 = " ",
                Ltab4 = " ",
                Ltab5 = " ",
                Fami = " ",
                Pctfami = 0,
                Adjudicada = false,
                Tieca = 0,
                Etieca = 0,
                Mtieca = 0,
                Volume = 0,
                Iecasug = false,
                Iecagrad = 0,
                Iecacodisen = " ",
                Peso = 0,
                Pbruto = 0,
                Codfiscal = " ",
                Dgeral = " ",
                Temoci = false,
                Temomi = false,
                Temsubemp = false,
                Encargo = 0,
                Eencargo = 0,
                Custoind = 0,
                Tiposemp = " ",
                Pvok = false,
                Boclose = false,
                Dtclose = DateTime.UtcNow,
                Quarto = " ",
                Emconf = false,
                Efornecedor = " ",
                Efornec = 0,
                Efornestab = 0,
                Cativo = false,
                Optstamp = " ",
                Oristamp = " ",
                Temeco = false,
                Ecoval = 0,
                Tecoval = 0,
                Etecoval = 0,
                Eecoval = 0,
                Eecoval2 = 0,
                Etecoval2 = 0,
                Econotcalc = false,
                Ousrinis = " ",
                Ousrdata = DateTime.UtcNow,
                Ousrhora = " ",
                Usrinis = " ",
                Usrdata = DateTime.UtcNow,
                Usrhora = " ",
                Marcada = false,
                Mntencargos = false,
                Debitoori = 0,
                Edebitoori = 0,
                Trocaequi = false,
                Tpromo = 0,
                Valdesc = 0,
                Evaldesc = 0,
                Ecoval2 = 0,
                Ecustoind = 0,
                Tecoval2 = 0,
                Obranome = "",
                Design = "",
                Vendedor = 0,
                Familia = "",
                Ndos = 0,
                Vendnm = "",
                Nmdos = ""
                //


            };
        }
        #endregion
        #endregion

        #region ConvertBI2


        #region GenerateBi2
        /// <summary>
        /// cria uma entidade bi2 para adicionar em paralelo com uma instancia bi
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Bi2 GenerateBi2(string value)
        {

            return new Bi2
            {
                Bi2Stamp = value,
                Bostamp = value,
                Alvstamp1 = " ",
                Alvstamp2 = " ",
                Aviado = false,
                Cladrsdesc = " ",
                Cladrsstamp = " ",
                Cladrszona = " ",
                Codpost = " ",
                Contacto = " ",
                //Custototaldif = 0,
                Zona2 = " ",
                //Ecustototaldif = 0,
                EftaxamtA = 0,
                EftaxamtB = 0,
                Email = " ",
                FtaxamtA = 0,
                FtaxamtB = 0,
                Identificacao1 = " ",
                Identificacao2 = " ",
                Local = " ",
                Marcada = false,
                Mcomercial = 0,
                Morada = " ",
                Ousrdata = DateTime.UtcNow,
                Ousrhora = " ",
                Ousrinis = " ",
                Pscmori = " ",
                Pscmoridesc = " ",
                Szzstamp1 = " ",
                Szzstamp2 = " ",
                Telefone = " ",
                Usrdata = DateTime.UtcNow,
                Usrhora = " ",
                Usrinis = " ",
                Zona1 = " ",
                //Custoinddif = 0,
                //Custoinddifperc = 0,
                //Custoindorcamento = 0,
                //Custototaldifperc = 0,
                //Custototalorcamento = 0,
                Descfx = " ",
                Desemb = false,
                //Ecustoinddif = 0,
                //Ecustoindorcamento = 0,
                //Ecustototalorcamento = 0,
                //Emargemdif = 0,
                //Emargemorcamento = 0,
                Eqttaprval = 0,
                Eqttfaltaval = 0,
                Eqttmedidaval = 0,
                Eqttnoaprval = 0,
                Etbrmaisval = 0,
                Etbrmenosval = 0,
                Evalnew = 0,
                Fistamp = " ",
                Fnstamp = " ",
                Foadoc = " ",
                Fodocnome = " ",
                Lobsauto = " ",
                //Margemdif = 0,
                //Margemorcamento = 0,
                Noaprov = 0,
                Noaprov2 = 0,
                Ofcstamp = "  ",
                Ooboano = DateTime.UtcNow.Year,
                Oonmdos = " ",
                Ooobrano = DateTime.UtcNow.Year,
                Ooobranome = " ",

                Origbistamp = " ",
                Percnew = 0,
                Precatstamp = " ",
                Qttadj = 0,
                Qttapr = 0,
                Qttaprval = 0,
                Qttatrib = 0,
                Qttcompra = 0,
                //Qttdif = 0,
                //Qttdifperc = 0,
                Qttenc = 0,
                Qttfalta = 0,
                Qttfaltaval = 0,
                Qttmedida = 0,
                Qttmedidaperc = 0,
                Qttmedidaval = 0,
                Qttnew = 0,
                Qttnew2 = 0,
                Qttnoapr = 0,
                Qttnoaprval = 0,
                // Qttorcamento = 0,
                Qtttbrmais = 0,
                Qtttbrmenos = 0,
                Semserprv = false,
                Tbrmais = 0,
                Tbrmaisval = 0,
                Tbrmenos = 0,
                Tbrmenosval = 0,
                Temfx = false,
                Tkhcodcmb = 0,
                Tkhpmp = 0,
                Tkhposlstamp = " ",
                Usamcomercial = false,
                Valnew = 0
                //
            };
        }
        #endregion

        #endregion

        #region ConvertBo


        #region ConvertVOBoTbBo
        /// <summary>
        /// metodo para converter vo em entidade(vo bo -> bo)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Bo ConvertVoBoTbBo(Vobo value)
        {


            return new Bo
            {
                Bostamp = value.BOstamp,
                Vendedor = value.Vendedor,
                Vendnm = value.Vendnm,
                Nmdos = value.Nmdos,
                Ndos = value.Ndos,
                Obrano = value.Obrano,
                Dataobra = DevolveDataObra(value.Dataobra),
                //Dataobra = Convert.ToDateTime(value.Dataobra),
                Obranome = value.Obranome,
                Nome = value.BoNome,
                Nome2 = value.Nome2,
                No = value.No,
                Estab = value.Estab,
                Obs = value.Obs,
                Statuspda = value.Statuspda,
                Ebo2Tvall = value.Ebo2Tvall,
                Ebo2Tdes1 = value.Ebo2Tdes1,
                Ebo2Tdes2 = value.Ebo2Tdes2,
                EboTotp2 = value.EboTotp2,
                Edescc = value.Edescc,
                Ebo12Bins = value.Ebo12Bins,
                Ebo12Iva = value.Ebo12Iva,
                Ebo22Iva = value.Ebo22Iva,
                Ebo22Bins = value.Ebo22Bins,
                Ebo32Bins = value.Ebo32Bins,
                Ebo32Iva = value.Ebo32Iva,
                Ebo42Bins = value.Ebo42Bins,
                Ebo42Iva = value.Ebo42Iva,
                Ebo52Bins = value.Ebo52Bins,
                Ebo52Iva = value.Ebo52Iva,
                Ebo62Bins = value.Ebo62Bins,
                Ebo62Iva = value.Ebo62Iva,
                Etotaldeb = value.Etotaldeb,
                //campos que nao estao presentes na bd sqlite
                Tipo = "4",
                Datafinal = DateTime.UtcNow,
                Smoe1 = 0,
                Smoe2 = 0,
                Smoe3 = 0,
                Smoe4 = 0,
                Moetotal = 0,
                Sdeb1 = 0,
                Sdeb2 = 0,
                Sdeb3 = 0,
                Sdeb4 = 0,
                Sqtt14 = 0,
                Sqtt13 = 0,
                Sqtt12 = 0,
                Sqtt11 = 0,
                Sqtt24 = 0,
                Sqtt23 = 0,
                Sqtt22 = 0,
                Sqtt21 = 0,
                Vqtt21 = 0,
                Vqtt22 = 0,
                Vqtt23 = 0,
                Vqtt24 = 0,
                Stot1 = 0,
                Stot2 = 0,
                Stot3 = 0,
                Stot4 = 0,
                Boano = DevolveBoAno(value.Dataobra),
                Dataopen = DateTime.UtcNow,
                Datafecho = DateTime.UtcNow,
                Fechada = false,
                Nopat = 0,
                Total = 0,
                Tecnico = 0,
                Tecnnm = " ",
                Nomquina = 0,
                Maquina = " ",
                Marca = " ",
                Serie = " ",
                Zona = " ",
                Trab1 = " ",
                Trab2 = " ",
                Trab3 = " ",
                Trab4 = " ",
                Trab5 = " ",
                Custo = 0,
                Moeda = " ",
                Morada = " ",
                Local = " ",
                Codpost = " ",
                Ultfact = DateTime.UtcNow,
                Period = 0,
                Tabela1 = " ",
                Ncont = " ",
                Logi1 = false,
                Logi2 = false,
                Logi3 = false,
                Logi4 = false,
                Logi5 = false,
                Logi6 = false,
                Logi7 = false,
                Logi8 = false,
                Segmento = " ",
                Impresso = false,
                Userimpresso = " ",
                Fref = " ",
                Ccusto = " ",
                Ncusto = " ",
                Cobranca = " ",
                Infref = false,
                Lifref = false,
                Esdeb1 = 0,
                Esdeb2 = 0,
                Esdeb3 = 0,
                Esdeb4 = 0,
                Evqtt21 = 0,
                Evqtt22 = 0,
                Evqtt23 = 0,
                Evqtt24 = 0,
                Estot1 = 0,
                Estot2 = 0,
                Estot3 = 0,
                Estot4 = 0,
                Etotal = 0,
                Ecusto = 0,
                Bo2Tdesc1 = 0,
                Bo2Tdesc2 = 0,
                Descc = 0,
                Bo1Tvall = 0,
                Bo2Tvall = 0,
                Edi = false,
                Memissao = " ",
                Pastamp = " ",
                Snstamp = " ",
                Mastamp = " ",
                Origem = " ",
                Orinopat = 0,
                Iiva = false,
                Iunit = false,
                Itotais = false,
                Iunitiva = false,
                Itotaisiva = false,
                Site = " ",
                Pnome = " ",
                Pno = 0,
                Cxstamp = " ",
                Cxusername = " ",
                Ssstamp = " ",
                Ssusername = " ",
                Alldescli = false,
                Alldesfor = false,
                Series = " ",
                Series2 = " ",
                Quarto = " ",
                Ocupacao = 0,
                Tabela2 = " ",
                Obstab2 = " ",
                Iemail = " ",
                Inome = " ",
                Situacao = 0,
                Lang = " ",
                Ean = " ",
                Iecacodisen = " ",
                Boclose = false,
                Dtclose = DateTime.UtcNow,
                Tpstamp = " ",
                Tpdesc = " ",
                Emconf = false,
                Aprovado = false,
                Ousrinis = " ",
                Ousrdata = DateTime.UtcNow,
                Ousrhora = DateTime.UtcNow.Hour.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Minute.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Second.ToString(CultureInfo.InvariantCulture),
                Usrdata = DateTime.UtcNow,
                Usrhora = DateTime.UtcNow.Hour.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Minute.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Second.ToString(CultureInfo.InvariantCulture),
                Marcada = false,
                Bo11Bins = 0,
                Bo11Iva = 0,
                Bo12Bins = 0,
                Bo12Iva = 0,
                Bo21Bins = 0,
                Bo21Iva = 0,
                Usrinis = DateTime.UtcNow.Hour.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Minute.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Second.ToString(CultureInfo.InvariantCulture),
                Bo22Bins = 0,
                Bo22Iva = 0,
                Bo31Bins = 0,
                Bo31Iva = 0,
                Bo32Bins = 0,
                Bo32Iva = 0,
                Bo41Bins = 0,
                Bo41Iva = 0,
                Bo42Bins = 0,
                Bo42Iva = 0,
                Bo51Bins = 0,
                Bo51Iva = 0,
                Bo52Bins = 0,
                Bo52Iva = 0,
                Bo61Bins = 0,
                Bo61Iva = 0,
                Bo62Bins = 0,
                Bo62Iva = 0,
                BoTotp1 = 0,
                BoTotp2 = 0,
                Ebo11Bins = 0,
                Ebo11Iva = 0,
                Ebo21Bins = 0,
                Ebo21Iva = 0,
                Ebo31Bins = 0,
                Ebo31Iva = 0,
                Ebo41Bins = 0,
                Ebo41Iva = 0,
                Ebo51Bins = 0,
                Ebo51Iva = 0,
                Ebo61Bins = 0,
                Ebo61Iva = 0,
                Ebo1Tvall = 0,
                EboTotp1 = 0

                //
            };

        }




        #endregion
        #region ConvertRemoteBOTbBo
        public Bo ConvertRemoteBoToTb(RemoteBo value)
        {
            return new Bo
            {
                Bostamp = value.BOstamp,
                Vendedor = value.Vendedor,
                // nome do vendedor fora figo Vendnm = value.Vendnm,
                // o mesmo para o nome do dossierNmdos = value.Nmdos,
                Ndos = value.Ndos,
                Obrano = value.Obrano,
                Dataobra = DevolveDataObra(value.Dataobra),
                //Dataobra = Convert.ToDateTime(value.Dataobra),
                //Obranome = value.Obranome,
                Nome = value.BoNome,
                //Nome2 = value.Nome2,
                No = value.No,
                Estab = value.Estab,
                //Obs = value.Obs,
                Statuspda = value.Statuspda,
                Ebo2Tvall = value.Ebo2Tvall,
                Ebo2Tdes1 = value.Ebo2Tdes1,
                Ebo2Tdes2 = value.Ebo2Tdes2,
                EboTotp2 = value.EboTotp2,
                Edescc = value.Edescc,
                Ebo12Bins = value.Ebo12Bins,
                Ebo12Iva = value.Ebo12Iva,
                Ebo22Iva = value.Ebo22Iva,
                Ebo22Bins = value.Ebo22Bins,
                Ebo32Bins = value.Ebo32Bins,
                Ebo32Iva = value.Ebo32Iva,
                Ebo42Bins = value.Ebo42Bins,
                Ebo42Iva = value.Ebo42Iva,
                Ebo52Bins = value.Ebo52Bins,
                Ebo52Iva = value.Ebo52Iva,
                Ebo62Bins = value.Ebo62Bins,
                Ebo62Iva = value.Ebo62Iva,
                Etotaldeb = value.Etotaldeb,
                //campos que nao estao presentes na bd sqlite
                Tipo = "4",
                Datafinal = DateTime.UtcNow,
                Smoe1 = 0,
                Smoe2 = 0,
                Smoe3 = 0,
                Smoe4 = 0,
                Moetotal = 0,
                Sdeb1 = 0,
                Sdeb2 = 0,
                Sdeb3 = 0,
                Sdeb4 = 0,
                Sqtt14 = 0,
                Sqtt13 = 0,
                Sqtt12 = 0,
                Sqtt11 = 0,
                Sqtt24 = 0,
                Sqtt23 = 0,
                Sqtt22 = 0,
                Sqtt21 = 0,
                Vqtt21 = 0,
                Vqtt22 = 0,
                Vqtt23 = 0,
                Vqtt24 = 0,
                Stot1 = 0,
                Stot2 = 0,
                Stot3 = 0,
                Stot4 = 0,
                Boano = DevolveBoAno(value.Dataobra),
                Dataopen = DateTime.UtcNow,
                Datafecho = DateTime.UtcNow,
                Fechada = false,
                Nopat = 0,
                Total = 0,
                Tecnico = 0,
                Tecnnm = " ",
                Nomquina = 0,
                Maquina = " ",
                Marca = " ",
                Serie = " ",
                Zona = " ",
                Trab1 = " ",
                Trab2 = " ",
                Trab3 = " ",
                Trab4 = " ",
                Trab5 = " ",
                Custo = 0,
                Moeda = " ",
                Morada = " ",
                Local = " ",
                Codpost = " ",
                Ultfact = DateTime.UtcNow,
                Period = 0,
                Tabela1 = " ",
                Ncont = " ",
                Logi1 = false,
                Logi2 = false,
                Logi3 = false,
                Logi4 = false,
                Logi5 = false,
                Logi6 = false,
                Logi7 = false,
                Logi8 = false,
                Segmento = " ",
                Impresso = false,
                Userimpresso = " ",
                Fref = " ",
                Ccusto = " ",
                Ncusto = " ",
                Cobranca = " ",
                Infref = false,
                Lifref = false,
                Esdeb1 = 0,
                Esdeb2 = 0,
                Esdeb3 = 0,
                Esdeb4 = 0,
                Evqtt21 = 0,
                Evqtt22 = 0,
                Evqtt23 = 0,
                Evqtt24 = 0,
                Estot1 = 0,
                Estot2 = 0,
                Estot3 = 0,
                Estot4 = 0,
                Etotal = 0,
                Ecusto = 0,
                Bo2Tdesc1 = 0,
                Bo2Tdesc2 = 0,
                Descc = 0,
                Bo1Tvall = 0,
                Bo2Tvall = 0,
                Edi = false,
                Memissao = " ",
                Pastamp = " ",
                Snstamp = " ",
                Mastamp = " ",
                Origem = " ",
                Orinopat = 0,
                Iiva = false,
                Iunit = false,
                Itotais = false,
                Iunitiva = false,
                Itotaisiva = false,
                Site = " ",
                Pnome = " ",
                Pno = 0,
                Cxstamp = " ",
                Cxusername = " ",
                Ssstamp = " ",
                Ssusername = " ",
                Alldescli = false,
                Alldesfor = false,
                Series = " ",
                Series2 = " ",
                Quarto = " ",
                Ocupacao = 0,
                Tabela2 = " ",
                Obstab2 = " ",
                Iemail = " ",
                Inome = " ",
                Situacao = 0,
                Lang = " ",
                Ean = " ",
                Iecacodisen = " ",
                Boclose = false,
                Dtclose = DateTime.UtcNow,
                Tpstamp = " ",
                Tpdesc = " ",
                Emconf = false,
                Aprovado = false,
                Ousrinis = " ",
                Ousrdata = DateTime.UtcNow,
                Ousrhora = DateTime.UtcNow.Hour.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Minute.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Second.ToString(CultureInfo.InvariantCulture),
                Usrdata = DateTime.UtcNow,
                Usrhora = DateTime.UtcNow.Hour.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Minute.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Second.ToString(CultureInfo.InvariantCulture),
                Marcada = false,
                Bo11Bins = 0,
                Bo11Iva = 0,
                Bo12Bins = 0,
                Bo12Iva = 0,
                Bo21Bins = 0,
                Bo21Iva = 0,
                Usrinis = DateTime.UtcNow.Hour.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Minute.ToString(CultureInfo.InvariantCulture) + DateTime.UtcNow.Second.ToString(CultureInfo.InvariantCulture),
                Bo22Bins = 0,
                Bo22Iva = 0,
                Bo31Bins = 0,
                Bo31Iva = 0,
                Bo32Bins = 0,
                Bo32Iva = 0,
                Bo41Bins = 0,
                Bo41Iva = 0,
                Bo42Bins = 0,
                Bo42Iva = 0,
                Bo51Bins = 0,
                Bo51Iva = 0,
                Bo52Bins = 0,
                Bo52Iva = 0,
                Bo61Bins = 0,
                Bo61Iva = 0,
                Bo62Bins = 0,
                Bo62Iva = 0,
                BoTotp1 = 0,
                BoTotp2 = 0,
                Ebo11Bins = 0,
                Ebo11Iva = 0,
                Ebo21Bins = 0,
                Ebo21Iva = 0,
                Ebo31Bins = 0,
                Ebo31Iva = 0,
                Ebo41Bins = 0,
                Ebo41Iva = 0,
                Ebo51Bins = 0,
                Ebo51Iva = 0,
                Ebo61Bins = 0,
                Ebo61Iva = 0,
                Ebo1Tvall = 0,
                EboTotp1 = 0,
                Totaldeb = 0,
                Nome2 = "",
                Vendnm = "",
                Obs = "",
                Nmdos = "",
                Obranome = ""

                //
            };
        }
        #endregion
        #endregion

        #region ConvertBO2


        #region GenerateBo2
        /// <summary>
        /// metodo para gerar uma nova entidade bo2
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Bo2 GenerateBo2(string value)
        {
            return new Bo2
            {

                Bo2Stamp = value,
                Bo71Bins = 0,
                Bo71Iva = 0,
                Adjbostamp = " ",
                Adjudicado = false,
                Alvstamp1 = value,
                Alvstamp2 = value,
                Ar2Mazem = 0,
                Area = " ",
                Armazem = 0,
                Assinatura = " ",
                Autobostamp = value,
                Autono = 0,
                Autoper = 0,
                Autos = false,
                Autotipo = 0,
                Bo72Bins = 0,
                Bo72Iva = 0,
                Bo81Bins = 0,
                Bo81Iva = 0,
                Bo82Bins = 0,
                Bo82Iva = 0,
                Bo91Bins = 0,
                Bo91Iva = 0,
                Bo92Bins = 0,
                Bo92Iva = 0,
                Calistamp = value,
                Cambio = 0,
                Cambiofixo = false,
                Cladrsdesc = " ",
                Cladrsstamp = value,
                Cladrszona = " ",
                Codpost = " ",
                Contacto = " ",
                Crpstamp = " ",
                Custototaldif = 0,
                Custototalorc = 0,
                Custototalreorc = 0,
                Descnegocio = " ",
                Descobra = " ",
                Diasate = 0,
                Diasde = 0,
                Dpedidopv = " ",
                Dprocesso = " ",
                Ebo71Bins = 0,
                Ebo71Iva = 0,
                Ebo72Bins = 0,
                Ebo72Iva = 0,
                Ebo81Bins = 0,
                Ebo81Iva = 0,
                Ebo82Bins = 0,
                Ebo82Iva = 0,
                Ebo91Bins = 0,
                Ebo91Iva = 0,
                Ebo92Bins = 0,
                Ebo92Iva = 0,
                Ecustototaldif = 0,
                Ecustototalorc = 0,
                Ecustototalreorc = 0,
                EftaxamtA = 0,
                EftaxamtB = 0,
                Email = " ",
                Emargemtotaldif = 0,
                Emargemtotalorc = 0,
                Emargemtotalreorc = 0,
                Encm = " ",
                Encmdesc = " ",
                Etotalciva = 0,
                Etotiva = 0,
                Ettecoval = 0,
                Ettecoval2 = 0,
                Ettieca = 0,
                Excm = 0,
                Excmdesc = " ",
                Exportado = false,
                FtaxamtA = 0,
                FtaxamtB = 0,
                Horasl = " ",
                Identificacao1 = " ",
                Identificacao2 = " ",
                Iectisento = false,
                Local = " ",
                Marcada = false,
                Margemorcperc = 0,
                Margemreorcperc = 0,
                Margemtotaldif = 0,
                Margemtotalorc = 0,
                Margemtotalreorc = 0,
                Mcomercial = 0,
                Mensaldia = 0,
                Morada = " ",
                Mtotalciva = 0,
                Mtotiva = 0,
                Mttieca = 0,
                Ncin = false,
                Ncout = false,
                Ndosmanual = " ",
                Negocio = " ",
                Ngstamp = " ",
                Ngstatus = " ",
                Nocts = 0,
                Nomects = " ",
                Nopkng = 0,
                Ntcm = 0,
                Obranomanual = 0,
                Obranoorcamento = 0,
                Orcamento = false,
                Ousrdata = DateTime.UtcNow,
                Ousrhora = " ",
                Ousrinis = " ",
                Pdtipo = 0,
                Planeamento = false,
                Processo = " ",
                Pscm = " ",
                Pscmdesc = " ",
                Pscmori = " ",
                Pscmoridesc = " ",
                Ptcm = " ",
                Ptcmdesc = " ",
                Reorcamento = false,
                Stamporcamento = " ",
                Subproc = " ",
                Sujrvp = false,
                Szzstamp1 = " ",
                Szzstamp2 = " ",
                Tbrsemmed = false,
                Telefone = " ",
                Tipoobra = " ",
                Tkhcarr = " ",
                Tkhdata = DateTime.UtcNow,
                Tkhdid = 0,
                Tkhhora = " ",
                Tkhid = " ",
                Tkhlpnt = 0,
                Tkhlref = " ",
                Tkhltyp = 0,
                Tkhodo = 0,
                Tkhopid = " ",
                Tkhpan = " ",
                Tkhposcstamp = " ",
                Tkhref = " ",
                Tkhshf = 0,
                Tkhsttnr = " ",
                Tkhtyp = 0,
                Totalciva = 0,
                Totiva = 0,
                Ttecoval = 0,
                Ttecoval2 = 0,
                Ttieca = 0,
                Usaintra = false,
                Usrdata = DateTime.UtcNow,
                Usrhora = " ",
                Usrinis = " ",
                Vencimento = 0,
                Versaochave = " ",
                Versaocrono = " ",
                Versaorcamento = " ",
                Xpddata = DateTime.UtcNow,
                Xpdhora = " ",
                Xpdviatura = " ",
                Zncm = 0,
                Znregiao = " ",
                Zona1 = " ",
                Zona2 = " "


                //
            };

        }
        #endregion

        #endregion

        #region ConvertTaxasIVA

        #region ConvertTbTaxasIvaVoTaxasIVA
        /// <summary>
        /// metodo para devolver devolver uma vo com base na entidade taxas iva
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private VOtaxasIva ConvertTbTaxasIvaVoTaxasIva(Taxasiva value)
        {
            return new VOtaxasIva
            {
                TaxasIvAstamp = value.Taxasivastamp,
                Descricao = value.Codigo.ToString(CultureInfo.InvariantCulture),
                Valor = value.Taxa.ToString(CultureInfo.InvariantCulture)
            };
        }
        #endregion



        #endregion

        #region Convertst

        #region ConvertTbstVost
        /// <summary>
        /// metodo para converter entidade em vo para o cliente st
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private VOst ConvertTbStVoSt(St value)
        {
            return new VOst
            {
                Ststamp = value.Ststamp,
                Tabiva = value.Tabiva,
                Bloqueado = Convert.ToInt32(value.Bloqueado),
                Codigo = value.Codigo,
                Forref = value.Forref,
                Ref = value.StReferencia,
                Design = value.Design,
                Familia = value.Familia,
                Epv1 = value.Epv1,
                Epv2 = value.Epv2,
                Epv3 = value.Epv3,
                Epv4 = value.Epv4,
                Epv5 = value.Epv5,
                Statuspda = value.Statuspda
            };
        }
        #endregion


        #endregion

        #region ConvertCL
        #region ConvertTbClVOCL
        /// <summary>
        /// metodo para converter entidade em vo (cl)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private Vocl ConvertTbClVoCl(Cl value)
        {
            return new Vocl
            {
                Clstamp = value.Clstamp,
                Preco = Convert.ToInt32(value.Preco),
                Desconto = value.Desconto,
                Nocredit = Convert.ToInt32(value.Nocredit),
                No = Convert.ToInt32(value.No),
                Estab = Convert.ToInt32(value.Estab),
                Nome = value.Nome,
                Abreviatura = value.Nome2,
                Morada = value.Morada,
                Local = value.Local,
                Codpostal = value.Codpost,
                Obs = value.Obs,
                Tlmvl = value.Tlmvl,
                Telefone = value.Telefone,
                Email = value.Email,
                Esaldo = value.Esaldo,
                Statuspda = value.Statuspda,
                Vendedor = Convert.ToInt32(value.Vendedor),
                Vendnm = value.Vendnm,
                Ncont = value.Ncont,
                Tipo = value.Tipo,
                Contacto = value.Contacto,
                Tabiva = Convert.ToInt32(value.Tabiva),

            };
        }
        #endregion



        #endregion

        #region ConvertCC
        #region ConvertTBCCVOCC
        /// <summary>
        /// metodo para converter entidade em vo(cc)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private Vocc ConvertTbCcvoCc(Cc value)
        {
            return new Vocc
            {
                Ccstamp = value.Ccstamp,
                Cmdesc = value.Cmdesc,
                Nrdoc = value.Nrdoc,
                Nome = value.Nome,
                No = Convert.ToInt32(value.No),
                Estab = value.Estab,
                Edeb = value.Edeb,
                Edebf = value.Edebf,
                Ecred = value.Ecred,
                Ecredf = value.Ecredf,
                Datalc = value.Datalc.ToString("dd-MM-yyyy HH:mm tt"),
                Dataven = value.Dataven.ToString("dd-MM-yyyy HH:mm tt"),
                Evalre = value.Valre,
                Evtmp = value.Evtmp,
                Evirs = value.Evirs,
                Eivav1 = value.Eivav1,
                Eivav2 = value.Eivav2,
                Eivav3 = value.Eivav3,
                Eivav4 = value.Eivav4,
                Eivav5 = value.Eivav5,
                Eivav6 = value.Eivav6,
                Eivav7 = value.Eivav7,
                Eivav8 = value.Eivav8,
                Eivav9 = value.Eivav9,
                Moeda = value.Moeda,
                Recibado = Convert.ToInt32(value.Recibado),
                Origem = value.Origem,
                Cm = value.Cm
                // ver trace para este campo
                //inspda = value.tbccinspda
                //
            };
        }
        #endregion


        #endregion
        #region ConvertStObs
/*
        /// <summary>
        /// convert para a vo para o cliente a entidade da base dados em vo cliente(stobs)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private VoStObs ConverTbStobsVoStobs(Stobs value)
        {
            return new VoStObs
                       {
                           Stobs = value.StobsObs,
                           StObsRef = value.StobsRef
                       };
        }
*/
        #endregion
        
        #region DataConverters
        private static bool ConvertDecimaltoBool(decimal ivaincl)
        {
            var tmp = Convert.ToInt32(ivaincl);
            return Convert.ToBoolean(tmp);

        }
        public string ConvertFilterSt(string value)
        {
            var tmpStrBuilder = new StringBuilder(value);

            tmpStrBuilder.Replace("<>  1", "<> 'true'");
            tmpStrBuilder.Replace("<>  0", "<> 'false'");
            //tmpStrBuilder.Replace("  <>  ", " NOT LIKE");
            var result = tmpStrBuilder.ToString();
            tmpStrBuilder.Clear();
            return result;
        }
        private bool ConverteParamsSt(string value)
        {

            var tmpStr = value[value.Length - 1];
            return tmpStr == '1';

            //return value=="1";
        }
        private static decimal ConverteParamsStDec(string value)
        {
            decimal x = 0;
            var valor = value.Substring(1);
            var tparseresult = decimal.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out x);

            return tparseresult ? x : 0;
        }
        private static int ConverteParamsInt(string value)
        {
            var valor = 0;
            var tparseresult = int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out valor);
            return tparseresult ? valor : 0;
        }


        private static decimal DevolveBoAno(string value)
        {
            var tmpData = DateTime.ParseExact(value, "yyyy-MM-dd H:mm:ss", CultureInfo.InvariantCulture);


            return tmpData.Year;
        }

        private static DateTime DevolveDataObra(string value)
        {
            //var resultado = DateTime.UtcNow;

            return DateTime.ParseExact(value, "yyyy-MM-dd H:mm:ss", CultureInfo.InvariantCulture);
        }
        #endregion
        #region ConvertQuery
        public object[] ConvertDataQuery(string[] value)
        {
            var i = 1;
            var x = 0;
            var larr = value.Length;
            var resultado = new object[larr - 1];
            while (i < larr)
            {

                var tmpItem = value[i];
                if (tmpItem.StartsWith("it"))
                //if (tmpItem.Length==1)
                {
                    //bool flagvalue;

                    resultado[x] = ConverteParamsInt(tmpItem.Substring(1));
                    //StParams[x]=Convert.ToBoolean(tmpItem);
                }
                else if (tmpItem.StartsWith("bol"))
                {
                    resultado[x] = ConverteParamsSt(tmpItem);
                }
                else if (tmpItem.StartsWith("ch"))
                {

                    var valorStr = tmpItem.Substring(2);
                    resultado[x] = valorStr;
                }
                else if (tmpItem.StartsWith("r"))
                {
                    resultado[x] = ConverteParamsStDec(tmpItem);
                }
                x++;
                i++;
            }
            return resultado;
        }
        #endregion


        
    }
}
