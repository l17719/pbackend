using System;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using BackEndAplication.Events;
using BackEndAplication.Models.TerminalDBModel;
using BackEndAplication.Service;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (DadosTerminalViewModel))]
    public class DadosTerminalViewModel : Screen, IHandle<EventoSelectedData>
    {
        #region classVars

        //[Import]
        //public IWindowManager WindowManagerWindow { get; set; }

        private readonly DataService _dataService = DataService.GetInstance();
        [Import]
        public IWindowManager WindowManagerWindow { get; set; }
        #endregion

        #region Propriedades

        private bool _isDadosTerminalChanged;
        private bool _isUpdatingData;
        private TbTerminal _selectedTerminal;

        private string _tipoOp;
        private string _txtBAccessKey;
        private string _txtMacAddTg;
        private string _txtMacAddW;
        private string _txtNumTerminal;

        public bool IsUpdatingData
        {
            get { return _isUpdatingData; }
            set
            {
                _isUpdatingData = value;
                NotifyOfPropertyChange(() => IsUpdatingData);
            }
        }

        public string TipoOp
        {
            get { return _tipoOp; }
            set
            {
                _tipoOp = value;
                NotifyOfPropertyChange(() => TipoOp);
            }
        }

        protected TbTerminal SelectedTerminal
        {
            get { return _selectedTerminal; }
            set
            {
                _selectedTerminal = value;
                NotifyOfPropertyChange(() => SelectedTerminal);
            }
        }

        public bool IsDadosTerminalChanged
        {
            get { return _isDadosTerminalChanged; }
            set
            {
                if (_isDadosTerminalChanged == value) return;
                _isDadosTerminalChanged = value;
                NotifyOfPropertyChange(() => IsDadosTerminalChanged);
            }
        }

        public string TxtMacAddTg
        {
            get { return _txtMacAddTg; }
            set
            {
                if (_txtMacAddTg == value) return;
                _txtMacAddTg = value;
                NotifyOfPropertyChange(() => TxtMacAddTg);
                IsDadosTerminalChanged = true;
            }
        }

        public string TxtNumTerminal
        {
            get { return _txtNumTerminal; }
            set
            {
                if (_txtNumTerminal == value) return;
                _txtNumTerminal = value;
                NotifyOfPropertyChange(() => TxtNumTerminal);
                IsDadosTerminalChanged = true;
            }
        }

        public string TxtMacAddW
        {
            get { return _txtMacAddW; }
            set
            {
                if (value == _txtMacAddW) return;
                _txtMacAddW = value;
                NotifyOfPropertyChange(() => TxtMacAddW);
                IsDadosTerminalChanged = true;
            }
        }

        public string TxtBAccessKey
        {
            get { return _txtBAccessKey; }
            set
            {
                if (value == _txtBAccessKey) return;
                _txtBAccessKey = value;
                NotifyOfPropertyChange(() => TxtBAccessKey);
            }
        }

        #endregion

        #region Ctor

        public DadosTerminalViewModel()
        {
            DisplayName = "DadosTerminal";
        }

        #endregion

        #region metodos

        public void SetDadosTerminal()
        {
            if (!IsDadosTerminalChanged) return;
            TbTerminal tmpTerminal = null;
            if (IsUpdatingData)
            {
                tmpTerminal = new TbTerminal
                {
                    TerminalAccessKey = Guid.Parse(TxtBAccessKey),
                    MacAddress3G = TxtMacAddTg,
                    MacAddressWireless = TxtMacAddW,
                    NumPda = TxtNumTerminal,
                    IDTerminal = SelectedTerminal.IDTerminal,
                    FkIDOT = SelectedTerminal.FkIDOT

                };
            }
            else
            {
                if(!VerificaDadosObrigatorios())
                {
                    MostraDialogo();
                    return;
                }
                if (!_dataService.VerificaTerminalNum(TxtNumTerminal))
                {
                    tmpTerminal = new TbTerminal
                    {
                        TerminalAccessKey = Guid.Parse(TxtBAccessKey),
                        MacAddress3G = TxtMacAddTg,
                        MacAddressWireless = TxtMacAddW,
                        NumPda = TxtNumTerminal,
                        IDTerminal = Guid.NewGuid(),


                    };
                    
                }
                else
                {
                    ShowModalGetResult();
                }
                
            }


            EventAggregationProvider.Aggregator.Publish(IsUpdatingData
                                                            ? new EventoChangeActiveViewTerminal(
                                                                  AccaoEfectuada.UpdatedTerminalData, tmpTerminal)
                                                            : new EventoChangeActiveViewTerminal(
                                                                  AccaoEfectuada.AddedTerminalData, tmpTerminal));
        }

        private bool VerificaDadosObrigatorios()
        {
            if ((string.IsNullOrEmpty(TxtNumTerminal)) || (string.IsNullOrEmpty(TxtMacAddTg)) || (string.IsNullOrEmpty(TxtMacAddW)) || (string.IsNullOrEmpty(TxtBAccessKey)))
            {
                return false;
            }
            return true;
        }

        public void ShowModalGetResult()
        {
            var modalD = IoC.Get<ModalDialogViewModel>();
            modalD.TituloModal = "Criação Terminal";
            modalD.MensagemModal = "O terminal:"+ TxtNumTerminal +" já existe, por favor escolha outro nome ou altere os dados do terminal pretendido";
            modalD.ModalWidth = 250;
            modalD.ModalHeight = 250;
            var result = WindowManagerWindow.ShowDialog(modalD);
        }
        public void GeraNovaChave()
        {
            TxtBAccessKey = CriaGuidChave();
            IsDadosTerminalChanged = true;
        }


        private string CriaGuidChave()
        {
            // return Guid.NewGuid().ToString().ToUpper();
            return Guid.NewGuid().ToString();
        }

        protected override void OnActivate()
        {
            EventAggregationProvider.Aggregator.Subscribe(this);
            base.OnActivate();
        }

        protected override void OnDeactivate(bool close)
        {
            EventAggregationProvider.Aggregator.Unsubscribe(this);

            // 
            TxtBAccessKey = null;
            TxtMacAddW = null;
            TxtNumTerminal = null;
            TxtMacAddTg = null;


            IsDadosTerminalChanged = false;
            SelectedTerminal = null;
            IsUpdatingData = false;
            //


            base.OnDeactivate(close);
        }


       


        private void InjectProperties()
        {
            IsUpdatingData = true;
            TxtBAccessKey = SelectedTerminal.TerminalAccessKey.ToString();
            TxtMacAddTg = SelectedTerminal.MacAddress3G;
            TxtMacAddW = SelectedTerminal.MacAddressWireless;


            TxtNumTerminal = SelectedTerminal.NumPda;
        }

        public void Canceldata()
        {
            EventAggregationProvider.Aggregator.Publish(new EventoChangeActiveViewTerminal(AccaoEfectuada.Cancel));
            IsUpdatingData = false;
        }
        private void MostraDialogo()
        {
            var modalId = IoC.Get<ModalDialogViewModel>();
            modalId.TituloModal = "Informacao nao preenchida";
            modalId.MensagemModal = "Preencha a informacao necessária para a definição dos dados do terminal";
            modalId.ModalHeight = 200;
            modalId.ModalWidth = 200;

            bool? result = WindowManagerWindow.ShowDialog(modalId);
            if (result == null) return;
            if ((bool)result)
            {
                
            }
        }
        #endregion

        #region Implementation of IHandle<EventoDataUpdate>

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Handle(EventoSelectedData message)
        {
            if (message.TipoSelectedItem != TipoSelected.TerminalDataSelected) return;
            SelectedTerminal = message.SelectedDataTerminal;

            InjectProperties();
        }

        #endregion
    }
}