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
    /// Interaction logic for create_user.xaml
    /// </summary>
    public partial class create_user : Window
    {
        string labelLogin;


        MySqlDataReader reader;
        Database db = new Database();

        public create_user(string loginName)
        {
           
            InitializeComponent();
            labelLogin = loginName;
            labelLoginName.Content = labelLogin;
            MessageBox.Show(labelLoginName.Content.ToString());

            string query;
            query = "Select * from userroles";
            reader = db.QueryCommand(query);

            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string userRole = reader["USER_ROLE"].ToString();
                        comboBox_UserRole.Items.Add(userRole);
                    }
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string userName;
            string password;
            string firstName;
            string lastName;
            string email;
            string userRole;

            userName = txtUserName.Text;
            password = txtUserPassword.Password;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            email = txtEmail.Text;
            userRole = comboBox_UserRole.SelectedItem.ToString();

            MessageBox.Show("Inserted user info\n: username: " + userName +
                        "password: " + password +
                        "firstname: " + firstName +
                        "lastname: " + lastName +
                        "email: " + email +
                        "userrole: " + userRole);

            string query;

            try
            {
                query = "Insert into users (USER_NAME, USER_PASSWORD, USER_FIRSTNAME, USER_LASTNAME, USER_EMAIL, USER_ROLE, USER_STATUS) Values ('" + userName + "' , '" + password + "' , '" + firstName + "', '" + lastName + "', '" + email + "', '" + userRole + "', 1)";

                db.QueryCommand(query);

                MessageBox.Show("User created successfully");
                this.Hide();
                admin_home adminWindow = new admin_home();
                adminWindow.Show();

            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox_UserRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            admin_home adminWindow = new admin_home(labelLogin);
            adminWindow.Show();
        }
    }
}
