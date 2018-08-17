using MVVMDemoApplication.View;
using MVVMDemoApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMDemoApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Stating Point of Application 
            base.OnStartup(e);
            MainWindow window = new MainWindow();
            UserViewModel userViewModel = new UserViewModel();
            window.DataContext = userViewModel;
            window.Show();
        }
    }
}
