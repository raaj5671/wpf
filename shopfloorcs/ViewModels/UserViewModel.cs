﻿using MySql.Data.MySqlClient;
using shopfloorcs.Models;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;
using shopfloorcs.ViewModels.Commands;
using System.Collections.ObjectModel;
using System;

namespace shopfloorcs.ViewModels
{
    public class UserViewModel
    {
        Database db = new Database();
        MySqlDataReader reader;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();

        private User user;

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public RegisterCommand RegisterCommand { get; set; }

        public UserViewModel()
        {
            RegisterCommand = new RegisterCommand(this);
        }


        //public ObservableCollection<User> Users { get; set; }

        public List<User> Users
        {
            get
            {
                var user = new List<User>();
                string query;
                query = "select * from users";
                da = new MySqlDataAdapter(query, db.GetConnection());
                da.Fill(dt);
                reader = db.QueryCommand(query);
                while (reader.Read())
                {
                    user.Add(new User()
                    {
                        UserId = Int32.Parse(reader[0].ToString()),
                        UserName = reader[1].ToString(),
                        UserCreatedDate = Convert.ToDateTime(reader[5].ToString()),
                        UserEmail = reader[6].ToString(),
                        UserFirstName = reader[7].ToString(),
                        UserLastName = reader[8].ToString(),
                        UserRole = reader[3].ToString()

                    });
                }


                reader.Close();

                return user;

            }





        }

        public List<User> UserRoles
        {
            get
            {
                List<User> userRoleList = new List<User>();
                string queryUserRoles = "Select * from userroles";
                reader = db.QueryCommand(queryUserRoles);

                try
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userRoleList.Add(new User()
                            {
                                UserRole = reader[1].ToString()

                            });

                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                reader.Close();

                return userRoleList;

            }
            
        }
    }
}
