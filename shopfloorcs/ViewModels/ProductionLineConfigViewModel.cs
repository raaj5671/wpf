using MySql.Data.MySqlClient;
using shopfloorcs.Enum;
using shopfloorcs.Models;
using shopfloorcs.ViewModels.Commands;
using shopfloorcs.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace shopfloorcs.ViewModels
{
    public class ProductionLineConfigViewModel : INotifyPropertyChanged
    {
        Database db = new Database();
        MySqlDataReader reader;
        MySqlDataAdapter da;
        DataTable dt = new DataTable();

        private ProductionLineConfig productionlineconfig;

        public ProductionLineConfig ProductionLineConfig
        {
            get { return productionlineconfig; }

            set
            {
                productionlineconfig = value;
                OnPropertyChanged("ProductionLineConfig");
            }
        }

        // TODO - Create new productionline config;
        public void createNewProductionLineConfig()
        {
            string query;

            try
            {
                query = "Insert into productionlineconfig (PRODUCTION_LINE_CODE, PRODUCTION_LINE_NAME, PRODUCTION_LINE_STATUS) Values ('" + ProductionLineConfig.ProductionLineCode + "' , '" + ProductionLineConfig.ProductionLineName + "' , '" + Convert.ToInt32(ProductionLineConfig.ProductionLineStatus) + "')";

                db.QueryCommand(query);

                MessageBox.Show("User created successfully");
                production_line_config plcWindow = new production_line_config();
                plcWindow.Hide();
                npi_home npiWindow = new npi_home();
                npiWindow.Show();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL ERROR: " + ex.ToString());
            }
        }

        // TODO -  Update productionline config;
        public void updateProductionLineConfig()
        {
            string query;

            try
            {
                query = "Update productionlineconfig set PRODUCTION_LINE_NAME = '" + ProductionLineConfig.ProductionLineName + "', PRODUCTION_LINE_STATUS = '" + Convert.ToInt32(ProductionLineConfig.ProductionLineStatus) + "' where ID = " + ProductionLineConfig.ProductionLineId;
                MessageBox.Show("Name:" + ProductionLineConfig.ProductionLineName + "\nStatus: " + Convert.ToInt32(ProductionLineConfig.ProductionLineStatus) + "\nID: " + ProductionLineConfig.ProductionLineId);
                // update not working....
                db.QueryCommand(query);

                MessageBox.Show("Record updated successfully");
                production_line_config plcWindow = new production_line_config();
                plcWindow.Hide();
                npi_home npiWindow = new npi_home();
                npiWindow.Show();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: " + ex.ToString());
            }
        }


        public Status status = Status.Enable;

        public List<string> Statusstring {
            get
            {
                return System.Enum.GetNames(typeof(Status)).ToList();

            }

        }

        private ObservableCollection<ProductionLineConfig> _listAllProductionLineConfigs;
        public ObservableCollection<ProductionLineConfig> listAllProductionLineConfigs
        {
            get
            {
                return _listAllProductionLineConfigs;
            }

            set 
            {
                _listAllProductionLineConfigs = value;
                OnPropertyChanged("listAllProductionLineConfigs");
            }

        }

        private void PopulateProductionLineConfigs()
        {
            _listAllProductionLineConfigs = new ObservableCollection<ProductionLineConfig>();
            string query;
            query = "select * from productionlineconfig";
            da = new MySqlDataAdapter(query, db.GetConnection());
            da.Fill(dt);
            reader = db.QueryCommand(query);
            while (reader.Read())
            {
                _listAllProductionLineConfigs.Add(new ProductionLineConfig()
                {
                    ProductionLineId = Int32.Parse(reader[0].ToString()),
                    ProductionLineCode = reader[1].ToString(),
                    ProductionLineName = reader[2].ToString(),
                    ProductionLineStatus = Convert.ToBoolean(reader[3].ToString()),
                    ProductionLineCreatedDate = Convert.ToDateTime(reader[4].ToString())
                });
            }
            reader.Close();
        }

        public CustomCommand<ProductionLineConfig> updateProductionLineConfigCommand { get; }
        public NewProductionLineConfigCommand newProductionLineConfigCommand { get; set; }
        //public UpdateProductionLineConfigCommand updateProductionLineConfigCommand { get; set; }

        public ProductionLineConfigViewModel()
        {
            ProductionLineConfig = new ProductionLineConfig();
            PopulateProductionLineConfigs();
            newProductionLineConfigCommand = new NewProductionLineConfigCommand(this);
            //updateProductionLineConfigCommand = new UpdateProductionLineConfigCommand(this);
            updateProductionLineConfigCommand = new CustomCommand<ProductionLineConfig>(UpdateConfig, (u) => true);

        }

        private void UpdateConfig(ProductionLineConfig config)
        {
            string query;

            try
            {
                if (config.ProductionLineName != "")
                {
                    query = "Update productionlineconfig set PRODUCTION_LINE_NAME = '" + config.ProductionLineName + "', PRODUCTION_LINE_STATUS = '" + Convert.ToInt32(config.ProductionLineStatus) + "' where ID = " + config.ProductionLineId;
                    db.QueryCommand(query);
                    MessageBox.Show("Record updated successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
                else
                {
                    MessageBox.Show("Do not leave empty", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("MySQL Error: " + ex.ToString());
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
