using MySql.Data.MySqlClient;
using shopfloorcs.Models;
using shopfloorcs.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for view_users.xaml
    /// </summary>
    public partial class view_users : Window
    {
        Database db = new Database();
        MySqlDataReader reader;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();
        string labelLogin;

        public view_users(string loginName)
        {
            InitializeComponent();
            labelLogin = loginName;
            labelLoginName.Content = labelLogin;

            //var userList = new UserViewModel().Users;
            //userDataGrid.ItemsSource = userList;

        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            TextBox txtFirstName = (TextBox)GetChildren(userDataGrid).FirstOrDefault(x => x.Name == "txtFirstName");
            TextBlock txtBlockId = (TextBlock)GetChildren(userDataGrid).First(x => x.Name == "txtBlockId");
            ComboBox cbUserRole = (ComboBox)GetChildren(userDataGrid).FirstOrDefault(x => x.Name == "cbUserRole");
            CheckBox cbUserStatus = (CheckBox)GetChildren(userDataGrid).FirstOrDefault(x => x.Name == "cbUserStatus");
            string firstName = txtFirstName.Text;
            string id = txtBlockId.Text;
            string userRole = cbUserRole.SelectedItem.ToString();
            //int userStatus = Convert.ToInt32(cbUserStatus.IsChecked.Value);
            int userStatus = (Convert.ToInt32(cbUserStatus.IsChecked.Value) == 0) ? 1 : 0;
            //int userStatus = 1;


            try
            {
                string query = "Update users set USER_FIRSTNAME = '" + firstName + "', USER_ROLE = '"+ userRole + "', USER_STATUS = '"+ userStatus +"' where ID = " + id;

                db.QueryCommand(query);

                MessageBox.Show("User updated successfully");
                this.Close();
                admin_home adminWindow = new admin_home();
                adminWindow.Show();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            admin_home adminWindow = new admin_home();
            adminWindow.Show();
        }


        private void cbUserRole_Loaded(object sender, RoutedEventArgs e)
        {
            //var userRolesList = new UserViewModel().getUserRoles();
            //ComboBox cbUserRole = (ComboBox)GetChildren(userDataGrid).FirstOrDefault(x => x.Name == "cbUserRole");
            //cbUserRole.ItemsSource = userRolesList;

            
        }
    }
}
