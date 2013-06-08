using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace BackEndAplication.ViewModels
{
    [Export(typeof (InicioConfiguracaoViewModel))]
    public class InicioConfiguracaoViewModel : Screen
    {
        public InicioConfiguracaoViewModel()
        {
            DisplayName = "InicioConfiguracao";
        }
    }
}