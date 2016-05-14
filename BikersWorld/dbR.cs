using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikersWorld
{
    class dbR
    {
        //db connection variables
        #region Connection Variables 
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        #endregion


        // default constructor
        public dbR()
        {
            Initialize();

        }

        //build connection to db
        private void Initialize()
        {
            server = "localhost";
            database = "bikersworld";
            uid = "root";
            password = "usbw";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }


        //open connection to db
        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to the server, please contact your network administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username / password please try again");
                        break;
                }
                return false;
            }
        }

        // close connection to db
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        // Gets a list of job roles from the database to populate a combo box
        #region get data table based on the query sent ->getDataTable
        public DataTable getDataTable(string query)

        {


            DataTable dt = new DataTable();

            if (this.openConnection() == true)

            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                dt.Load(dataReader);

                dataReader.Close();
                this.closeConnection();
                return dt;


            }
            else
            { MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator"); }



            return null;



        }
        #endregion


        public void insert (string query)
        {

            if (this.openConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                MessageBox.Show("Employee has been Created");

                while (dataReader.Read())
                {

                }

                dataReader.Close();
                this.closeConnection();
            }
            else
            { MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator"); }

        }


        public void update (string query)
        {

            if (this.openConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                MessageBox.Show("Employee  has been Updated");

                while (dataReader.Read())
                {

                }

                dataReader.Close();
                this.closeConnection();
            }
            else
            { MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator"); }


        }

    }
}
