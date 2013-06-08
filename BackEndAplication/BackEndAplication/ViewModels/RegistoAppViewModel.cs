using System.ComponentModel.Composition;
using BackEndAplication.Events;
using BackEndAplication.Service;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (RegistoAppViewModel))]
    public class RegistoAppViewModel : Screen
    {
        #region propriedadesView

        private static readonly RemoteService Service = RemoteService.GetInstance();


        private string _txtChave;


        private string _txtMailCliente;

        public string TxtChave
        {
            get { return _txtChave; }
            set
            {
                _txtChave = value;
                NotifyOfPropertyChange(() => TxtChave);
            }
        }

        public string TxtMailCliente
        {
            get { return _txtMailCliente; }

            set
            {
                _txtMailCliente = value;
                NotifyOfPropertyChange(() => TxtMailCliente);
            }
        }

        #endregion

        #region metodos

        public RegistoAppViewModel()
        {
            DisplayName = "RegistoApp";
        }


        public void ValidateSerial()
        {
            if ((string.IsNullOrEmpty(TxtChave)) || (string.IsNullOrEmpty(TxtMailCliente)))
            {
                var x =
                    new {RegistoAppOK = true, SerialCliente = "1111-1111-1111-1111", ClienteMail = "bananas@mail.pt"};
                EventAggregationProvider.Aggregator.Publish(new EventoBackend(EventoTipo.RegistoAplicacao, x));
            }
            else
            {
                Service.ValidateData(TxtChave, TxtMailCliente);
            }
        }

        #endregion
    }
}