using System;
using System.Threading;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace BackEndAplication.Views
{
    /// <summary>
    /// Interaction logic for SplashWindow.xaml
    /// </summary>
    public partial class SplashWindow
    {
        private readonly HideDelegate _hideDelegate;
        private readonly Storyboard _hideboard;

        private readonly ShowDelegate _showDelegate;
        private readonly Storyboard _showboard;
        private Thread _loadingThread;


        public SplashWindow()
        {
            InitializeComponent();
            _showDelegate = ShowText;
            _hideDelegate = HideText;

            _showboard = Resources["showStoryBoard"] as Storyboard;
            _hideboard = Resources["hideStoryBoard"] as Storyboard;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _loadingThread = new Thread(Load);
            _loadingThread.Start();
        }

        private void Load()
        {
            Thread.Sleep(5000);
            Dispatcher.Invoke(_showDelegate, "Carregar as configuracoes");
            Thread.Sleep(2000);
            Dispatcher.Invoke(_hideDelegate);
            Thread.Sleep(2000);
            Dispatcher.Invoke(_showDelegate, "Verificar as configuracoes");
            Thread.Sleep(2000);
            //load data
            Dispatcher.Invoke(_hideDelegate);


            Thread.Sleep(2000);
            Dispatcher.Invoke(_showDelegate, "Carregar os modelos");
            Thread.Sleep(2000);
            //load data 
            Dispatcher.Invoke(_hideDelegate);


            //close the window
            Thread.Sleep(2000);

            //this.Dispatcher.Invoke(DispatcherPriority.Normal,
            //                        (Action)delegate() { Close(); });
            Dispatcher.Invoke(DispatcherPriority.Normal,
                              (Action) Close);
            //
        }

        private void ShowText(string value)
        {
            txtLoading.Text = value;
            BeginStoryboard(_showboard);
        }

        private void HideText()
        {
            BeginStoryboard(_hideboard);
        }

        #region Nested type: HideDelegate

        private delegate void HideDelegate();

        #endregion

        #region Nested type: ShowDelegate

        private delegate void ShowDelegate(string txt);

        #endregion
    }
}