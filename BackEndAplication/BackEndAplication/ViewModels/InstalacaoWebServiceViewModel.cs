using System.ComponentModel.Composition;
using System.Threading.Tasks;
using BackEndAplication.Utilities;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (InstalacaoWebServiceViewModel))]
    public class InstalacaoWebServiceViewModel : Screen
    {
        #region Propriedades

        private readonly Utility _utility = Utility.GetInstance();
        private Task<bool> _installTask;

        #endregion

        public InstalacaoWebServiceViewModel()
        {
            DisplayName = "InstallWebService";
        }


        public void LoadUc()
        {
            _installTask = Task<bool>.Factory.StartNew(ProcessTask);

            if (_installTask.Result)
            {
                _installTask.Dispose();
            }
        }


        private bool ProcessTask()
        {
            return _utility.InstallWebService();
        }
    }
}