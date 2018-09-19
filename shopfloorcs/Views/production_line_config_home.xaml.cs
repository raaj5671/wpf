using shopfloorcs.Enum;
using shopfloorcs.ViewModels;
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
    /// Interaction logic for production_line_config_home.xaml
    /// </summary>
    public partial class production_line_config_home : Window
    {
        public production_line_config_home()
        {
            InitializeComponent();
            ProductionLineConfigViewModel vm = new ProductionLineConfigViewModel();
            productionLineConfigDataGrid.DataContext = vm;

            ComboBox cbUserRole = (ComboBox)GetChildren(productionLineConfigDataGrid).FirstOrDefault(x => x.Name == "cbProductionLineStatus");
            //foreach (Status iColor in System.Enum.GetValues(typeof(Status)))
            //{
            //    cbUserRole.ItemsSource = iColor.ToString();
            //    MessageBox.Show(iColor.ToString());
            //}

        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            
            this.Hide();
            System.Windows.Application.Current.Shutdown();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            npi_home npiWindow = new npi_home();
            npiWindow.Show();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            production_line_config plcWindow = new production_line_config();
            plcWindow.Show();
        }

        private List<FrameworkElement> GetChildren(DependencyObject parent)
        {
            List<FrameworkElement> controls = new List<FrameworkElement>();

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); ++i)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is FrameworkElement)
                {
                    controls.Add(child as FrameworkElement);
                }
                controls.AddRange(GetChildren(child));
            }

            return controls;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
