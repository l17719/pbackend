using Caliburn.Micro;

namespace BackEndAplication.Models
{
    public class Configuracao : PropertyChangedBase
    {
        #region Propriedades

        /// <summary>
        /// Propriedades da aplicacao
        /// </summary>
        private bool _configOk;


        private bool _sQlConfigurationOk;

        private bool _webserverconfigOk;

        public bool ConfigOk
        {
            get { return _configOk; }
            set
            {
                _configOk = value;
                NotifyOfPropertyChange(() => ConfigOk);
                // NotifyPropertyChanged(m => m.ConfigOk);
            }
        }

        public bool SQLConfigurationOk
        {
            get { return _sQlConfigurationOk; }
            set
            {
                _sQlConfigurationOk = value;
                NotifyOfPropertyChange(() => SQLConfigurationOk);
            }
        }

        public bool WebConfigurationOk
        {
            get { return _webserverconfigOk; }

            set
            {
                _webserverconfigOk = value;
                NotifyOfPropertyChange(() => WebConfigurationOk);
            }
        }

        #region ValidarDadosRegisto

        private bool _instalacaoServico;
        private bool _isRegistered;
        private bool _isValid;
        private string _mailCliente;
        private string _nomeSite;
        private string _nomeVirtualDir;
        private string _nomeappPool;


        private string _serial;

        public bool IsRegistered
        {
            get { return _isRegistered; }

            set
            {
                _isRegistered = value;
                NotifyOfPropertyChange(() => IsRegistered);
                //NotifyPropertyChanged(m => m.IsRegistered);
            }
        }

        public string Serial
        {
            get { return _serial; }
            set
            {
                _serial = value;
                NotifyOfPropertyChange(() => Serial);
                //NotifyPropertyChanged(m => m.Serial);
            }
        }

        public string MailCliente
        {
            get { return _mailCliente; }

            set
            {
                _mailCliente = value;
                NotifyOfPropertyChange(() => MailCliente);
                //NotifyPropertyChanged(m => m.MailCliente);
            }
        }

        public bool IsValid
        {
            get { return _isValid; }
            set
            {
                _isValid = value;
                NotifyOfPropertyChange(() => IsValid);
                // NotifyPropertyChanged(m => m.IsValid);
            }
        }


        public string NomeSite
        {
            get { return _nomeSite; }
            set
            {
                _nomeSite = value;
                NotifyOfPropertyChange(() => NomeSite);
            }
        }

        public string NomeApplicationPool
        {
            get { return _nomeappPool; }
            set
            {
                _nomeappPool = value;
                NotifyOfPropertyChange(() => NomeApplicationPool);
            }
        }

        public string NomeVirtualDir
        {
            get { return _nomeVirtualDir; }
            set
            {
                _nomeVirtualDir = value;
                NotifyOfPropertyChange(() => NomeVirtualDir);
            }
        }


        public bool InstalacaoServico
        {
            get { return _instalacaoServico; }
            set
            {
                _instalacaoServico = value;
                NotifyOfPropertyChange(() => InstalacaoServico);
            }
        }

        #endregion

        #region PHCDATA

        private string _phcdbName;
        private string _phcdbUserPwd;
        private string _phcdbuSer;

        private string _phcsqlservername;

        public string PhcdbName
        {
            get { return _phcdbName; }
            set
            {
                _phcdbName = value;
                NotifyOfPropertyChange(() => PhcdbName);
                //NotifyPropertyChanged(m => m.PhcdbName);
            }
        }

        public string Phcsqlservername
        {
            get { return _phcsqlservername; }
            set
            {
                _phcsqlservername = value;
                NotifyOfPropertyChange(() => Phcsqlservername);
                //NotifyPropertyChanged(m => m.Phcsqlservername);
            }
        }

        public string PhcdbuSer
        {
            get { return _phcdbuSer; }
            set
            {
                _phcdbuSer = value;
                NotifyOfPropertyChange(() => PhcdbuSer);
                //NotifyPropertyChanged(m => m._phcdbuSer);
            }
        }

        public string PhcdbUserPwd
        {
            get { return _phcdbUserPwd; }
            set
            {
                _phcdbUserPwd = value;
                NotifyOfPropertyChange(() => PhcdbuSer);
                //NotifyPropertyChanged(m => m._phcdbUserPwd);
            }
        }

        #endregion

        #endregion
    }
}