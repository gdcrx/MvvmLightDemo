using MvvmLightWpf.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MvvmLightWpf
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Startup += App_Startup;
        }

        public ViewModelLocator Locator { get; set; }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            Locator = (ViewModelLocator)Application.Current.Resources["Locator"] ?? null; 
        }
    }
}
