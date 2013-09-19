// Type: Caliburn.Micro.WindowManager
// Assembly: Caliburn.Micro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// Assembly location: C:\Users\joao\Documents\Visual Studio 2010\Projects\BackEndAplication\BackEndAplication\Lib\Caliburn.Micro.dll

using System.Windows;

namespace Caliburn.Micro
{
    public class WindowManager : IWindowManager
    {
        public WindowManager();
        public static DependencyObject GetSignificantView(DependencyObject view);
        public bool? ShowDialog(object rootModel, object context = null);
        public void Show(object rootModel, object context = null);
    }
}
