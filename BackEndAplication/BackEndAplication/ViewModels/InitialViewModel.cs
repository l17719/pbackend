using System.ComponentModel.Composition;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Input;
using BackEndAplication.Events;
using BackEndAplication.Models;
using BackEndAplication.Service;
using BackEndAplication.Utilities;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof(InitialViewModel))]
    public class InitialViewModel : Screen
    {
        #region ClassVars

        private readonly Utility _utilities = Utility.GetInstance();
        private Configuracao TmpConfig { get; set; }
        private static readonly DataService ServicoDados = DataService.GetInstance();
        #endregion

        #region Properties

        private bool _isBtnMostraTermActive;

        private bool _isbtnEditActive;

        public bool IsBtnMostraTermActive
        {
            get { return _isBtnMostraTermActive; }
            set
            {
                _isBtnMostraTermActive = value;
                NotifyOfPropertyChange(() => IsBtnMostraTermActive);
            }
        }

        public bool IsbtnEditActive
        {
            get { return _isbtnEditActive; }
            set
            {
                _isbtnEditActive = value;
                NotifyOfPropertyChange(() => IsbtnEditActive);
            }
        }


      
        #endregion

        #region Ctor

        public InitialViewModel()
        {
            DisplayName = "ViewInicial";
        }

        #endregion

        #region Metodos

        protected override void OnActivate()
        {
            EventAggregationProvider.Aggregator.Subscribe(this);
            base.OnActivate();
        }

        protected override void OnViewLoaded(object view)
        {
            TmpConfig = _utilities.LoadConfigData();
            base.OnViewLoaded(view);

            ActivaItems();
        }


        
        private void ActivaItems()
        {
            IsBtnMostraTermActive = TmpConfig.ConfigOk;
            IsbtnEditActive = TmpConfig.ConfigOk;
            if (!IsBtnMostraTermActive) return;
            Task<bool>.Factory.StartNew(LoadFiltros);
            //LoadFiltros();



        }



      

        private static bool LoadFiltros()
        {

            ServicoDados.LoadBulkData();
           
            //ServicoDados.LoadFiltrosClientes();

            //ServicoDados.LoadFiltrosStocks();
            //ServicoDados.LoadVendedores();
            //ServicoDados.CarregaDossiersInternos();
            //ServicoDados.GetDadosUs();
            //Mouse.OverrideCursor = Cursors.Arrow;
            return true;
        }
        protected override void OnDeactivate(bool close)
        {
            EventAggregationProvider.Aggregator.Unsubscribe(this);
            base.OnDeactivate(close);
        }

        #region AccoesBotoes

        public void CriaConfig()
        {
            EventAggregationProvider.Aggregator.Publish(new AppMessage(AppMessageType.InicioConfiguracao));
        }

        public void EditaConfig()
        {
            EventAggregationProvider.Aggregator.Publish(!TmpConfig.WebConfigurationOk
                                                            ? new AppMessage(AppMessageType.ConfigWebServer)
                                                            : new AppMessage(AppMessageType.ServerConfig));
        }

        public void MostraTerminais()
        {
            EventAggregationProvider.Aggregator.Publish(new AppMessage(AppMessageType.ListaTerminais));
        }

        #endregion

        #endregion
    }
}