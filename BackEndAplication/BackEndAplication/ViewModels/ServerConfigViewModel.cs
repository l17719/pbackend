using System.ComponentModel.Composition;
using System.Windows.Controls;
using System.Windows.Input;
using BackEndAplication.Events;
using BackEndAplication.Service;
using BackEndAplication.Utilities;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (ServerConfigViewModel))]
    public class ServerConfigViewModel : Screen, IHandle<EventoModal>
    {
        #region ClassVars

        private readonly DataService _dataService = DataService.GetInstance();
        private readonly Utility _utilities = Utility.GetInstance();

        [Import]
        public IWindowManager WindowManagerWindow { get; set; }

        #endregion

        #region Propriedades

        #region Navegacao

        private bool _brdDadosUser;
        private bool _brdIsVisible;
        private bool _brdRemoteUserData;
        private bool _brdSelectDb;
        private bool _brdSetOptions;

        public bool BrdIsVisible
        {
            get { return _brdIsVisible; }
            set
            {
                _brdIsVisible = value;
                NotifyOfPropertyChange(() => BrdIsVisible);
            }
        }

        public bool BrdDadosUser
        {
            get { return _brdDadosUser; }
            set
            {
                _brdDadosUser = value;
                NotifyOfPropertyChange(() => BrdDadosUser);
            }
        }

        public bool BrdRemoteUserData
        {
            get { return _brdRemoteUserData; }
            set
            {
                _brdRemoteUserData = value;
                NotifyOfPropertyChange(() => BrdRemoteUserData);
            }
        }

        public bool BrdSetOptions
        {
            get { return _brdSetOptions; }
            set
            {
                _brdSetOptions = value;
                NotifyOfPropertyChange(() => BrdSetOptions);
            }
        }

        public bool BrdSelectDb
        {
            get { return _brdSelectDb; }
            set
            {
                _brdSelectDb = value;
                NotifyOfPropertyChange(() => BrdSelectDb);
            }
        }

        #endregion

        #region UserDadosSQL

        private string _pboxSqlPwd;

        private string _txtNomeUser;

        public string PboxSqlPwd
        {
            get { return _pboxSqlPwd; }
            set
            {
                _pboxSqlPwd = value;
                NotifyOfPropertyChange(() => PboxSqlPwd);
            }
        }

        public string TxtNomeUser
        {
            get { return _txtNomeUser; }
            set
            {
                _txtNomeUser = value;
                NotifyOfPropertyChange(() => TxtNomeUser);
            }
        }

        #endregion

        #region CBProperties

        private BindableCollection<string> _cbDatabase;
        private BindableCollection<string> _cbInstanciasSQL;
        private string _selectedCbDatabase;

        private string _selectedCbInstanciasSQL;

        public BindableCollection<string> CbInstanciasSQL
        {
            get { return _cbInstanciasSQL; }
            set
            {
                _cbInstanciasSQL = value;
                NotifyOfPropertyChange(() => CbInstanciasSQL);
            }
        }

        public string SelectedCbInstanciasSQL
        {
            get { return _selectedCbInstanciasSQL; }
            set
            {
                _selectedCbInstanciasSQL = value;
                NotifyOfPropertyChange(() => SelectedCbInstanciasSQL);
                if (!string.IsNullOrEmpty(SelectedCbInstanciasSQL))
                {
                    BrdDadosUser = true;
                }
            }
        }

        public BindableCollection<string> CbDatabase
        {
            get { return _cbDatabase; }
            set
            {
                _cbDatabase = value;
                NotifyOfPropertyChange(() => CbDatabase);
            }
        }

        public string SelectedCbDatabase
        {
            get { return _selectedCbDatabase; }
            set
            {
                _selectedCbDatabase = value;
                NotifyOfPropertyChange(() => SelectedCbDatabase);
                if (!string.IsNullOrEmpty(SelectedCbDatabase))
                {
                    if (BrdRemoteUserData)
                    {
                        ShowModalGetResult();
                        //_utilities.SaveConfigData("PHCDATA", SelectedCbInstanciasSQL, SelectedcbDatabase, "", TxtNomeUser, PboxSqlPwd);
                    }
                    else
                    {
                        ShowModalGetResult();
                        //_utilities.SaveConfigData("PHCDATA", SelectedCbInstanciasSQL, SelectedCbDatabase, "localUser", "", "");
                    }
                    //invocar funcao para guardar a connectionstring
                    //_utilities.SaveConfigData("PHCData",SelectedCbInstanciasSQL,SelectedcbDatabase);
                    // _utilities.SaveConfigData("PHCDATA", SelectedCbInstanciasSQL, SelectedcbDatabase, "localUser","","");
                }
            }
        }

        #endregion

        #endregion

        #region Ctor

        //[ImportingConstructor]
        public ServerConfigViewModel()
        {
            DisplayName = "ServerConfig";
        }

        #endregion

        #region Metodos

        public void ShowModalGetResult()
        {
            var modalD = IoC.Get<ModalDialogViewModel>();
            modalD.TituloModal = "Configuracao Dados Sql";
            modalD.MensagemModal = "Deseja Guardar os dados configuracao SQL?";
            modalD.ModalWidth = 250;
            modalD.ModalHeight = 250;
            var result = WindowManagerWindow.ShowDialog(modalD);
        }

        public void ObtemUser()
        {
            Mouse.OverrideCursor = Cursors.Wait;

            TxtNomeUser = _utilities.DevolveUtilizadorCurrente();

            //salva a sqlconnection ifelse

            _utilities.SaveConfigData("DbTerminalContext", SelectedCbInstanciasSQL, "IFDB", "localUser", "", "");

            //
            //chama a lista de bases dados invoca o modelo if else para obter a base dados

            // var x = _utilities.GetDataBasesFromInstance(SelectedCbInstanciasSQL);
            BindableCollection<string> x = _dataService.GetDataBasesFromInstance(SelectedCbInstanciasSQL);
            CbDatabase = x;
            //

            //
            BrdSelectDb = true;
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        public void GuardaConfig()
        {
        }

        public void MostraDados()
        {
            BrdRemoteUserData = true;
        }


        public void SetLocalOptions()
        {
            var x = _utilities.GetLocalSqlServers();
            if (x.Count > 0)
            {
                CbInstanciasSQL = x;
                BrdIsVisible = true;
            }
        }

        public void SetRemoteOptions()
        {
            if (CbInstanciasSQL != null)
            {
                if (CbInstanciasSQL.Count > 0)
                {
                    CbInstanciasSQL.Clear();
                }
            }
            //BindableCollection<string> t = _utilities.DevolveServidoresRemotos();
            //var t= _utilities.DevolveServidoresRemotos();
        }

        public void PasswordChanged(Control value)
        {
            if (!(value is PasswordBox)) return;
            PboxSqlPwd = (value as PasswordBox).Password;
        }

        public void SetCustomSqlConfig()
        {
            if ((string.IsNullOrEmpty(TxtNomeUser)) || (string.IsNullOrEmpty(PboxSqlPwd)))
            {
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.Erro,
                                                                              "Uma das opçoes nao foi preenchida.\n " +
                                                                              "por favor verifique se preencheu os campos para o nome de utilizador ou password para ligar á base dados"));
            }
            else
            {
                _utilities.SaveConfigData("DbTerminalContext", SelectedCbInstanciasSQL, "IFDB", "", TxtNomeUser,
                                          PboxSqlPwd);
                // var x = _utilities.GetDataBasesFromInstance(SelectedCbInstanciasSQL);
                var x = _dataService.GetDataBasesFromInstance(SelectedCbInstanciasSQL);
                CbDatabase = x;
            }
        }


        private void BackendEventDispatcher()
        {
            var x = new {SQLConfigOK = true};
            // se for user currente do windows adicionar a propriedade Integrated Security=SSPI ao dynamic e remover a password 
            //var x = new {SQLConfigOK= true, DBName= SelectedcbDataBasePHC, SqlUserName = UserNameSQL, NomeSqlServer = InstanciaSqlServer, SqlPass = PasswordSql};

            EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.ConfiguracaoSQL, x));
        }

        #endregion

        #region Implementation of IHandle<EventoModal>

        public void Handle(EventoModal message)
        {
            if (message.EventoSelected == TipoEventoModal.Ok)
            {
                if (BrdRemoteUserData)
                {
                    _utilities.SaveConfigData("PHCDATA", SelectedCbInstanciasSQL, SelectedCbDatabase, "", TxtNomeUser,
                                              PboxSqlPwd);
                }
                else
                {
                    _utilities.SaveConfigData("PHCDATA", SelectedCbInstanciasSQL, SelectedCbDatabase, "localUser", "",
                                              "");
                }
                BackendEventDispatcher();
                //brdSetOptions = true;
            }
        }

        protected override void OnActivate()
        {
            EventAggregationProvider.Aggregator.Subscribe(this);
            base.OnActivate();
        }

        protected override void OnDeactivate(bool close)
        {
            EventAggregationProvider.Aggregator.Unsubscribe(this);
            base.OnDeactivate(close);
        }

        #endregion

        //no remote(remover a opcao remota)
    }
}