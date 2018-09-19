using shopfloorcs.Views;
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
using System.Windows.Shapes;

namespace shopfloorcs
{
    /// <summary>
    /// Interaction logic for npi_home.xaml
    /// </summary>
    public partial class npi_home : Window
    {
        public npi_home()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            System.Windows.Application.Current.Shutdown();
            
        }

        private void btnProductionLineConfig_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            production_line_config_home plcWindow = new production_line_config_home();
            plcWindow.Show();
        }
    }
}
