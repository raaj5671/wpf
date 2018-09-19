using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace shopfloorcs
{
    class Database
    {
        MySqlConnection MySqlConn;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;

        string server;
        string user;
        string password;
        string database;

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConn = new MySqlConnection();
                server = "localhost";
                user = "root";
                password = "Welcome123";
                database = "shopfloordb";
                MySqlConn.ConnectionString = "server=" + server + ";"
                    + "user id=" + user + ";"
                    + "password=" + password + ";"
                    + "database=" + database + ";"
                    + "SslMode=none";
                MySqlConn.Open();
                //MessageBox.Show("Connected");
            } catch (MySqlException ex)
            {
                MessageBox.Show("Cannot connect to database" + ex.ToString());
            }
            return MySqlConn;
        }

        public MySqlDataReader QueryCommand(string command)
        {
            try
            {
                GetConnection();
                cmd.CommandText = command;
                cmd.Connection = MySqlConn;
                reader = cmd.ExecuteReader();
            } catch (MySqlException ex)
            {
                MessageBox.Show("Query command error:  " + ex.ToString());
            }
            return reader;
        }

        public void CloseConnection()
        {
            GetConnection();
            MySqlConn.Close();
            MySqlConn.Dispose();
        }

    }
}
