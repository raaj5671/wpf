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
using System.Data;
using MySql.Data.MySqlClient;
using shopfloorcs.Models;
using shopfloorcs.ViewModels;

namespace shopfloorcs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            User user = new User()
            {
                UserName = txtUserName.Text,
                UserPassword = passwordBox.Password
            };


            try
            {
                Database db = new Database();
                db.GetConnection();
                //string userName;
                //string userPassword;
                MySqlDataReader reader;
                //userName = txtUserName.Text;
                //userPassword = passwordBox.Password;

                if (user.UserPassword == "" && user.UserName == "")
                {
                    MessageBox.Show("Please enter both username and password");
                    return;
                }
                else if (user.UserName == "")
                {
                    MessageBox.Show("Please enter the username");
                    return;
                }
                else if (user.UserPassword == "")
                {
                    MessageBox.Show("Please enter the password");
                    return;
                }
                try
                {
                    string query;
                    query = "Select * FROM users WHERE USER_NAME= '" + user.UserName + "' and USER_PASSWORD= '" + user.UserPassword + "' ";
                    reader = db.QueryCommand(query);

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if(reader["USER_ROLE"].ToString() == "ADMIN_USER")
                            {
                                MessageBox.Show("Welcome Admin User; Login success");
                                admin_home adminWindow = new admin_home(user.UserName);
                                adminWindow.Show();
                                this.Hide();
                            } else if(reader["USER_ROLE"].ToString() == "NPI_USER")
                            {
                                MessageBox.Show("Welcome Npi User; Login success");
                                npi_home npiWindow = new npi_home();
                                npiWindow.Show();
                                this.Hide();
                            } else if (reader["USER_ROLE"].ToString() == "KITTING_USER")
                            {
                                MessageBox.Show("Welcome Kitting User; Login success");
                                kitting_home kittingWindow = new kitting_home();
                                kittingWindow.Show();
                                this.Hide();
                            } else if (reader["USER_ROLE"].ToString() == "NORMAL_USER")
                            {
                                MessageBox.Show("Welcome " + user.UserName + "; Login success");
                                normal_home normalWindow = new normal_home();
                                normalWindow.Show();
                                this.Hide();
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
