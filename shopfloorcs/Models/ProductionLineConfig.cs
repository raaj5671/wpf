using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopfloorcs.Models
{
    public class ProductionLineConfig : INotifyPropertyChanged
    {
        private int id;
        public int ProductionLineId
        {
            get { return id; }

            set
            {
                id = value;
                OnPropertyChanged("ProductionLineId");
            }
        }

        private string linecode;

        public string ProductionLineCode
        {
            get { return linecode; }
            set
            {
                linecode = value;
                OnPropertyChanged("ProductionLineCode");
            }
        }

        private string linename;

        public string ProductionLineName
        {
            get { return linename; }
            set
            {
                linename = value;
                OnPropertyChanged("ProductionLineName");
            }
        }


        private bool status;

        public bool ProductionLineStatus
        {
            get { return status; }
            set
            {
                status = value;
                OnPropertyChanged("ProductionLineStatus");
            }
        }

        private DateTime createddate;

        public DateTime ProductionLineCreatedDate
        {
            get { return createddate; }
            set
            {
                createddate = value;
                OnPropertyChanged("ProductionLineCreatedDate");
            }
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
