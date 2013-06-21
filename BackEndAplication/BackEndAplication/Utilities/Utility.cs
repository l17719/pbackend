using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows;
using BackEndAplication.Events;
using BackEndAplication.Models;
using Caliburn.Micro;
using Microsoft.Web.Administration;
using Microsoft.Win32;

//using Configuration = System.Configuration.Configuration;

namespace BackEndAplication.Utilities
{
    public class Utility
    {
        #region Properties

        private static Utility _instance;

/*
        private static readonly string Path = System.IO.Path.Combine(Environment.CurrentDirectory,
                                                                     "BackEndAplication.exe");
*/

        //private static EntityConnectionStringBuilder TmpPhCconnection { get; set; }

        private string TmpPhCconnection { get; set; }

        private static string TmpIfphcConnection { get; set; }


        private Configuracao TmpConfig { get; set; }

        #endregion

        #region ctor

        public static Utility GetInstance()
        {
            return _instance ?? (_instance = new Utility());
        }

        #endregion

        #region listasWebServer

        public BindableCollection<string> GetApplicationPoolEntries()
        {
            var resultado = new List<string>();
            try
            {
                var appPools = new DirectoryEntry("IIS://localhost/W3SVC/AppPools").Children;
                resultado = (from DirectoryEntry appPool in appPools select appPool.Name).ToList();
                ((IDisposable)appPools).Dispose();
            }
            catch (Exception ex)
            {
                //EventAggregationProvider.Aggregator.Publish<EventoError>(new EventoError(ex.Message, ex.Source));
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }

            return new BindableCollection<string>(resultado);
        }


        public BindableCollection<string> GetWebIisWebSites()
        {
            var resultado = new List<string>();
            try
            {
                var iisEntries = new DirectoryEntry("IIS://localhost/W3SVC");
                resultado = (from DirectoryEntry s in iisEntries.Children.OfType<DirectoryEntry>()
                             where s.SchemaClassName == "IIsWebServer"
                             select s.Properties["ServerComment"].Value.ToString()).ToList();
                resultado.Add("Criar WebSite");


                iisEntries.Close();

            }
            catch (Exception ex)
            {
                //EventAggregationProvider.Aggregator.Publish<EventoError>(new EventoError(ex.Message, ex.Source));
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }

            return new BindableCollection<string>(resultado);
        }

        #endregion

        #region CriaDadosSite

        /// <summary>
        /// cria o web site no iis com os dados fornecidos
        /// </summary>
        /// <param name="valueName"></param>
        /// <param name="valueRootFolder"></param>
        /// <param name="port"></param>
        /// <param name="valueVDirName"></param>
        /// <returns></returns>

        #region CriaSite
        public void CreateWebSiteWithDir(string valueName, string valueRootFolder, string port, string valueVDirName)
        {
            try
            {
                var resultadoListaSites = GetWebIisWebSites();

                if (resultadoListaSites.Any(v => v == valueName))
                {
                    EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                                  "O site: " + valueName + " ja existe"));
                }

                if (!Directory.Exists(valueRootFolder + valueName))
                {
                    Directory.CreateDirectory(valueRootFolder + valueName);
                }

                var root = new DirectoryEntry("IIS://localhost/W3SVC");

                var siteId = DevolveIdSite(root);
                siteId++;

                var site = (DirectoryEntry)root.Invoke("Create", "IIsWebServer", siteId);

                site.Invoke("Put", "ServerComment", valueName);
                site.Invoke("Put", "KeyType", "IIsWebServer");
                site.Invoke("Put", "ServerBindings", ":" + port + ":");
                site.Invoke("Put", "ServerState", 2);
                site.Invoke("Put", "FrontPageWeb", 1);
                site.Invoke("Put", "ServerAutoStart", 1);
                site.Invoke("Put", "ServerSize", 1);
                site.Invoke("SetInfo");


                var siteVdir = site.Children.Add("Root", "IISWebVirtualDir");

                // check application
                var listapools = GetApplicationPoolEntries();
                if (listapools.Any(v => v == "IFEBAPool"))
                {
                    siteVdir.Invoke("appCreate3", 0, "IFEBAPool", true);
                }
                else
                {
                    CreateAppPool("IFEBAPool");
                }
                //

