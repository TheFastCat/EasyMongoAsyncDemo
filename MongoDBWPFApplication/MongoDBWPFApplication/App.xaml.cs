using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace MongoDBWPFApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow view = new MainWindow();
            ViewModel viewModel = new ViewModel();
            view.DataContext = viewModel;
            Application curApp = Application.Current;
            curApp.MainWindow.SizeToContent = SizeToContent.WidthAndHeight;
            curApp.MainWindow = view;
            view.ShowDialog();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }
    }
}
