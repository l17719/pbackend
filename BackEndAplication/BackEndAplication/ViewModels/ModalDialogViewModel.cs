using System.ComponentModel.Composition;
using BackEndAplication.Events;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (ModalDialogViewModel))]
    public class ModalDialogViewModel : Screen
    {
        #region Properties

        private string _mensagemModal;
        private double _modalHeight;


        private double _modalWidth;
        private string _tituloModal;

        public double ModalHeight
        {
            get { return _modalHeight; }
            set
            {
                _modalHeight = value;
                NotifyOfPropertyChange(() => ModalHeight);
            }
        }

        public double ModalWidth
        {
            get { return _modalWidth; }
            set
            {
                _modalWidth = value;
                NotifyOfPropertyChange(() => ModalWidth);
            }
        }

        public string ResultadoModal { get; set; }

        public string TituloModal
        {
            get { return _tituloModal; }
            set
            {
                _tituloModal = value;
                NotifyOfPropertyChange(() => TituloModal);
            }
        }

        public string MensagemModal
        {
            get { return _mensagemModal; }
            set
            {
                _mensagemModal = value;
                NotifyOfPropertyChange(() => MensagemModal);
            }
        }

        #endregion

        #region Metodos

        public void ModalCancel()
        {
            //ResultadoModal = "Cancel";
            EventAggregationProvider.Aggregator.Publish(new EventoModal(TipoEventoModal.Cancel));
            TryClose(false);
        }

        public void ModalOk()
        {
            //ResultadoModal = "OK";
            EventAggregationProvider.Aggregator.Publish(new EventoModal(TipoEventoModal.Ok));
            TryClose(true);
        }

        #endregion
    }
}