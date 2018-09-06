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
using System.Data;
using MySql.Data.MySqlClient;

namespace shopfloorcs
{
    /// <summary>
    /// Interaction logic for admin_home.xaml
    /// </summary>
    public partial class admin_home : Window
    {
        string labelLogin;

        public admin_home()
        {
            InitializeComponent();
        }

        public admin_home(string loginName)
        {
            InitializeComponent();
            Database db = new Database();
            string query;
            MySqlDataReader reader;
            labelLogin = loginName;
            MessageBox.Show(loginName);
            labelLoginName.Visibility = Visibility.Hidden;
            query = "select USER_EMAIL from users where USER_NAME= '" + loginName + "'";
            reader = db.QueryCommand(query);

            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelLoginName.Visibility = Visibility.Visible;
                        labelLoginName.Content = reader["USER_EMAIL"].ToString();
                        MessageBox.Show(reader["USER_EMAIL"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("error");
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            create_user createUserWindow = new create_user(labelLoginName.Content.ToString());
            createUserWindow.Show();
            this.Hide();
        }

        private void btnViewUser_Click(object sender, RoutedEventArgs e)
        {
            view_users viewUserWindow = new view_users(labelLoginName.Content.ToString());
            viewUserWindow.Show();
            this.Hide();
        }
    }
}
