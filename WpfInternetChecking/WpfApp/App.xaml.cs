using System;
using System.Net;
using System.Windows;

namespace WpfApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            try
            {
                Dns.GetHostEntry("www.google.com");
                StartupUri = new Uri("/WpfApp;component/MainWindow.xaml", UriKind.Relative);
            }
            catch
            {
                StartupUri = new Uri("/WpfApp;component/NotInternetWindow.xaml", UriKind.Relative);
            }
        }
    }
}
