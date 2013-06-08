using System.ComponentModel.Composition;
using System.Threading.Tasks;
using System.Windows.Input;
using BackEndAplication.Service;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (FimConfiguracaoViewModel))]
    public class FimConfiguracaoViewModel : Screen
    {

        #region ClassVars

        private readonly DataService _service = DataService.GetInstance();
        #endregion
        #region Ctor
        public FimConfiguracaoViewModel()
        {
            DisplayName = "FimConfiguracao";
        }
        #endregion
        #region properties

        private string _textFim;

        public string TextFim
        {
            get { return _textFim; }
            set
            {
                _textFim = value;
                NotifyOfPropertyChange(() => TextFim);
            }
        }
        
        
        #endregion

        #region Metodos
        protected override void OnViewLoaded(object view)
        {
            base.OnActivate();
           
            Task<bool>.Factory.StartNew(LoadFiltros);


        }

     

        private bool LoadFiltros()
        {
            _service.LoadBulkData();
           
            //_service.LoadFiltrosClientes();
            //_service.LoadFiltrosStocks();
            //_service.LoadVendedores();
            //_service.CarregaDossiersInternos();
            //_service.GetDadosUs();
            return true;
        }
        #endregion
    }
}