using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (MessageBoxViewModel))]
    public class MessageBoxViewModel : Screen
    {
        private string _messageboxmessage;


        private string _messageboxtitle;

        public MessageBoxViewModel()
        {
            DisplayName = "Dialogo";
        }

        public string MessageboxMessage
        {
            get { return _messageboxmessage; }
            set
            {
                _messageboxmessage = value;
                NotifyOfPropertyChange(() => MessageboxMessage);
            }
        }

        public string MessageTitle
        {
            get { return _messageboxtitle; }
            set
            {
                _messageboxtitle = value;
                NotifyOfPropertyChange(() => MessageTitle);
            }
        }


        public string Result { get; set; }


        public void Ok()
        {
            Result = "OK";
            // _result = MessageBoxResult.OK;
            TryClose();
            //TryClose(true);
        }
    }
}