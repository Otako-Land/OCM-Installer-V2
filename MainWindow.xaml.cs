using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Squirrel;

namespace OCM_Installer_V2
{
    public partial class MainWindow : Window
    {
        UpdateManager manager;

        public MainWindow()
        {
            InitializeComponent();

            UpdateHandler.HandleInstallEvents();

            manager = new GithubUpdateManager(@"");

            CurrentVersion.Content = manager.CurrentlyInstalledVersion().ToString();
        }
    }
}
