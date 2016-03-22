﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikersWorld
{
    class dbEW
    {
        //db connection variables
        #region Connection Variables 
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int employeeID;
        private int employeeType; 
        #endregion

        DataTable dt = new DataTable();


        // default constructor
        public dbEW() {
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
            try {
                connection.Close();
                return true;

            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }


#region Elliott Content
/*
 * 
 * 
 * 
 */

        public DataTable grabAll(string query)
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
            {
                MessageBox.Show("An unexpected error has occured. Please contact your Network Administrator", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

#endregion


       
    }
}
