using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data;

#region toDO
        //instantiate and load forms for sales and tech when
        //added to project        
#endregion



namespace BikersWorld
{

    public class db
    {
        //db connection variables
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int employeeID;
        private int employeeType;


        // default constructor
        public db() {
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
            try  {
                connection.Close();
                return true;
                    
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        //query db to see if entered credentials exist within db
        private void login (string username, string password)
        {
            string hashedPassword = getMD5Hash(password);
                       
            string query = "SELECT * FROM login WHERE (username = '" + username + "' AND password = '" + hashedPassword + "');";
  
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                int count = 0;
                while (dataReader.Read())
                {
                    count++;
                    employeeID = Convert.ToInt16(dataReader["employee_id"]);
                }

                dataReader.Close();
                this.closeConnection();
                if (count == 1)
                {

                    string getEmployeeType = "SELECT * FROM employee WHERE employee_id = " + employeeID + "; ";
                    if (this.openConnection() == true)
                    {
                        MySqlCommand cmd2 = new MySqlCommand(getEmployeeType, connection);
                        MySqlDataReader myReader = cmd2.ExecuteReader();
                        while (myReader.Read())
                        {
                            employeeType = Convert.ToInt16(myReader["job_role_id"]);
                        }

                        myReader.Close();
                        this.closeConnection();

                        switch (employeeType)
                        {
                            case 1:
                                //instantiaites management form when management login credentials are verified. 
                                frmManagement formManager = new frmManagement();
                                formManager.ShowDialog();
                                break;
                            case 2:
                                //instantiate technician form
                                break;
                            default:
                                //instantiate sales form
                                break;
                        }

                    }
                    else //display error message if 
                    {
                        MessageBox.Show("Oops! Something went wrong, please try again");
                        reloadLogin();

                    }

                }
                else if (count > 1)
                {
                    MessageBox.Show("Your login credentials are duplicated on the System. Please contact your network administrator!");
                    reloadLogin();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials, please try again");
                    reloadLogin();
                }
                
            }
            else //display messagebox error unable to connected to database and then reload login form
            {
                
                MessageBox.Show("Please contact your network administrator. Unable to connect to database system!");
                reloadLogin();
            }

        }

        //Authenticate users login credentials
        public void authenticate(string username, string password)
        {
            
            login(username, password);

        }

        // take a string value and return it as a MD5 hashed string
        private string getMD5Hash(string strPassword) {

            byte[] encodedPassword = new UTF8Encoding().GetBytes(strPassword);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            string encoded = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
            return encoded; 

        }

        //method used to reload login form
        private void reloadLogin()
        {
            frmLogin loginAgain = new frmLogin();
            loginAgain.ShowDialog();
        }

        public DataTable getProducts()
        {
            DataTable dt = new DataTable();
            string query = "SELECT item_id, item_name, description, price, quantity, supplier_name FROM items LEFT JOIN suppliers ON items.supplier_id = suppliers.supplier_id";
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myReader = cmd.ExecuteReader();

                dt.Load(myReader);

                return dt;
            }
            else
            {
                MessageBox.Show("Failed to connect to database, if problem persists please contact your network administrator!");
                return null;
            }
        } 


        public DataTable filterProducts(string value, string criteria)
        {

            string query = "";           
            switch (criteria)
            {
                case "product":
                    query = "SELECT item_id, item_name, description, price, quantity, supplier_name FROM items LEFT JOIN suppliers ON items.supplier_id = suppliers.supplier_id WHERE item_name LIKE '%" + value + "%';";
                    break;
                case "manufacturer":
                    query = "SELECT item_id, item_name, description, price, quantity, supplier_name FROM suppliers RIGHT JOIN items ON suppliers.supplier_id = items.supplier_id WHERE supplier_name LIKE '%" + value + "%';";
                    break;
                default:
                    query = "SELECT item_id, item_name, description, price, quantity, supplier_name FROM items LEFT JOIN suppliers ON items.supplier_id = suppliers.supplier_id WHERE item_name LIKE '%" + value + "%' AND supplier_name LIKE '%" + criteria + "%';";
                    break;
            }
            DataTable dt = new DataTable();
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                return dt;
            }
            else
            {
                MessageBox.Show("Failed to connect to database, if problem persists please contact your network administrator!");
                return null;
            }
        }

    }
}
