using System.ComponentModel.Composition;
using System.Threading.Tasks;
using BackEndAplication.Events;
using BackEndAplication.Utilities;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (ConfiguracaoWebServerViewModel))]
    public class ConfiguracaoWebServerViewModel : Screen
    {
        #region Properties

        private readonly Utility _utilities = Utility.GetInstance();
        //private Task<bool> _t2;

        private BindableCollection<string> _cbWebsites;

        private string _selectedCbWebsites;

        private string _txtNws;


        private string _txtPLocal;
        private string _txtPort;


        private string _txtVdir;

        public BindableCollection<string> CbWebsites
        {
            get { return _cbWebsites; }
            set
            {
                _cbWebsites = value;
                NotifyOfPropertyChange(() => CbWebsites);
            }
        }

        public string SelectedCbWebsites
        {
            get { return _selectedCbWebsites; }
            set
            {
                if (value == _selectedCbWebsites) return;

                _selectedCbWebsites = value;
                NotifyOfPropertyChange(() => SelectedCbWebsites);
                if (SelectedCbWebsites == "Criar WebSite")
                {
                    CustomDataVisible = true;
                }
            }
        }

        public string TxtNws
        {
            get { return _txtNws; }
            set
            {
                _txtNws = value;
                NotifyOfPropertyChange(() => TxtNws);
            }
        }

        public string TxtPLocal
        {
            get { return _txtPLocal; }
            set
            {
                _txtPLocal = value;
                NotifyOfPropertyChange(() => TxtPLocal);
            }
        }

        public string TxtVdir
        {
            get { return _txtVdir; }
            set
            {
                _txtVdir = value;
                NotifyOfPropertyChange(() => TxtVdir);
            }
        }

        public string TxtPort
        {
            get { return _txtPort; }
            set
            {
                _txtPort = value;
                NotifyOfPropertyChange(() => TxtPort);
            }
        }

        #region grpboxManualProperties

        private bool _customDataVisible;
        private bool _grpIsVisible;

        public bool GrpIsVisible
        {
            get { return _grpIsVisible; }
            set
            {
                _grpIsVisible = value;
                NotifyOfPropertyChange(() => GrpIsVisible);
            }
        }


        public bool CustomDataVisible
        {
            get { return _customDataVisible; }
            set
            {
                _customDataVisible = value;
                NotifyOfPropertyChange(() => CustomDataVisible);
            }
        }

        #endregion

        #endregion

        #region Eventos

        public void SelectDefaultoptions()
        {
            if ((GrpIsVisible)||(CustomDataVisible))
            {
                GrpIsVisible = false;
                CustomDataVisible = false;
            }
            // _events.Publish(new EventoConfiguracaoWS("Default","DefaultAppPool","Default Web Site"));
            //EventAggregationProvider.EventAggregate.Publish<EventoConfiguracaoWS>(new EventoConfiguracaoWS("Default", "DefaultAppPool", "Default Web Site"));
            //EventAggregationProvider.Aggregator.Publish<EventoBackend>(new EventoBackend(EventoTipo.ConfiguracaoServidor, "Default"));
            var data =
                new
                    {
                        WebServerConfigOK = true,
                        NomeSite = "Default WebSite",
                        NomeAppPool = "DefaultAppPool",
                        NomeVdir = TxtVdir
                    };
            EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.ConfiguracaoServidor, data));
        }


        public void SelectManualOp()
        {
            if (GrpIsVisible) return;

            GrpIsVisible = true;
            //_t1 = Task<bool>.Factory.StartNew(ProcessAppPools);

            //if (_t1.Result)
            //{
            //    _t1.Dispose();
            //}
            Task<bool>.Factory.StartNew(ProcessWs);

            //_t2 = Task<bool>.Factory.StartNew(ProcessWs);

            //if (_t2.Result)
            //{
            //    _t2.Dispose();
            //}
        }

        #endregion

        #region Metodos

        private bool ProcessWs()
        {
            CbWebsites = _utilities.GetWebIisWebSites();
            return CbWebsites != null;
        }

        public void GuardaConfig()
        {
            if (!TxtPLocal.EndsWith("\\"))
            {
                TxtPLocal = TxtPLocal + "\\";
            }
            string versionofOs = _utilities.GetIisVersion();
            if ((versionofOs == "Windows 7") || (versionofOs == "Windows Vista/Server 2008"))
            {
                _utilities.CreateWebSiteWithAdmin(TxtNws, TxtPLocal, TxtPort);
                //var data = new { WebServerConfigOK = true, NomeSite = "", NomeAppPool = "IFEBAPool", NomeVdir = "" };
                //EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.ConfiguracaoServidor, data));
            }
            else
            {
                _utilities.CreateWebSiteWithDir(TxtNws, TxtPLocal, TxtPort, TxtVdir);
                var data =
                    new {WebServerConfigOK = true, NomeSite = TxtNws, NomeAppPool = "IFEBAPool", NomeVdir = TxtVdir};
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.ConfiguracaoServidor, data));
            }
        }

        //private bool ProcessAppPools()
        //{
        //    cbAppPool = _utilities.GetApplicationPoolEntries();
        //    return cbAppPool != null;
        //}

        #endregion

        #region HelperMethods

        public ConfiguracaoWebServerViewModel()
        {
            DisplayName = "ConfigWebServer";
        }

        public void LoadConfigWebServer()
        {
            GrpIsVisible = false;
            string versionofOs = _utilities.GetIisVersion();
            if ((versionofOs == "Windows 7") || (versionofOs == "Windows Vista/Server 2008"))
            {
                if (!_utilities.CheckAppPoolWithAdmin())
                {
                    EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                                  "A versao 4.0 de Asp nao esta instalada no servidor"));
                }
            }
            else
            {
                if (!_utilities.CheckAppPoolWithDir())
                {
                    EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                                  "A versao 4.0 de Asp nao esta instalada no servidor"));
                }
            }
        }

        protected override void OnDeactivate(bool close)
        {
            EventAggregationProvider.Aggregator.Unsubscribe(this);
            base.OnDeactivate(close);
        }

        #endregion
    }
}