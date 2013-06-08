using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Windows.Input;
using BackEndAplication.Events;
using BackEndAplication.Models;
using BackEndAplication.Models.TerminalDBModel;
using BackEndAplication.Service;
using BackEndAplication.Utilities;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (IShell))]
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShell, IHandle<AppMessage>,
                                  IHandle<EventoBackend>, IHandle<EventoChangeActiveViewTerminal>
    {
        #region ClassVars

        private readonly LogFactoryManager _logManager = LogFactoryManager.GetInstance();
        private readonly DataService _service = DataService.GetInstance();
        private readonly Utility _utilities = Utility.GetInstance();

        private Configuracao Config { get; set; }

        [Import]
        public IWindowManager WindowManagerWindow { get; set; }

        #endregion

        #region Properties

        private string _currentView;
        private string _mensagemPopup;
        private bool _navisVisible;
        private int _passo;
        private string _progresso;
        private TbOpcoesTerminal _selectedOpTerminal;
        private TbTerminal _selectedTerminal;
        private double _shellHeight;
        private double _shellWidth;
        private string _title;

        public double ShellWidth
        {
            get { return _shellWidth; }
            set
            {
                _shellWidth = value;
                NotifyOfPropertyChange(() => ShellWidth);
            }
        }

        public double ShellHeight
        {
            get { return _shellHeight; }
            set
            {
                _shellHeight = value;
                NotifyOfPropertyChange(() => ShellHeight);
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    // RaisePropertyChangedEventImmediately("Title");
                    NotifyOfPropertyChange(() => Title);
                }
            }
        }

        public string CurrentView
        {
            get { return _currentView; }

            set
            {
                _currentView = value;
                NotifyOfPropertyChange(() => CurrentView);
            }
        }

        public bool NavisVisible
        {
            get { return _navisVisible; }
            set
            {
                _navisVisible = value;
                NotifyOfPropertyChange(() => NavisVisible);
            }
        }

        private int Passo
        {
            get { return _passo; }
            set
            {
                _passo = value;
                NotifyOfPropertyChange(() => Passo);
            }
        }

        public string Progresso
        {
            get { return _progresso; }
            set
            {
                _progresso = value;
                NotifyOfPropertyChange(() => Progresso);
            }
        }

        private string MensagemPopup
        {
            get { return _mensagemPopup; }
            set
            {
                _mensagemPopup = value;
                NotifyOfPropertyChange(() => MensagemPopup);
            }
        }


        public TbTerminal SelectedTerminal
        {
            get { return _selectedTerminal; }
            set
            {
                _selectedTerminal = value;
                NotifyOfPropertyChange(() => SelectedTerminal);
            }
        }

        public TbOpcoesTerminal SelectedOpTerminais
        {
            get { return _selectedOpTerminal; }
            set
            {
                _selectedOpTerminal = value;
                NotifyOfPropertyChange(() => SelectedOpTerminais);
            }
        }

        #endregion

        #region Ctor

        [ImportingConstructor]
        public ShellViewModel(ConfiguracaoWebServerViewModel valueConfigWebServerVm,
                              InicioConfiguracaoViewModel valueInicioConfigVm,
                              InstalacaoWebServiceViewModel valueInstalacaoWebServiceVm,
                              RegistoAppViewModel valueRegistoVm, ServerConfigViewModel valueServerConfigVm,
                              FimConfiguracaoViewModel valueFimConfiguracao, ListaTerminaisViewModel valueListaTerminais,
                              InitialViewModel valueInitialViewModel, DadosPhcViewModel valueDadosPhc,
                              DadosTerminalViewModel valueDadosT)
        {
            //Title = "Hello Caliburn.Micro";
            Title = "BackEnd Application";
            //EventAggregator = valueEventAgregator;
            Items.Add(valueRegistoVm);
            Items.Add(valueInicioConfigVm);
            Items.Add(valueConfigWebServerVm);
            Items.Add(valueServerConfigVm);
            Items.Add(valueInstalacaoWebServiceVm);
            Items.Add(valueFimConfiguracao);
            Items.Add(valueListaTerminais);
            Items.Add(valueInitialViewModel);

            //

            Items.Add(valueDadosT);
            Items.Add(valueDadosPhc);
            //
            //tab items
            //Items.Add(valueDadosPhc);
            //Items.Add(valueDadosT);
            //
            double height = _utilities.GetHeight();
            double width = _utilities.GetWidth();

            if ((height > 600) && (width > 800))
            {
                ShellHeight = 728;
                ShellWidth = 1024;
            }
            _logManager.InitializeLog();
            //_logManager.EventViewerCheckSource();
        }

        #endregion

        #region Metodos

        public void GetConfigData()
        {
            //ActivateItem(new RegistoAppViewModel());   
            //

            _logManager.WriteInfo(1150, "A carregar a aplicacao");
            Config = _utilities.LoadConfigData();


            if (!Config.IsRegistered)
            {
                CurrentView = "RegistoApp";
                ActivateItem(Items.SingleOrDefault(p => p.DisplayName == CurrentView));
                NavisVisible = false;
            }

            else
            {
                CurrentView = "ViewInicial";
                ActivateItem(Items.SingleOrDefault(p => p.DisplayName == CurrentView));
                NavisVisible = false;
            }
        }


        protected override void OnActivate()
        {
            EventAggregationProvider.Aggregator.Subscribe(this);
            base.OnActivate();
        }


        public override void CanClose(Action<bool> callback)
        {
            var modalD = IoC.Get<ModalDialogViewModel>();
            modalD.TituloModal = "Encerrar Aplicação";
            modalD.MensagemModal = "Deseja encerrar a aplicação?";
            modalD.ModalHeight = 250;
            modalD.ModalWidth = 250;
            bool? result = WindowManagerWindow.ShowDialog(modalD);
            if (result == null) return;
            if ((bool) result)
            {
                callback(true);
            }
            else
            {
                callback(false);
            }
        }

        protected override void OnDeactivate(bool close)
        {
            _logManager.WriteInfo(1000, "A encerrar a aplicacao");
            if (!Config.ConfigOk)
            {
                _utilities.SaveConfig(Config);
            }

            EventAggregationProvider.Aggregator.Unsubscribe(this);
            base.OnDeactivate(true);
        }

        #endregion

        #region Navigation

        private string GetNextView()
        {
            IScreen z = Items.SkipWhile(x => x.DisplayName != CurrentView).Skip(1).FirstOrDefault();

            return z != null ? z.DisplayName : null;
        }

        private string GetPreviewiousView()
        {
            IScreen z = Items.Reverse().SkipWhile(x => x.DisplayName != CurrentView).Skip(1).FirstOrDefault();
            return z != null ? z.DisplayName : null;
        }


        public void Seguinte()
        {
            //if (CurrentView == "FimConfiguracao") return;
            CurrentView = GetNextView();
            //ActivateItem(Items.SingleOrDefault(p => p.DisplayName == CurrentView));
            //EventAggregator.Publish(new AppMessage((AppMessageType)Enum.Parse(typeof(AppMessageType), CurrentView)));
            //EventAggregationProvider.Aggregator.Publish<AppMessage>(new AppMessage((AppMessageType)Enum.Parse(typeof(AppMessageType), CurrentView)));
            EventAggregationProvider.Aggregator.Publish(
                new AppMessage((AppMessageType) Enum.Parse(typeof (AppMessageType), CurrentView)));

            if ((CurrentView != "InicioConfiguracao") && (CurrentView != "ListaTerminais"))
            {
                Passo += 1;
                Progresso = "Passo: " + Passo.ToString(CultureInfo.InvariantCulture) + " de 4";
            }
        }


        public void Anterior()
        {
            if (CurrentView != "InicioConfiguracao")
            {
                CurrentView = GetPreviewiousView();
                //EventAggregator.Publish(new AppMessage((AppMessageType)Enum.Parse(typeof(AppMessageType), CurrentView)));
                //EventAggregationProvider.Aggregator.Publish<AppMessage>(new AppMessage((AppMessageType)Enum.Parse(typeof(AppMessageType), CurrentView)));
                EventAggregationProvider.Aggregator.Publish(
                    new AppMessage((AppMessageType) Enum.Parse(typeof (AppMessageType), CurrentView)));
                Passo -= 1;
                Progresso = "Passo: " + Passo.ToString(CultureInfo.InvariantCulture) + " de 4";
            }
            //ActivateItem(Items.SingleOrDefault(p => p.DisplayName == CurrentView));
        }

        #endregion

        #region HandlerEventos

        /// <summary>
        /// Handler para o evento Navegacao
        /// </summary>
        /// <param name="message"></param>
        public void Handle(AppMessage message)
        {
            switch (message.AppMessageType)
            {
                case AppMessageType.InicioConfiguracao:
                    CurrentView = "InicioConfiguracao";
                    ActivateItem(Items.Single(p => p.DisplayName == "InicioConfiguracao"));
                    NavisVisible = true;
                    break;
                case AppMessageType.RegistoApp:
                    ActivateItem(Items.Single(p => p.DisplayName == "RegistoApp"));
                    NavisVisible = true;
                    break;
                case AppMessageType.ConfigWebServer:
                    NavisVisible = false;
                    ActivateItem(Items.Single(p => p.DisplayName == "ConfigWebServer"));

                    break;
                case AppMessageType.InstallWebService:

                    ActivateItem(Items.Single(p => p.DisplayName == "InstallWebService"));
                    Config.InstalacaoServico = true;
                    _utilities.SaveConfig(Config);
                    NavisVisible = true;
                    break;
                case AppMessageType.ServerConfig:
                    NavisVisible = false;
                    ActivateItem(Items.Single(p => p.DisplayName == "ServerConfig"));

                    break;
                case AppMessageType.FimConfiguracao:
                    Config.ConfigOk = true;
                    _utilities.SaveConfig(Config);
                    ActivateItem(Items.Single(p => p.DisplayName == "FimConfiguracao"));
                    NavisVisible = true;
                    break;
                case AppMessageType.ListaTerminais:
                    NavisVisible = false;
                    ActivateItem(Items.Single(p => p.DisplayName == "ListaTerminais"));
                    NavisVisible = false;
                    break;
            }
        }

        #region HandlerEventoApplicacao

        /// <summary>
        ///  handler para o evento configuracao 
        /// </summary>
        /// <param name="valueMessage"></param>
        public void Handle(EventoBackend valueMessage)
        {
            switch (valueMessage.TipoEvento)
            {
                case EventoTipo.RegistoAplicacao:

                    var regApp =
                        (bool)
                        valueMessage.EventData.GetType().GetProperties()[0].GetValue(valueMessage.EventData, null);
                    if (regApp)
                    {
                        Config.IsValid = true;
                        Config.IsRegistered = true;
                        var serial =
                            (string)
                            valueMessage.EventData.GetType().GetProperties()[1].GetValue(valueMessage.EventData, null);
                        var mailCliente =
                            (string)
                            valueMessage.EventData.GetType().GetProperties()[2].GetValue(valueMessage.EventData, null);
                        //Config.Serial = valueMessage.EventData.SerialCliente;
                        //Config.MailCliente = valueMessage.EventData.ClienteMail;
                        //_utilities.SaveConfig(Config);
                        Config.Serial = serial;
                        Config.MailCliente = mailCliente;

                        _utilities.SaveConfig(Config);
                        Seguinte();
                        NavisVisible = true;
                    }

                    break;
                case EventoTipo.ConfiguracaoSQL:
                    var sqlConfig =
                        (bool)
                        valueMessage.EventData.GetType().GetProperties()[0].GetValue(valueMessage.EventData, null);
                    if (sqlConfig)
                    {
                        Config.SQLConfigurationOk = true;
                        //campos saem daqui, as conneccoes ficam aparte (ado.net entity framework)
                        //Config.PhcdbName = valueMessage.EventData.SqlDBName;
                        //Config.PhcdbuSer = valueMessage.EventData.SqlUserName;
                        //Config.Phcsqlservername = valueMessage.EventData.NomeSqlServer;
                        //Config.PhcdbUserPwd = valueMessage.EventData.SqlPass;
                        _utilities.SaveConfig(Config);
                        NavisVisible = true;
                    }

                    break;
                case EventoTipo.ConfiguracaoServidor:
                    var serverConfig =
                        (bool)
                        valueMessage.EventData.GetType().GetProperties()[0].GetValue(valueMessage.EventData, null);
                    if (serverConfig)
                    {
                        var nomeSite =
                            (string)
                            valueMessage.EventData.GetType().GetProperties()[1].GetValue(valueMessage.EventData, null);
                        var nomeApp =
                            (string)
                            valueMessage.EventData.GetType().GetProperties()[2].GetValue(valueMessage.EventData, null);
                        var vdir =
                            (string)
                            valueMessage.EventData.GetType().GetProperties()[3].GetValue(valueMessage.EventData, null);
                        Config.WebConfigurationOk = true;
                        Config.NomeSite = nomeSite;
                        Config.NomeVirtualDir = vdir;
                        Config.NomeApplicationPool = nomeApp;
                        _utilities.SaveConfig(Config);
                        NavisVisible = true;
                    }
                    break;
                default:

                    Mouse.OverrideCursor = Cursors.Arrow;
                    MensagemPopup = valueMessage.EventData.ToString();
                    Processerror(valueMessage.EventData.ToString());


                    break;
            }
        }

        #endregion

        #region MostraDialog

        public IEnumerable<IResult> ShowDialogGetResult()
        {
            //var sd = new ShowDialog<MessageBoxViewModel>();

            //yield return sd;
            //var resultado = sd.Dialog.Result;
            //if (resultado != null)
            //{
            //    yield return new ShowDialog<MessageBoxViewModel>()
            //        .ConfigureWith(x => x.MessageboxMessage = MensagemPopup);
            //}


            yield return new ShowDialog<MessageBoxViewModel>()
                .ConfigureWith(x => x.MessageboxMessage = MensagemPopup,
                               t => t.MessageTitle = "Erro Backend Application");
        }

        #endregion

        #region ErroProcessor

        private void Processerror(string valueMessage)
        {
            _logManager.WriteError(1160, valueMessage);
            MensagemPopup = valueMessage;

            Coroutine.BeginExecute(ShowDialogGetResult().GetEnumerator());
        }

        #endregion

        #region HandlerEventoCriacaoAlteracaoTerminais

        public void Handle(EventoChangeActiveViewTerminal message)
        {
            switch (message.TipoAccao)
            {
                case AccaoEfectuada.AddPhcData:
                    ActivateItem(Items.Single(p => p.DisplayName == "DadosPhc"));
                    break;
                case AccaoEfectuada.AddTerminalData:
                    ActivateItem(Items.Single(p => p.DisplayName == "DadosTerminal"));
                    break;
                case AccaoEfectuada.AddedTerminalData:
                    SelectedTerminal = message.EventoDataTerminal;
                    ActivateItem(Items.Single(p => p.DisplayName == "DadosPhc"));
                    break;
                case AccaoEfectuada.AddedPhcData:
                    SelectedOpTerminais = message.EventoDataOpcoes;
                    _service.CreateTerminal(SelectedTerminal, SelectedOpTerminais);
                    ActivateItem(Items.Single(p => p.DisplayName == "ListaTerminais"));
                    break;

                case AccaoEfectuada.UpdateTerminalData:
                    SelectedTerminal = message.EventoDataTerminal;
                    ActivateItem(Items.Single(t => t.DisplayName == "DadosTerminal"));
                    EventAggregationProvider.Aggregator.Publish(new EventoSelectedData(
                                                                    TipoSelected.TerminalDataSelected, SelectedTerminal));
                    break;
                case AccaoEfectuada.UpdatedTerminalData:
                    SelectedTerminal = message.EventoDataTerminal;

                    // verificar se o SelectedOpTerminais nao e nulo
                    if (SelectedOpTerminais == null)
                    {
                        SelectedOpTerminais = _service.GetEntityOpcoes(SelectedTerminal.FkIDOT);
                    }
                    //
                    ActivateItem(Items.Single(p => p.DisplayName == "DadosPhc"));
                    EventAggregationProvider.Aggregator.Publish(new EventoSelectedData(TipoSelected.PhcDataSelected,
                                                                                       null, SelectedOpTerminais));
                    break;
                case AccaoEfectuada.UpdatedPhcData:
                    SelectedOpTerminais = message.EventoDataOpcoes;
                    _service.UpdateTerminal(SelectedTerminal, SelectedOpTerminais);
                    ActivateItem(Items.Single(p => p.DisplayName == "ListaTerminais"));
                    break;
                default:
                    ActivateItem(Items.Single(p => p.DisplayName == "ListaTerminais"));
                    break;
            }
        }

        #endregion

        #endregion
    }
}