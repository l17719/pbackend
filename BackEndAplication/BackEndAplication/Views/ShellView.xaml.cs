using System.Windows;

namespace BackEndAplication.Views
{
    public partial class ShellView : Window

    {
        public ShellView()
        {
            InitializeComponent();
            new SplashWindow().ShowDialog();
        }
    }
}