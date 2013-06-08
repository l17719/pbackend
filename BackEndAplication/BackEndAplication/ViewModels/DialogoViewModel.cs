using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (DialogoViewModel))]
    public class DialogoViewModel : Screen
    {
        private string _dialogMessage;
        private string _dialogoTitle;

        public DialogoViewModel()
        {
            DisplayName = "Dialogos";
        }

        public string Result { get; set; }

        public string DialogoTitle
        {
            get { return _dialogoTitle; }
            set
            {
                _dialogoTitle = value;
                NotifyOfPropertyChange(() => DialogoTitle);
            }
        }

        public string DialogoMensagem
        {
            get { return _dialogMessage; }
            set
            {
                _dialogMessage = value;
                NotifyOfPropertyChange(() => DialogoMensagem);
            }
        }


        public void DialogoOk()
        {
            Result = "OK";
            // _result = MessageBoxResult.OK;
            TryClose(true);
            //TryClose(true);
        }

        public void DialogoCancel()
        {
            Result = "Cancel";
            TryClose(false);
        }
    }
}