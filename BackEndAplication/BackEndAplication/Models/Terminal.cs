using Caliburn.Micro;

namespace BackEndAplication.Models
{
    public class Terminal : PropertyChangedBase
    {
        #region Dados Informativos

        private string _dossierInterno;
        private string _nomeVendedor;
        private string _terminalId;

        public string TerminalId
        {
            get { return _terminalId; }

            set
            {
                _terminalId = value;
                NotifyOfPropertyChange(() => TerminalId);
            }
        }

        public string NomeVendedor
        {
            get { return _nomeVendedor; }
            set
            {
                _nomeVendedor = value;
                NotifyOfPropertyChange(() => NomeVendedor);
            }
        }


        public string DossierInterno
        {
            get { return _dossierInterno; }
            set
            {
                _dossierInterno = value;
                NotifyOfPropertyChange(() => DossierInterno);
            }
        }

        #endregion

        #region DadosEncomendas

        private int _numEncomendasFinal;
        private int _numEncomendasInicial;

        public int NumeroEncomendasInicial
        {
            get { return _numEncomendasInicial; }
            set
            {
                _numEncomendasInicial = value;
                NotifyOfPropertyChange(() => NumeroEncomendasInicial);
            }
        }

        public int NumeroEncomendasFinal
        {
            get { return _numEncomendasFinal; }
            set
            {
                _numEncomendasFinal = value;
                NotifyOfPropertyChange(() => NumeroEncomendasFinal);
            }
        }

        #endregion

        #region DadosClientes

        private int _numClienteFinal;
        private int _numClienteInicial;

        public int NumeroClienteInicial
        {
            get { return _numClienteInicial; }
            set
            {
                _numClienteInicial = value;
                NotifyOfPropertyChange(() => NumeroClienteInicial);
            }
        }

        public int NumeroClienteFinal
        {
            get { return _numClienteFinal; }
            set
            {
                _numClienteFinal = value;
                NotifyOfPropertyChange(() => NumeroClienteFinal);
            }
        }

        #endregion

        #region DadosArmazem

        private string _numArmazemEnvio;
        private string _numArmazemRegisto;

        public string ArmazemRegisto
        {
            get { return _numArmazemRegisto; }
            set
            {
                _numArmazemRegisto = value;
                NotifyOfPropertyChange(() => ArmazemRegisto);
            }
        }

        public string ArmazemEnvio
        {
            get { return _numArmazemEnvio; }
            set
            {
                _numArmazemEnvio = value;
                NotifyOfPropertyChange(() => ArmazemEnvio);
            }
        }

        #endregion
    }
}