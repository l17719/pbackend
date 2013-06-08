using System.ComponentModel.Composition;
using System.Threading.Tasks;
using BackEndAplication.Events;
using BackEndAplication.Models.TerminalDBModel;
using BackEndAplication.Service;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (ListaTerminaisViewModel))]
    public class ListaTerminaisViewModel : Screen
    {
        #region Classvars

        private readonly DataService _dataService = DataService.GetInstance();

        [Import]
        public IWindowManager WindowManagerWindow { get; set; }

        #endregion

        #region proriedades

        private bool _isBtnDeleteEnabled;


        private bool _isBtnUpdateEnabled;


        private BindableCollection<TbTerminal> _listaTbTerminais;
        private TbTerminal _selectedListaTbTerminais;
        private TbOpcoesTerminal _selectedTbOpcoesTerminais;


        private bool _terminaisVisiveis;

        public bool IsBtnDeleteEnabled
        {
            get { return _isBtnDeleteEnabled; }
            set
            {
                _isBtnDeleteEnabled = value;
                NotifyOfPropertyChange(() => IsBtnDeleteEnabled);
            }
        }

        public bool IsBtnUpdateEnabled
        {
            get { return _isBtnUpdateEnabled; }
            set
            {
                _isBtnUpdateEnabled = value;
                NotifyOfPropertyChange(() => IsBtnUpdateEnabled);
            }
        }

        public BindableCollection<TbTerminal> ListaTbTerminais
        {
            get { return _listaTbTerminais; }
            set
            {
                if (_listaTbTerminais == value) return;

                _listaTbTerminais = value;
                NotifyOfPropertyChange(() => ListaTbTerminais);
            }
        }

        public bool TerminaisVisiveis
        {
            get { return _terminaisVisiveis; }
            set
            {
                _terminaisVisiveis = value;
                NotifyOfPropertyChange(() => TerminaisVisiveis);
            }
        }


        //real one

        public TbTerminal SelectedListaTbTerminais
        {
            get { return _selectedListaTbTerminais; }
            set
            {
                _selectedListaTbTerminais = value;
                NotifyOfPropertyChange(() => SelectedListaTbTerminais);
            }
        }

        public TbOpcoesTerminal SelectedTbOpcoesTerminais
        {
            get { return _selectedTbOpcoesTerminais; }
            set
            {
                _selectedTbOpcoesTerminais = value;
                NotifyOfPropertyChange(() => SelectedTbOpcoesTerminais);
            }
        }

        #endregion

        #region Ctor

        //[ImportingConstructor]
        public ListaTerminaisViewModel()
        {
            DisplayName = "ListaTerminais";
        }

        #endregion

        #region CrudOperations

        public void AddTerminal()
        {
            EventAggregationProvider.Aggregator.Publish(
                new EventoChangeActiveViewTerminal(AccaoEfectuada.AddTerminalData));
        }

        public void DeleteTerminal()
        {
            MostraDialogo();
        }

        private void MostraDialogo()
        {
            var modalId = IoC.Get<ModalDialogViewModel>();
            modalId.TituloModal = "Eliminar Informacao";
            modalId.MensagemModal = "Deseja Eliminar a informacao do terminal?";
            modalId.ModalHeight = 150;
            modalId.ModalWidth = 150;

            bool? result = WindowManagerWindow.ShowDialog(modalId);
            if (result == null) return;
            if ((bool) result)
            {
                if (SelectedListaTbTerminais == null) return;
                _dataService.DeleteTerminal(SelectedListaTbTerminais.IDTerminal);

                ListaTbTerminais.Remove(SelectedListaTbTerminais);

                SelectedListaTbTerminais = null;
            }
        }

        public void UpdateTerminal()
        {
            if (SelectedListaTbTerminais == null) return;
            MostraDialogoUpdate();
        }

        private void MostraDialogoUpdate()
        {
            var modalId = IoC.Get<ModalDialogViewModel>();
            modalId.TituloModal = "Alterar Informacao";
            modalId.MensagemModal = "Deseja Alterar a informacao do terminal?";
            modalId.ModalHeight = 150;
            modalId.ModalWidth = 150;

            bool? result = WindowManagerWindow.ShowDialog(modalId);
            if (result == null) return;
            if ((bool) result)
            {
                EventAggregationProvider.Aggregator.Publish(
                    new EventoChangeActiveViewTerminal(AccaoEfectuada.UpdateTerminalData, SelectedListaTbTerminais));
            }
        }

        #endregion

        #region Metodos

        public void DevolveDados()
        {
            Task<bool>.Factory.StartNew(LoadDadosTerminal);

            //ListaTbOpcoesTerminais = _dataService.LoadOpcoesTerminal();
        }

        private bool LoadDadosTerminal()
        {
            BindableCollection<TbTerminal> x = _dataService.LoadTerminais();
            ListaTbTerminais = x;


            return ListaTbTerminais != null;
        }

        protected override void OnActivate()
        {
            // EventAggregator.Subscribe(this);

            EventAggregationProvider.Aggregator.Subscribe(this);
            base.OnActivate();
            LoadDadosTerminal();
        }

        protected override void OnDeactivate(bool close)
        {
            EventAggregationProvider.Aggregator.Unsubscribe(this);
            base.OnDeactivate(close);
        }

        public void SetSelectedItem(object value)
        {
            if (value == null) return;

            SelectedListaTbTerminais = value as TbTerminal;
        }

        #endregion

        #region MockdataFunc

        public void LoadMockData()
        {
            //ListaTerminais = _dataService.LoadMockTerminals();
        }

        #endregion
    }
}