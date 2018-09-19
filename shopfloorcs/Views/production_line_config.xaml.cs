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

namespace shopfloorcs.Views
{
    /// <summary>
    /// Interaction logic for production_line_config.xaml
    /// </summary>
    public partial class production_line_config : Window
    {
        public production_line_config()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            production_line_config_home plcWindow = new production_line_config_home();
            plcWindow.Show();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void combobox_status_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
