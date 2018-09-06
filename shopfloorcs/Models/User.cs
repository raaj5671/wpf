using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopfloorcs.Models
{
    public class User : INotifyPropertyChanged
    {
        private int id;

        public int UserId
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("UserId");
            }
        }

        private string username;

        public string UserName
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("UserName");
            }
        }

        private string useremail;

        public string UserEmail
        {
            get { return useremail; }
            set
            {
                useremail = value;
                OnPropertyChanged("UserEmail");
            }
        }

        private string userfirstname;

        public string UserFirstName
        {
            get { return userfirstname; }
            set
            {
                userfirstname = value;
                OnPropertyChanged("UserFirstName");
            }
        }

        private string userlastname;

        public string UserLastName
        {
            get { return userlastname; }
            set
            {
                userlastname = value;
                OnPropertyChanged("UserLastName");
            }
        }

        private DateTime usercreateddate;

        public DateTime UserCreatedDate
        {
            get { return usercreateddate; }
            set
            {
                usercreateddate = value;
                OnPropertyChanged("UserCreatedDate");
            }
        }

        private string userrole;


        public string UserRole
        {
            get { return userrole; }
            set
            {
                userrole = value;
                OnPropertyChanged("UserRole");
            }
        }

        private string userpassword;


        public string UserPassword
        {
            get { return userpassword; }
            set
            {
                userpassword = value;
                OnPropertyChanged("UserPassword");
            }
        }

        private bool userstatus;


        public bool UserStatus
        {
            get { return userstatus; }
            set
            {
                userstatus = value;
                OnPropertyChanged("UserStatus");
            }
        }


        public override string ToString()
        {
            return $"{UserRole}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
