using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Globalization;
using BackEndAplication.Events;
using BackEndAplication.Models.TerminalDBModel;
using BackEndAplication.Service;
using BackEndAplication.Utilities;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof(DadosPhcViewModel))]
    public class DadosPhcViewModel : Screen, IHandle<EventoSelectedData>
    {
        #region classvars

        private readonly DataService _service = DataService.GetInstance();

        #endregion

        #region Propriedades

        private bool _isUpdatingDataPhc;

        private BindableCollection<int> _cbNumVendedor;
        private bool _isDadosPhcChanged;
        private bool _ischkMostraDataLinhas;
        private bool _ischkUsaPrecoC;
        private bool _ischkUsaPrecoD;
        private bool _ischkUsaPrecoQ;
        private bool _ischkUsaPrecoT;
        private bool _ischkUsaPrecoU;
        private string _lblNomeDossier;
        private int _selectedCbNumVendedor;
        private TbOpcoesTerminal _selectedOpcoesTerminal;
        private TbTerminal _selectedPhcTerminal;
        private string _txtEncomendasRetidas;
        private string _txtNumMaxDesconto;
        private string _txtNumVendedor;

       



        public bool IsUpdatingDataPhc
        {
            get { return _isUpdatingDataPhc; }
            set
            {
                _isUpdatingDataPhc = value;
                NotifyOfPropertyChange(() => IsUpdatingDataPhc);
            }
        }
        public string LblNomeDossier
        {
            get { return _lblNomeDossier; }
            set
            {
                _lblNomeDossier = value;
                NotifyOfPropertyChange(() => LblNomeDossier);
            }
        }

        public bool IsDadosPhcChanged
        {
            get { return _isDadosPhcChanged; }
            set
            {
                if (value == _isDadosPhcChanged) return;
                _isDadosPhcChanged = value;
                NotifyOfPropertyChange(() => IsDadosPhcChanged);
            }
        }

        public bool IschkUsaPrecoU
        {
            get { return _ischkUsaPrecoU; }
            set
            {
                _ischkUsaPrecoU = value;
                NotifyOfPropertyChange(() => IschkUsaPrecoU);
            }
        }

        public bool IschkUsaPrecoD
        {
            get { return _ischkUsaPrecoD; }
            set
            {
                _ischkUsaPrecoD = value;
                NotifyOfPropertyChange(() => IschkUsaPrecoD);
            }
        }

        public bool IschkUsaPrecoT
        {
            get { return _ischkUsaPrecoT; }
            set
            {
                _ischkUsaPrecoT = value;
                NotifyOfPropertyChange(() => IschkUsaPrecoT);
            }
        }

        public bool IschkUsaPrecoQ
        {
            get { return _ischkUsaPrecoQ; }
            set
            {
                _ischkUsaPrecoQ = value;
                NotifyOfPropertyChange(() => IschkUsaPrecoQ);
            }
        }

        public bool IschkUsaPrecoC
        {
            get { return _ischkUsaPrecoC; }
            set
            {
                _ischkUsaPrecoC = value;
                NotifyOfPropertyChange(() => IschkUsaPrecoC);
            }
        }


        public string TxtNumMaxDesconto
        {
            get { return _txtNumMaxDesconto; }
            set
            {
                _txtNumMaxDesconto = value;
                NotifyOfPropertyChange(() => TxtNumMaxDesconto);
            }
        }

        public string TxtEncomendasRetidas
        {
            get { return _txtEncomendasRetidas; }
            set
            {
                _txtEncomendasRetidas = value;
                NotifyOfPropertyChange(() => TxtEncomendasRetidas);
            }
        }

        public bool IschkMostraDataLinhas
        {
            get { return _ischkMostraDataLinhas; }
            set
            {
                _ischkMostraDataLinhas = value;
                NotifyOfPropertyChange(() => IschkMostraDataLinhas);
            }
        }


        protected TbTerminal PhcSelectedTerminal
        {
            get { return _selectedPhcTerminal; }
            set
            {
                _selectedPhcTerminal = value;
                NotifyOfPropertyChange(() => PhcSelectedTerminal);
            }
        }

        public TbOpcoesTerminal PhcSelectedOp
        {
            get { return _selectedOpcoesTerminal; }
            set
            {
                _selectedOpcoesTerminal = value;
                NotifyOfPropertyChange(() => PhcSelectedOp);
            }
        }


        public BindableCollection<int> CbNumVendedor
        {
            get { return _cbNumVendedor; }
            set
            {
                _cbNumVendedor = value;
                NotifyOfPropertyChange(() => CbNumVendedor);
            }
        }

        public int SelectedCbNumVendedor
        {
            get { return _selectedCbNumVendedor; }
            set
            {
                if (_selectedCbNumVendedor == value) return;
                _selectedCbNumVendedor = value;
                NotifyOfPropertyChange(() => SelectedCbNumVendedor);
                TxtNumVendedor = _service.SetNomeVendedor(SelectedCbNumVendedor);
                //IsDadosTerminalChanged = true;
            }
        }


        public string TxtNumVendedor
        {
            get { return _txtNumVendedor; }
            set
            {
                if (_txtNumVendedor == value) return;
                _txtNumVendedor = value;
                NotifyOfPropertyChange(() => TxtNumVendedor);
            }
        }

        #region OpcoesTerminal

        #endregion

        #region PHC

        #region PHCFiltrosClientes

        private BindableCollection<string> _cbFiltrosPhcCliente;

        private string _selectedCbFiltrosPhcCliente;

        public BindableCollection<string> CbFiltrosPhcCliente
        {
            get { return _cbFiltrosPhcCliente; }
            set
            {
                _cbFiltrosPhcCliente = value;
                NotifyOfPropertyChange(() => CbFiltrosPhcCliente);
            }
        }

        public string SelectedCbFiltrosPhcCliente
        {
            get { return _selectedCbFiltrosPhcCliente; }
            set
            {
                _selectedCbFiltrosPhcCliente = value;
                NotifyOfPropertyChange(() => SelectedCbFiltrosPhcCliente);
            }
        }

        #endregion

        #region PHCFiltrosStocks

        private BindableCollection<string> _cbFiltrosPhcStock;


        private string _selectedCbFiltrosPhcStock;

        public BindableCollection<string> CbFiltrosPhcStock
        {
            get { return _cbFiltrosPhcStock; }
            set
            {
                _cbFiltrosPhcStock = value;
                NotifyOfPropertyChange(() => CbFiltrosPhcStock);
            }
        }

        public string SelectedCbFiltrosPhcStock
        {
            get { return _selectedCbFiltrosPhcStock; }
            set
            {
                _selectedCbFiltrosPhcStock = value;
                NotifyOfPropertyChange(() => SelectedCbFiltrosPhcStock);
            }
        }

        #endregion

        private BindableCollection<int> _cbNumDossier;
        private string _numTerminalId;

        private int _selectedCbNumDossier;

        private string _txtNomeDossier;

        public BindableCollection<int> CbNumDossier
        {
            get { return _cbNumDossier; }
            set
            {
                _cbNumDossier = value;
                NotifyOfPropertyChange(() => CbNumDossier);
            }
        }

        public int SelectedCbNumDossier
        {
            get { return _selectedCbNumDossier; }
            set
            {
                _selectedCbNumDossier = value;
                NotifyOfPropertyChange(() => SelectedCbNumDossier);
                _txtNumMaxDesconto =
                    _service.DevolveValorDesconto(SelectedCbNumDossier).ToString(CultureInfo.InvariantCulture);
                TxtNomeDossier = _service.GetNomeDossier(SelectedCbNumDossier);
            }
        }

        public string TxtNomeDossier
        {
            get { return _txtNomeDossier; }
            set
            {
                _txtNomeDossier = value;
                NotifyOfPropertyChange(() => TxtNomeDossier);
            }
        }


        public string NumTerminalId
        {
            get { return _numTerminalId; }
            set
            {
                _numTerminalId = value;
                NotifyOfPropertyChange(() => NumTerminalId);
            }
        }

        #endregion

        #endregion

        #region ControlsVisibility

        private bool _isTxtEncomendasRetidas;
        private bool _ischkAltPrecoVenda;
        private bool _ischkEliminaEncomenda;
        private bool _ischkInsereNovaLinha;
        private bool _ischkIntroCompSinc;
        private bool _ischkSincCcNaoRegula;
        private bool _isrbEliminaSinc;
        private bool _isrbReterTodas;

        private bool _isrbReterUltimas;

        public bool IsrbReterTodas
        {
            get { return _isrbReterTodas; }
            set
            {

                _isrbReterTodas = value;

                NotifyOfPropertyChange(() => IsrbReterTodas);

                IsTxtEncomendasRetidas = false;


            }
        }

        public bool IsrbReterUltimas
        {
            get { return _isrbReterUltimas; }
            set
            {
                _isrbReterUltimas = value;

                NotifyOfPropertyChange(() => IsrbReterUltimas);
                IsTxtEncomendasRetidas = true;
            }
        }

        public bool IsrbEliminaSinc
        {
            get { return _isrbEliminaSinc; }
            set
            {

                _isrbEliminaSinc = value;

                NotifyOfPropertyChange(() => IsrbEliminaSinc);
                IsTxtEncomendasRetidas = false;
            }
        }

        public bool IsTxtEncomendasRetidas
        {
            get { return _isTxtEncomendasRetidas; }
            set
            {

                _isTxtEncomendasRetidas = value;
                NotifyOfPropertyChange(() => IsTxtEncomendasRetidas);
            }
        }


        public bool IschkSincCcNaoRegula
        {
            get { return _ischkSincCcNaoRegula; }
            set
            {
                if (value == _ischkSincCcNaoRegula) return;
                _ischkSincCcNaoRegula = value;
                NotifyOfPropertyChange(() => IschkSincCcNaoRegula);
            }
        }

        public bool IschkEliminaEncomenda
        {
            get { return _ischkEliminaEncomenda; }
            set
            {
                if (value == _ischkEliminaEncomenda) return;
                _ischkEliminaEncomenda = value;
                NotifyOfPropertyChange(() => IschkEliminaEncomenda);
            }
        }

        public bool IschkAltPrecoVenda
        {
            get { return _ischkAltPrecoVenda; }
            set
            {
                if (value == _ischkAltPrecoVenda) return;
                _ischkAltPrecoVenda = value;
                NotifyOfPropertyChange(() => IschkAltPrecoVenda);
            }
        }

        public bool IschkIntroCompSinc
        {
            get { return _ischkIntroCompSinc; }
            set
            {
                if (value == _ischkIntroCompSinc) return;
                _ischkIntroCompSinc = value;
                NotifyOfPropertyChange(() => IschkIntroCompSinc);
            }
        }

        public bool IschkInsereNovaLinha
        {
            get { return _ischkInsereNovaLinha; }
            set
            {
                if (value == _ischkInsereNovaLinha) return;
                _ischkInsereNovaLinha = value;
                NotifyOfPropertyChange(() => IschkInsereNovaLinha);
            }
        }

        #endregion

        #region ControlsProperties

        private string _txtArmazemEnvio;
        private string _txtArmazemRegisto;
        private string _txtEncomendaFinal;
        private string _txtEncomendaInicio;
        private string _txtNumeroFinalCliente;
        private string _txtNumeroInicialCliente;

        public string TxtEncomendaInicio
        {
            get { return _txtEncomendaInicio; }
            set
            {
                if (value == _txtEncomendaInicio) return;
                _txtEncomendaInicio = value;
                NotifyOfPropertyChange(() => TxtEncomendaInicio);
            }
        }

        public string TxtEncomendaFinal
        {
            get { return _txtEncomendaFinal; }
            set
            {
                if (value == _txtEncomendaFinal) return;
                _txtEncomendaFinal = value;
                NotifyOfPropertyChange(() => TxtEncomendaFinal);
            }
        }

        public string TxtArmazemRegisto
        {
            get { return _txtArmazemRegisto; }
            set
            {
                if (value == _txtArmazemRegisto) return;
                _txtArmazemRegisto = value;
                NotifyOfPropertyChange(() => TxtArmazemRegisto);
            }
        }

        public string TxtArmazemEnvio
        {
            get { return _txtArmazemEnvio; }
            set
            {
                if (value == _txtArmazemEnvio) return;
                _txtArmazemEnvio = value;
                NotifyOfPropertyChange(() => TxtArmazemEnvio);
            }
        }

        public string TxtNumeroInicialCliente
        {
            get { return _txtNumeroInicialCliente; }
            set
            {
                if (value == _txtNumeroInicialCliente) return;
                _txtNumeroInicialCliente = value;
                NotifyOfPropertyChange(() => TxtNumeroInicialCliente);
            }
        }

        public string TxtNumeroFinalCliente
        {
            get { return _txtNumeroFinalCliente; }
            set
            {
                if (value == _txtNumeroFinalCliente) return;
                _txtNumeroFinalCliente = value;
                NotifyOfPropertyChange(() => TxtNumeroFinalCliente);
            }
        }

        #endregion

        #region Metodos

        //public void InitData()
        //{
        //    LoadDataAsync();
        //}

        //private void LoadDataAsync()
        //{
        //    //Task<bool>.Factory.StartNew(LoadFiltros);
        //    //Task<bool>.Factory.StartNew(LoadDataDossiers);
        //}


        public void ShowHelp()
        {
            Coroutine.BeginExecute(MostraInfoDialogo().GetEnumerator());
        }


        public IEnumerable<IResult> MostraInfoDialogo()
        {
            yield return new ShowDialog<MessageBoxViewModel>()
                .ConfigureWith(x => x.MessageboxMessage = "Antes de escolher qualquer filtro, verifique se estes se encontram no seguinte formato:\n"+
            "INACTIVO  <>  @0  and  vendedor  = @1,bol1,r10.00 \n"+
            "substitua os valores da seguinte forma:\n" +
            "bol para valores booleanos, r para numeros decimais,\n" +
                                                          " i para valores inteiros e" +
                                                          "\n ch sem plicas para caracteres",
                               t => t.MessageTitle = "Informacao Backend Application");
        }
        #region CarregaDados
        private bool LoadFiltros()
        {
            CbFiltrosPhcCliente = _service.LoadFiltrosClientes();
            CbFiltrosPhcStock = _service.LoadFiltrosStocks();
            CbNumDossier = _service.CarregaDossiersInternos();
            CbNumVendedor = _service.LoadVendedores();



            return CbFiltrosPhcCliente != null && CbFiltrosPhcStock != null && CbNumVendedor != null;
        }
        #endregion

        #region FrameworkMethod
        protected override void OnActivate()
        {

            EventAggregationProvider.Aggregator.Subscribe(this);
            base.OnActivate();
            //HelpImgpath = new Uri(@"BackEndAplication;component/imgs/Info.png", UriKind.RelativeOrAbsolute);
            LoadFiltros();
        }

        protected override void OnDeactivate(bool close)
        {
            EventAggregationProvider.Aggregator.Unsubscribe(this);

            //
            LimpaComponentes();
            //
            base.OnDeactivate(close);
        }
        #endregion

        #region Limpeza
        private void LimpaComponentes()
        {
            LblNomeDossier = null;
            IsDadosPhcChanged = false;
            IschkUsaPrecoU = false;
            IschkUsaPrecoD = false;
            _ischkUsaPrecoT = false;
            IschkUsaPrecoQ = false;
            IschkUsaPrecoC = false;
            TxtNumMaxDesconto = null;
            TxtEncomendasRetidas = null;
            IschkMostraDataLinhas = false;
            PhcSelectedTerminal = null;
            PhcSelectedOp = null;
            SelectedCbFiltrosPhcCliente = null;
            CbFiltrosPhcStock = null;
            SelectedCbFiltrosPhcStock = null;
            TxtNomeDossier = null;
            NumTerminalId = null;
            IsrbReterTodas = false;
            IsrbReterUltimas = false;
            IsrbEliminaSinc = false;
            IsTxtEncomendasRetidas = false;
            IschkSincCcNaoRegula = false;
            IschkEliminaEncomenda = false;
            IschkAltPrecoVenda = false;
            IschkIntroCompSinc = false;
            IschkInsereNovaLinha = false;
            TxtEncomendaInicio = null;
            TxtEncomendaFinal = null;
            TxtArmazemRegisto = null;
            TxtArmazemEnvio = null;
            TxtNumeroInicialCliente = null;
            TxtNumeroFinalCliente = null;
            TxtNumVendedor = null;
            IsUpdatingDataPhc = false;
        }
        #endregion

        #region CreateUpdate
        public void SaveDadosPhc()
        {

            TbOpcoesTerminal tmpOpterminal;

            if (IsUpdatingDataPhc)
            {
                tmpOpterminal = new TbOpcoesTerminal
                {
                    Id = PhcSelectedOp.Id,
                    PhcNomeFiltroArtigos = DevolveDefaultFiltros("St", SelectedCbFiltrosPhcStock),
                    PhcNomeFiltroClientes = DevolveDefaultFiltros("CL", SelectedCbFiltrosPhcCliente),
                    ArmazemEnvio = DevolveArmazemDefault(TxtArmazemEnvio),
                    ArmazemRegisto = DevolveArmazemDefault(TxtArmazemRegisto),
                    CriaLinhaEncomenda = IschkInsereNovaLinha,
                    UsaPreco5 = IschkUsaPrecoC,
                    UsaPreco2 = IschkUsaPrecoD,
                    UsaPreco1 = IschkUsaPrecoU,
                    UsaPreco3 = IschkUsaPrecoT,
                    UsaPreco4 = IschkUsaPrecoQ,
                    AlterarPrecoVenda = IschkAltPrecoVenda,
                    EliminarEncomendas = IschkEliminaEncomenda,
                    NumeroFimClientes = DevolveDefaultFimCliente(TxtNumeroFinalCliente),
                    NumeroInicioClientes = DevolveDefaultInicioClientes(TxtNumeroInicialCliente),
                    NumeroFimEncomendas = DevolveDefaultFimEncomenda(TxtEncomendaFinal),
                    NumeroInicioEncomendas = DevolveDefaultInicioEncomenda(TxtEncomendaInicio),
                    NumVendedor = DevolveValorDefaultNumVendedor(SelectedCbNumVendedor),
                    NomeVendedor = DevolveValorDefaultNomeVendedor(TxtNumVendedor),
                    NumMaxDescontos = Convert.ToInt32(TxtNumMaxDesconto),
                    NumeroEncomendasRetidas = DevolveEncomendas(TxtEncomendasRetidas),
                    MostrarDataLinhas = IschkMostraDataLinhas,
                    IntroduzComponentes = IschkIntroCompSinc,
                    TipoRetencaoEncomendas = DevolveRetencaoEncomendas(),
                    PhcNumDossierInterno = DevolveDefaultNumeroDossier(),
                    PhcNomeDossierInterno = DevolveDefaultNomeDossier(),
                    IniciaisUs = DevolveDefaultIniciaisUs(),
                    SincronizaCcNaoRegula = IschkSincCcNaoRegula
                };
                EventAggregationProvider.Aggregator.Publish(new EventoChangeActiveViewTerminal(AccaoEfectuada.UpdatedPhcData, null, tmpOpterminal));
            }
            else
            {
                tmpOpterminal = new TbOpcoesTerminal
                {
                    Id = Guid.NewGuid(),
                    PhcNomeFiltroArtigos = DevolveDefaultFiltros("St", SelectedCbFiltrosPhcStock),
                    PhcNomeFiltroClientes = DevolveDefaultFiltros("CL", SelectedCbFiltrosPhcCliente),
                    ArmazemEnvio = DevolveArmazemDefault(TxtArmazemEnvio),
                    ArmazemRegisto = DevolveArmazemDefault(TxtArmazemRegisto),
                    CriaLinhaEncomenda = IschkInsereNovaLinha,
                    UsaPreco5 = IschkUsaPrecoC,
                    UsaPreco2 = IschkUsaPrecoD,
                    UsaPreco1 = IschkUsaPrecoU,
                    UsaPreco3 = IschkUsaPrecoT,
                    UsaPreco4 = IschkUsaPrecoQ,
                    AlterarPrecoVenda = IschkAltPrecoVenda,
                    EliminarEncomendas = IschkEliminaEncomenda,
                    NumeroFimClientes = DevolveDefaultFimCliente(TxtNumeroFinalCliente),
                    NumeroInicioClientes = DevolveDefaultInicioClientes(TxtNumeroInicialCliente),
                    NumeroFimEncomendas = DevolveDefaultFimEncomenda(TxtEncomendaFinal),
                    NumeroInicioEncomendas = DevolveDefaultInicioEncomenda(TxtEncomendaInicio),
                    NumVendedor = DevolveValorDefaultNumVendedor(SelectedCbNumVendedor),
                    NomeVendedor = DevolveValorDefaultNomeVendedor(TxtNumVendedor),
                    NumMaxDescontos = Convert.ToInt32(TxtNumMaxDesconto),
                    NumeroEncomendasRetidas = DevolveEncomendas(TxtEncomendasRetidas),
                    MostrarDataLinhas = IschkMostraDataLinhas,
                    IntroduzComponentes = IschkIntroCompSinc,
                    TipoRetencaoEncomendas = DevolveRetencaoEncomendas(),
                    PhcNumDossierInterno = DevolveDefaultNumeroDossier(),
                    PhcNomeDossierInterno = DevolveDefaultNomeDossier(),
                    IniciaisUs = DevolveDefaultIniciaisUs(),

                    SincronizaCcNaoRegula = IschkSincCcNaoRegula
                };

                EventAggregationProvider.Aggregator.Publish(new EventoChangeActiveViewTerminal(AccaoEfectuada.AddedPhcData,
                                                                                          null, tmpOpterminal));
            }

        }



        #endregion

        #region SetDefaultValues

        private string DevolveDefaultIniciaisUs()
        {
            int? valor = SelectedCbNumVendedor;

            return valor.HasValue ? _service.GetIniciaisPhc(SelectedCbNumVendedor) : "NOV";
        }

        private static int DevolveDefaultInicioEncomenda(string value)
        {
            return string.IsNullOrEmpty(value) || (value == "Sem Valor definido") ? 0 : Convert.ToInt32(value);
        }

        private static int DevolveDefaultFimEncomenda(string value)
        {
            return string.IsNullOrEmpty(value) || (value == "Sem Valor definido") ? 0 : Convert.ToInt32(value);
        }

        private static int DevolveDefaultInicioClientes(string value)
        {
            return string.IsNullOrEmpty(value) || (value == "Sem Valor definido") ? 0 : Convert.ToInt32(value);
        }

        private static int DevolveDefaultFimCliente(string value)
        {
            return string.IsNullOrEmpty(value) || (value == "Sem Valor definido") ? 0 : Convert.ToInt32(value);
        }

        private decimal DevolveArmazemDefault(string value)
        {
            return string.IsNullOrEmpty(value) ? _service.DevolveArmazem(SelectedCbNumDossier) : Convert.ToDecimal(value);
        }

        private static string DevolveValorDefaultNomeVendedor(string value)
        {
            return string.IsNullOrEmpty(value) ? "Sem Vendedor definido" : value;
        }

        private static int DevolveValorDefaultNumVendedor(int? value)
        {
            return value.HasValue ? 0 : (int)value;
        }


        private int DevolveDefaultNumeroDossier()
        {
            return SelectedCbNumDossier;
        }

        private string DevolveDefaultNomeDossier()
        {
            return string.IsNullOrEmpty(TxtNomeDossier) ? "Sem Dossier Definido" : TxtNomeDossier;
        }

        private string DevolveRetencaoEncomendas()
        {
            if (!IsrbReterTodas)
            {
                return IsrbReterUltimas ? "U" : "N";
            }
            return "T";
        }

        private static int DevolveEncomendas(string value)
        {
            return string.IsNullOrEmpty(value) ? 0 : Convert.ToInt32(value);
        }

        private string DevolveDefaultFiltros(string valueFiltro, string value)
        {
            if ((string.IsNullOrEmpty(value)) || (value == "Sem valor Definido"))
            {
                return "Sem valor Definido";
            }
            return valueFiltro == "St" ? _service.DevolveStampFiltroStocks(value).Trim() : _service.DevolveStampFiltroClientes(value).Trim();


        }
        #endregion

        #region Cancel
        public void CancelData()
        {
            EventAggregationProvider.Aggregator.Publish(new EventoChangeActiveViewTerminal(AccaoEfectuada.Cancel));
        }
        #endregion
        #endregion

        #region Ctor

        public DadosPhcViewModel()
        {
            DisplayName = "DadosPhc";
        }

        #endregion

        #region Implementation of IHandle<EventoSelectedData>

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Handle(EventoSelectedData message)
        {
            if (message.TipoSelectedItem != TipoSelected.PhcDataSelected) return;
            PhcSelectedOp = message.SelectedDataOpcoes;
            PhcSelectedTerminal = message.SelectedDataTerminal;
            InjectProperties();
        }

        private void InjectProperties()
        {
            IsUpdatingDataPhc = true;
            TxtArmazemEnvio = PhcSelectedOp.ArmazemEnvio.ToString(CultureInfo.InvariantCulture);
            TxtArmazemRegisto = PhcSelectedOp.ArmazemRegisto.ToString(CultureInfo.InvariantCulture);
            TxtNumMaxDesconto = PhcSelectedOp.NumMaxDescontos.ToString(CultureInfo.InvariantCulture);
            TxtNomeDossier = PhcSelectedOp.PhcNomeDossierInterno;
            TxtEncomendaFinal = PhcSelectedOp.NumeroFimEncomendas.ToString(CultureInfo.InvariantCulture);
            TxtEncomendaInicio = PhcSelectedOp.NumeroInicioEncomendas.ToString(CultureInfo.InvariantCulture);
            TxtNumVendedor = PhcSelectedOp.NumVendedor.ToString(CultureInfo.InvariantCulture);
            TxtNumeroInicialCliente = PhcSelectedOp.NumeroInicioClientes.ToString(CultureInfo.InvariantCulture);
            TxtNumeroFinalCliente = PhcSelectedOp.NumeroFimClientes.ToString(CultureInfo.InvariantCulture);
            NumTerminalId = _service.DevolveNumTerminal(PhcSelectedOp.Id);

            switch (PhcSelectedOp.TipoRetencaoEncomendas)
            {
                case "T":
                    IsrbReterTodas = true;
                    IsTxtEncomendasRetidas = false;
                    break;
                case "U":
                    IsrbReterUltimas = true;
                    TxtEncomendasRetidas = PhcSelectedOp.NumeroEncomendasRetidas.ToString(CultureInfo.InvariantCulture);
                    IsTxtEncomendasRetidas = true;
                    break;
                case "N":
                    IsrbReterTodas = false;
                    IsrbReterUltimas = false;
                    IsrbEliminaSinc = true;
                    IsTxtEncomendasRetidas = false;
                    break;
            }

            if (PhcSelectedOp.AlterarPrecoVenda)
            {
                IschkAltPrecoVenda = true;
            }
            if (PhcSelectedOp.IntroduzComponentes)
            {
                IschkIntroCompSinc = true;
            }
            if (PhcSelectedOp.MostrarDataLinhas)
            {
                IschkMostraDataLinhas = true;
            }
            if (PhcSelectedOp.EliminarEncomendas)
            {
                IschkEliminaEncomenda = true;
            }
            if (PhcSelectedOp.SincronizaCcNaoRegula)
            {
                IschkSincCcNaoRegula = true;
            }
            if (PhcSelectedOp.UsaPreco1)
            {
                IschkUsaPrecoU = true;
            }
            if (PhcSelectedOp.UsaPreco2)
            {
                IschkUsaPrecoD = true;
            }
            if (PhcSelectedOp.UsaPreco3)
            {
                IschkUsaPrecoT = true;
            }
            if (PhcSelectedOp.UsaPreco4)
            {
                IschkUsaPrecoQ = true;
            }
            if (PhcSelectedOp.UsaPreco5)
            {
                IschkUsaPrecoC = true;
            }
            SelectedCbNumDossier = (int)PhcSelectedOp.PhcNumDossierInterno;
            SelectedCbNumVendedor = PhcSelectedOp.NumVendedor;
            SelectedCbFiltrosPhcCliente = InjectaFiltro("CL", PhcSelectedOp.PhcNomeFiltroClientes);
            SelectedCbFiltrosPhcStock = InjectaFiltro("ST", PhcSelectedOp.PhcNomeFiltroArtigos);

        }

        private string InjectaFiltro(string valueTipoFiltro, string value)
        {
            if ((string.IsNullOrEmpty(value)) || (value == "Sem valor Definido"))
            {
                return "Sem valor Definido";
            }
            return valueTipoFiltro == "CL" ? _service.DevolveNomeFiltroClientes(value) : _service.DevolveNomeFiltroStocks(value);
        }

        #endregion
    }
}