                siteVdir.Properties["AppIsolated"][0] = 2;
                siteVdir.Properties["Path"][0] = valueRootFolder;
                siteVdir.Properties["AccessFlags"][0] = 513;
                siteVdir.Properties["AspEnableParentPaths"][0] = true;
                siteVdir.Properties["AppFriendlyName"][0] = valueName;
                siteVdir.Properties["FrontPageWeb"][0] = 1;
                siteVdir.Properties["AppRoot"][0] = "LM/W3SVC/" + siteId + "/Root";
                siteVdir.Properties["AppFriendlyName"][0] = "Root";
                siteVdir.Properties["AspSessionTimeout"][0] = "240";
                //siteVdir.Properties["AuthFlags"].Value = 4;//integrity windows Authentication checked


                siteVdir.CommitChanges();
                siteVdir.Invoke("AppDelete");
                siteVdir.Invoke("AppCreate", true);
                siteVdir.Invoke("AppEnable");

                site.CommitChanges();
                root.Close();
                siteVdir.Close();
                site.Close();
            }
            catch (Exception ex)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
                //EventAggregationProvider.EventAggregate.Publish<EventoError>(new EventoError(ex.Message, ex.Source));
            }
        }

        #region CreateSiteAdminDLL

        public void CreateWebSiteWithAdmin(string valueName, string valueRootFolder, string port)
        {
            BindableCollection<string> resultadoListaSites = GetWebIisWebSites();

            if (resultadoListaSites.Any(v => v == valueName))
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                              "O site: " + valueName + " ja existe"));
            }
            string porta = "*:" + port + ":";
            string sitepath = valueRootFolder + valueName;
            if (!Directory.Exists(sitepath))
            {
                Directory.CreateDirectory(sitepath);
            }
            using (var server = new ServerManager())
            {
                var sitetoAdd = server.Sites.Add(valueName, "http", porta, sitepath);
                sitetoAdd.TraceFailedRequestsLogging.Enabled = true;
                sitetoAdd.TraceFailedRequestsLogging.Directory = "C:\\inetpub\\Log" + valueName + "\\" + valueName;
                var resultado = server.ApplicationPools.Any(t => t.Name == "IFEBAPool");

                if (resultado == false)
                {
                    var pool = server.ApplicationPools.Add("IFEBAPool");
                    pool.ManagedRuntimeVersion = "v4.0";
                    pool.ManagedPipelineMode = ManagedPipelineMode.Integrated;
                }

                server.Sites[valueName].Applications[0].ApplicationPoolName = "IFEBAPool";
                sitetoAdd.ServerAutoStart = true;
                server.CommitChanges();
            }
        }

        #endregion

        #endregion

        #region CriaApplicationPool

        private static void CreateAppPool(string value)
        {
            try
            {
                var apppools = new DirectoryEntry("IIS://localhost/W3SVC/AppPools");
                var newpool = apppools.Children.Add(value, "IIsApplicationPool");
                newpool.Properties["managedRuntimeVersion"].Value = "v4.0";
                newpool.CommitChanges();

                apppools.Dispose();
                newpool.Dispose();

            }
            catch (Exception ex)
            {
                //EventAggregationProvider.EventAggregate.Publish<EventoError>(new EventoError(ex.Message, ex.Source));
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));

            }
        }

        #endregion

        #region DevolveIDSite

        private static int DevolveIdSite(DirectoryEntry value)
        {
            var resultado = 0;
            foreach ( var de in value.Children.Cast<DirectoryEntry>().Where(de => de.SchemaClassName == "IIsWebServer"))
            {
                resultado = Convert.ToInt32(de.Name);
            }
            return resultado;
        }

        #endregion

        #region verificaVersaoIIS

        public string GetIisVersion()
        {
            var osVersion = Environment.OSVersion;
            var platformId = (int)osVersion.Platform;
            var majorVersion = osVersion.Version.Major;
            var minorVersion = osVersion.Version.Minor;
            var servicePack = osVersion.ServicePack;
            var osList = new Dictionary<int, string>
                             {
                                 {0, "Windows 3.1"},
                                 {140, "Windows 95"},
                                 {1410, "Windows 98"},
                                 {1490, "Windows ME"},
                                 {2351, "Windows NT 3.51"},
                                 {240, "Windows 4.0"},
                                 {250, "Windows 2000"},
                                 {251, "Windows XP"},
                                 {252, "Windows 2003"},
                                 {260, "Windows Vista/Server 2008"},
                                 {261, "Windows 7"},
                                 {-1, "Unknown"}
                             };

            var idVersion = int.Parse(string.Format("{0}{1}{2}", platformId, majorVersion, minorVersion));
            string outValue;
            return osList.TryGetValue(idVersion, out outValue) ? string.Format("{0}{1}", outValue, servicePack) : osList[-1];
        }

        #endregion

        #region InformacaoWebServer

        public bool CheckAppPoolWithAdmin()
        {
            using (var server = new ServerManager())
            {
                var applicationPoolCol = server.ApplicationPools;
                return applicationPoolCol.Any(entry => entry.Name == "ASP.NET v4.0");
            }
        }

        public bool CheckAppPoolWithDir()
        {
            bool resultado;
            var dir = new DirectoryEntry("IIS://localhost/W3SVC/AppPools").Children;
            resultado= dir.Cast<DirectoryEntry>().Any(entry => entry.Name == "ASP.NET v4.0");
            ((IDisposable)dir).Dispose();
            return resultado;
        }


        #endregion

        

        #region ConfigData

        #region GeneralConfig

        private static ElementosConfiguracao GetConfigData()
        {
            try
            {
                // var config = ConfigurationManager.OpenExeConfiguration(Path);
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var oConfiguration = config.GetSection("ConfigInfo");
                var tmpData = new ElementosConfiguracao();

                if (!oConfiguration.SectionInformation.IsProtected)
                {
                    if (!oConfiguration.SectionInformation.IsLocked)
                    {
                        oConfiguration.SectionInformation.UnprotectSection();
                        tmpData = oConfiguration as ElementosConfiguracao;
                    }
                }
                return tmpData;
            }
            catch (Exception ex)
            {
                //EventAggregationProvider.Aggregator.Publish<EventoBackend>(new EventoBackend(EventoTipo.Erro, ex.Message));
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }


            return null;
        }

        public Configuracao LoadConfigData()
        {
            if (TmpConfig != null)
            {
                return TmpConfig;
            }
            var tmpConfig = GetConfigData();
            TmpConfig = new Configuracao
                            {
                                ConfigOk = tmpConfig.ConfigData.DadosConfiguracaoConfigOk,
                                WebConfigurationOk = tmpConfig.ConfigData.DadosConfiguracaoServidorOk,
                                SQLConfigurationOk = tmpConfig.ConfigData.DadosConfiguracaoSQLServer,
                                IsRegistered = tmpConfig.ConfigData.DadosConfiguracaoRegistoOk,
                                IsValid = tmpConfig.ConfigData.DadosConfiguracaoLicencaValida,
                                MailCliente = tmpConfig.ConfigData.DadosConfiguracaoMailCliente,
                                Serial = tmpConfig.ConfigData.DadosConfiguracaoSerial,
                                NomeSite = tmpConfig.ConfigData.DadosConfiguracaoNomeSite,
                                NomeApplicationPool = tmpConfig.ConfigData.DadosConfiguracaoNomeAppPool,
                                NomeVirtualDir = tmpConfig.ConfigData.DadosConfiguracaoNomeVDir,
                                InstalacaoServico = tmpConfig.ConfigData.DadosConfiguracaoServico,
                            };


            return TmpConfig;
        }


        private static void GuardaConfiguracao(ElementosConfiguracao value, bool valueEncrypt)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //var config = ConfigurationManager.OpenExeConfiguration(Path);
                var oConfiguration = config.GetSection("ConfigInfo");
                if (!oConfiguration.SectionInformation.IsProtected)
                {
                    if (!oConfiguration.SectionInformation.IsLocked)
                    {
                        config.Sections.Remove("ConfigInfo");
                        config.Sections.Add("ConfigInfo", value);
                        // oConfiguration = value;
                        if (valueEncrypt)
                        {
                            oConfiguration.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
                        }


                        //config.Sections.Add(value.Name,value);

                        //oConfiguration.SectionInformation.ForceSave = true;
                        // config.Save(ConfigurationSaveMode.Modified);
                        config.Save(ConfigurationSaveMode.Modified, true);
                        ConfigurationManager.RefreshSection("ConfigInfo");
                    }
                }
            }
            catch (Exception ex)
            {
                //EventAggregationProvider.Aggregator.Publish<EventoBackend>(new EventoBackend(EventoTipo.Erro, ex.Message));
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }
        }


        public void SaveConfig(Configuracao value, bool encryptData = false)
        {
            var elemento = new ElementoConfiguracao
                               {
                                   DadosConfiguracaoConfigOk = value.ConfigOk,
                                   DadosConfiguracaoServidorOk = value.WebConfigurationOk,
                                   DadosConfiguracaoSQLServer = value.SQLConfigurationOk,
                                   DadosConfiguracaoRegistoOk = value.IsRegistered,
                                   DadosConfiguracaoLicencaValida = value.IsValid,
                                   DadosConfiguracaoMailCliente = value.MailCliente,
                                   DadosConfiguracaoSerial = value.Serial,
                                   //DadosConfiguracaoNomeDbphc = value.PhcdbName,
                                   //DadosConfiguracaoSQLPassPhc = value.PhcdbUserPwd,
                                   //DadosConfiguracaoSQLUserNamePhc = value.PhcdbuSer,
                                   DadosConfiguracaoNomeSite = value.NomeSite,
                                   DadosConfiguracaoNomeAppPool = value.NomeApplicationPool,
                                   DadosConfiguracaoNomeVDir = value.NomeVirtualDir,
                                   DadosConfiguracaoServico = value.InstalacaoServico
                               };

            var elementosConfiguracao = new ElementosConfiguracao
                                            {
                                                Name = "Dados",
                                                ConfigData = elemento
                                            };


            GuardaConfiguracao(elementosConfiguracao, encryptData);
        }

        #endregion

        #region ConnectionStringData

        #region propertyPHCCOnnector

        public string GetPhcConnection()
        {
            if (string.IsNullOrEmpty(TmpPhCconnection))
            {
                TmpPhCconnection = GetSqlConfigconn();
            }
            return TmpPhCconnection;
        }

        //public EntityConnectionStringBuilder GetPhcConnection()
        //{
        //    if (TmpPhCconnection != null)
        //    {
        //        return TmpPhCconnection;
        //    }
        //    TmpPhCconnection = GetSqlConfigData("PHCDATA");
        //    return TmpIfphcConnection;
        //}

        #endregion

        #region propertyIFConnector
        // passa para string nao entityconnection
        /// <summary>
        /// metodo para inicializar a conneccao ifelse
        /// </summary>
        /// <returns></returns>
        public string GetIfConnection()
        {
            if (TmpIfphcConnection != null)
            {
                return TmpIfphcConnection;
            }
            TmpIfphcConnection = GetSqlConfigData("DbTerminalContext");
            return TmpIfphcConnection;
        }

        #endregion

        #region ObterConnectionString

        /// <summary>
        /// metodo para obter a configuracao da base dados do ficheiro app.config
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private string GetSqlConfigData(string value)
        {
            var resultado = "";
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connString = config.ConnectionStrings.ConnectionStrings[value].ConnectionString;

                resultado = connString;

            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            return resultado;
        }


        private static string GetSqlConfigconn()
        {
            var resultado = "";
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                resultado = config.ConnectionStrings.ConnectionStrings["PHCDATA"].ConnectionString;
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            return resultado;
        }

        #endregion

        #region SaveConnectionString

        /// <summary>
        /// metodo para guardar a conneccao da base dados
        /// </summary>
        /// <param name="valueConn"></param>
        /// <param name="valueServerName"></param>
        /// <param name="valueCatalog"></param>
        /// <param name="valueTipoAuth"></param>
        /// <param name="valueUser"></param>
        /// <param name="valuePwd"></param>
        public void SaveConfigData(string valueConn, string valueServerName, string valueCatalog, string valueTipoAuth,
                                   string valueUser, string valuePwd)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);


                string connstring;
                ConnectionStringSettings cSSettings;
                if (valueTipoAuth == "localUser")
                {
                    //connstring = "Data Source=" + valueServerName +"\"+";Initial Catalog=" + valueCatalog +
                    //                 ";Trusted_Connection=Yes; MultipleActiveResultSets=True";
                    //connstring = "Data Source=localhost\" + valueServerName + ";Initial Catalog=" + valueCatalog +
                    //             ";Integrated Security=SSPI;";
                    connstring = @"Data Source=" + Environment.MachineName + "\\" + valueServerName +
                                 ";Initial Catalog=" + valueCatalog +
                                 ";Trusted_Connection=True;MultipleActiveResultSets=True";
                    cSSettings = new ConnectionStringSettings(valueConn, connstring, "System.Data.SqlClient");
                }
                else
                {
                    //connstring = "Data Source=" + valueServerName + "\";Initial Catalog=" + valueCatalog +
                    //                 ";User Id="+valueUser+"Password="+valuePwd+"; MultipleActiveResultSets=True";
                    connstring = @"Data Source=" + Environment.MachineName + "\\" + valueServerName +
                                 ";Initial Catalog=" + valueCatalog + ";User Id=" +
                                 valueUser + ";Password=" +
                                 valuePwd + ";MultipleActiveResultSets=True";
                    cSSettings = new ConnectionStringSettings(valueConn, connstring, "System.Data.SqlClient");
                }

                //ConnectionStringsSection csSection = config.ConnectionStrings;
                //csSection.ConnectionStrings.Add(cSSettings);
                //var oConfig = config.ConnectionStrings;
                //oConfig.ConnectionStrings.Add(cSSettings);
                //config.Save(ConfigurationSaveMode.Modified,true);
                var csSection = config.ConnectionStrings;
                csSection.ConnectionStrings.Add(cSSettings);
                config.Save(ConfigurationSaveMode.Modified, true);
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
        }

        #endregion

        #endregion

        #endregion



        #region SqlDataFunctions

        #region ListaSQLSERVERS

        #region GetRemoteServers

        public BindableCollection<string> DevolveServidoresRemotos()
        {
            var tmpBList = new BindableCollection<string>();
            //TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
            //var token = new CancellationToken();
            //var tmpTask =
            //    Task<BindableCollection<string>>.Factory.StartNew(GetRemoteSqlServers).ContinueWith(w => tmpBList,token,TaskContinuationOptions.None,scheduler );

            var uiTaskScheduler = TaskScheduler.FromCurrentSynchronizationContext();

            GetRemoteSqlServers().ContinueWith(t => { tmpBList = t.Result; }, uiTaskScheduler);

            return tmpBList;


            //return new BindableCollection<string>();
        }


        private Task<BindableCollection<string>> GetRemoteSqlServers()
        {
            var resultado = new List<string>();
            var tcs = new TaskCompletionSource<BindableCollection<string>>();

            using (var sqlSources = SqlDataSourceEnumerator.Instance.GetDataSources())
            {
                resultado.AddRange(from DataRow item in sqlSources.Rows
                                   where
                                       (!string.IsNullOrEmpty(item["InstanceName"].ToString()) ||
                                        (!string.IsNullOrEmpty(item["ServerName"].ToString())))
                                   select item["ServerName"] + "\\" + item["InstanceName"]);
                // resultado.AddRange(from DataRow source in sqlSources.Rows where !string.IsNullOrEmpty(source["InstanceName"].ToString()) select source["IntanceName"].ToString());
            }
            tcs.SetResult(new BindableCollection<string>(resultado));
            return tcs.Task;
        }


        //private BindableCollection<string> GetRemoteSqlServers()
        //{

        //    var resultado = new List<string>();

        //    using (DataTable sqlSources= SqlDataSourceEnumerator.Instance.GetDataSources())
        //    {

        //        resultado.AddRange(from DataRow item in sqlSources.Rows 
        //                           where (!string.IsNullOrEmpty(item["InstanceName"].ToString()) || (!string.IsNullOrEmpty(item["ServerName"].ToString()))) 
        //                           select item["ServerName"].ToString() + "\\" + item["InstanceName"].ToString());
        //        // resultado.AddRange(from DataRow source in sqlSources.Rows where !string.IsNullOrEmpty(source["InstanceName"].ToString()) select source["IntanceName"].ToString());
        //    }

        //    return new BindableCollection<string>(resultado);
        //}

        #endregion

        #region GetLocalServers

        /// <summary>
        /// metodo para obter as instancias sql locais
        /// </summary>
        /// <returns></returns>
        public BindableCollection<string> GetLocalSqlServers()
        {
            var resultado = new BindableCollection<string>();
            try
            {
                if (Is64BisVersion())
                {
                    if (VerificaChave(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", true))
                    {
                        resultado = DevolveListaServidores(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");
                    }
                    if (VerificaChaveTs(@"SOFTWARE\Wow6432Node\Microsoft\Microsoft SQL Server\Instance Names\SQL"))
                    {
                        var x =
                            DevolveListaServidores(
                                @"SOFTWARE\Wow6432Node\Microsoft\Microsoft SQL Server\Instance Names\SQL");
                        if (x != null)
                        {
                            if (x.Count > 0)
                            {
                                foreach (var s in x)
                                {
                                    resultado.Add(s);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (VerificaChave(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false))
                    {
                        resultado = DevolveListaServidores(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");
                    }
                }
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }
            return resultado;
        }

        private BindableCollection<string> DevolveListaServidores(string value)
        {
            var resultado = new BindableCollection<string>();
            try
            {
                var valueSfBits = Is64BisVersion();
                var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                                                              valueSfBits
                                                                  ? RegistryView.Registry64
                                                                  : RegistryView.Registry32);
                var key = baseKey.OpenSubKey(value);
                if (key != null)
                {
                    if (key.ValueCount > 0)
                    {
                        foreach (var item in key.GetValueNames())
                        {
                            resultado.Add(item);
                        }
                    }

                    baseKey.Dispose();
                    key.Dispose();
                }
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }

            return resultado;
        }

        private static bool VerificaChave(string value, bool valueSfBits)
        {
            try
            {
                var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine,
                                                              valueSfBits
                                                                  ? RegistryView.Registry64
                                                                  : RegistryView.Registry32);

                var key = baseKey.OpenSubKey(value);
                if ((key == null) || (key.ValueCount == 0))
                {
                    baseKey.Dispose();
                    return false;
                }
                baseKey.Close();
                baseKey.Dispose();
                key.Close();
                key.Dispose();

            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
            }

            return true;
        }


        private static bool VerificaChaveTs(string value)
        {

            try
            {
                var basekey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                var key = basekey.OpenSubKey(value);
                if ((key == null) || (key.ValueCount == 0))
                {

                    basekey.Dispose();
                    return false;
                }
               
                basekey.Dispose();
                key.Dispose();
            }
            catch (Exception e)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, e.Message));
                return false;
            }
            return true;
        }

        #endregion

        #endregion

        #endregion



        #endregion

        #region GenericFunctions

        #region InstalacaoWService

        public bool InstallWebService()
        {
            var resultado = false;
            try
            {
                var serviceLocation = Environment.CurrentDirectory + @"\ServiceSetup\setup.exe";
                // var  servicePath = System.IO.Path.Combine(Environment.CurrentDirectory,serviceLocation);

                if (File.Exists(serviceLocation))
                {
                    if (LoadSetup(serviceLocation))
                    {
                        resultado = true;
                    }

                }
                else
                {
                    EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, "O servico de comunicação nao foi encontrado"));
                }


            }
            catch (Exception ex)
            {
                //EventAggregationProvider.Aggregator.Publish<EventoBackend>(new EventoBackend(EventoTipo.Erro, ex.Message));
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }
            return resultado;
        }


        private static bool LoadSetup(string value)
        {
            var resultado = false;
            try
            {
                using (var tmpProcess = new Process())
                {
                    tmpProcess.StartInfo = new ProcessStartInfo { FileName = value, WindowStyle = ProcessWindowStyle.Normal };
                    tmpProcess.Start();
                    tmpProcess.WaitForExit();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {

                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }
            return resultado;
        }
        #endregion

        #region DadosUtilizador

        public string DevolveUtilizadorCurrente()
        {
            var user = GetCurrentUser();
            if (IsUserAdmin())
            {
                return user;
            }
            EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                          "o utilizador " + user +
                                                                          " nao e administrador"));
            return null;
        }

        private string GetCurrentUser()
        {
            try
            {
                var user = WindowsIdentity.GetCurrent();
                if (user != null) return user.Name;
            }
            catch (UnauthorizedAccessException ex)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }
            return null;
        }

        private bool IsUserAdmin()
        {
            var isAdmin = false;
            try
            {
                var user = WindowsIdentity.GetCurrent();

                if (user != null)
                {
                    var principal = new WindowsPrincipal(user);
                    isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }
            return isAdmin;
        }

        #endregion

        #region Detect64bits

        public bool Is64BisVersion()
        {
            return Environment.Is64BitOperatingSystem;
        }

        #endregion

        #region ClientSize

        public double GetWidth()
        {
            var resultado = 0.0;
            try
            {
                resultado = SystemParameters.WorkArea.Width;
            }
            catch (Exception ex)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }
            return resultado;
        }

        public double GetHeight()
        {
            var resultado = 0.0;
            try
            {
                resultado = SystemParameters.WorkArea.Height;
            }
            catch (Exception ex)
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro, ex.Message));
            }
            return resultado;
        }

        #endregion

        #endregion


    }
}