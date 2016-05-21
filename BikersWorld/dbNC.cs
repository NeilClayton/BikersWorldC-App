using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikersWorld
{
    class dbNC
    {
        #region DoesNotNeedCopyingOverToDB

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


        // default constructor
        public dbNC()
        {
            Initialize();

        }

        //build connection to db    
        private void Initialize()
        {
            server = "localhost";
            database = "bikersworld";
            uid = "root";
            password = "Crumpet69";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; Convert Zero Datetime=True";

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

        //query db to see if entered credentials exist within db
        private void login(string username, string password)
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
                                //instantiates management form when management login credentials are verified. 
                                frmManagement formManager = new frmManagement();
                                formManager.ShowDialog();
                                break;
                            case 2:
                                //instantiate technician form
                                frmTechnicianHub technician = new frmTechnicianHub();
                                technician.ShowDialog();
                                break;
                            default:
                                //instantiate sales form
                                frmSales sales = new frmSales();
                                sales.ShowDialog();
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
        private string getMD5Hash(string strPassword)
        {

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


        // Get everything from staff table
        #region retrieve content of the full employee table for the employee form ->getAllStaff
        public DataTable getAllStaff()
        {

            string query = ("SELECT employee.employee_id, employee.title, employee.forename, employee.surname, employee.address_1, employee.address_2, employee.address_3, employee.postcode, employee.telephone_1," +
                        " employee.telephone_2, employee.email, employee.`date`, job_role.job_role_name" +
                                " FROM  employee INNER JOIN  job_role ON employee.job_role_id = job_role.job_role_id;");

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

        public DataTable getProducts(string query)
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

        public DataTable updateStock(string query)
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


        // Get the search query for staff 
        #region search functionality for the employee form ->getStaffSearch
        public DataTable getStaffSearch(string userId, string firstName, string lastName)

        {

            string query = ("SELECT employee.employee_id, employee.title, employee.forename, employee.surname, employee.address_1, employee.address_2, employee.address_3, employee.postcode, employee.telephone_1," +
                        " employee.telephone_2, employee.email, employee.`date`, job_role.job_role_name" +
                                " FROM  employee INNER JOIN  job_role ON employee.job_role_id = job_role.job_role_id" +
                                " WHERE employee.employee_id ='" + userId + "' OR employee.forename LIKE '" + firstName + "' OR employee.surname LIKE '" + lastName + "';");



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


        // Gets a list of job roles from the database to populate a combo box

        #region JobeRole list to populate a combo box ->getJobRole

        public DataTable getJobRole()

        {


            System.Data.DataSet ds = new DataSet();

            string query = ("SELECT * FROM job_role");


            if (this.openConnection() == true)

            {
                MySqlDataAdapter cmd = new MySqlDataAdapter(query, connection);


                cmd.Fill(ds);

                this.closeConnection();
                return ds.Tables[0];


            }
            else
            { MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator"); }



            return null;



        }
        #endregion


        // Update process for the Employee form 
        #region Employee update process ->updateEmploeeTabbe
        public void updateEmploeeTabbe(string employee_id, string title, string forename, string surname, string address_1, string address_2, string address_3, string postcode, string telephone_1, string telephone_2, string email, string job_role_id)
        {


            string query = ("UPDATE employee SET title='" + title + "', forename='" + forename + "', surname='" + surname + "', address_1='" + address_1 + "', " +
                             " address_2='" + address_2 + "', address_3='" + address_3 + "', postcode='" + postcode + "', telephone_1='" + telephone_1 + "', telephone_2='" + telephone_2 + "', email='" + email + "', job_role_id='" + job_role_id +
                            "' WHERE employee_id='" + employee_id + "';");
            if (this.openConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                MessageBox.Show("Employee N:" + employee_id + " has been Updated");

                while (dataReader.Read())
                {

                }

                dataReader.Close();
                this.closeConnection();
            }
            else
            { MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator"); }





        }

        #endregion

        // Delete process for the Employee form 
        #region Delete process form employee form ->deleteEmploeeTabbe
        public void deleteEmploeeTabbe(string employee_id)
        {


            string query = ("DELETE FROM employee WHERE employee_id='" + employee_id + "';");
            if (this.openConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                MessageBox.Show("Employee N:" + employee_id + " has been deleted");

                while (dataReader.Read())
                {

                }

                dataReader.Close();
                this.closeConnection();
            }
            else
            { MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator"); }





        }

        #endregion



        public void newEmploeeTabbe(string title, string forename, string surname, string address_1, string address_2, string address_3, string postcode, string telephone_1, string telephone_2, string email, string job_role_id)
        {


            string query = ("INSERT INTO employee (title, forename, surname, address_1, address_2, address_3, postcode, telephone_1, telephone_2, email, job_role_id ) VALUES ('" + title + "','" + forename + "','" + surname + "','" + address_1 + "','" + address_2 + "','" + address_3 + "','" + postcode + "','" + telephone_1 + "','" + telephone_2 + "','" + email + "','" + job_role_id + "');");
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


        public DataTable getLastEmplyeeEntry()
        {

            {

                string query = ("SELECT employee.employee_id, employee.title, employee.forename, employee.surname, employee.address_1, employee.address_2, employee.address_3, employee.postcode, employee.telephone_1," +
                            " employee.telephone_2, employee.email, employee.`date`, job_role.job_role_name" +
                                    " FROM  employee INNER JOIN  job_role ON employee.job_role_id = job_role.job_role_id ORDER BY employee_id DESC LIMIT 1;");

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



        }
        #endregion


        public DataTable getJobStatistics(string query)
        {
            DataTable dt = new DataTable();
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.closeConnection();
            }
            else
            {
                MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator");
            }

            return dt;

        }
        public DataTable getCustomReport(string query)
        {
            DataTable dt = new DataTable();
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.closeConnection();
            }
            else
            {
                MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator");
            }

            return dt;

        }

        public DataTable getEmployeeDetails(string query)
        {
            DataTable dt = new DataTable();
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.closeConnection();
            }
            else
            {
                MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator");
            }

            return dt;
        }

        public DataTable getItems(string query)
        {
            DataTable dt = new DataTable();
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.closeConnection();
            }
            else
            {
                MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator");
            }

            return dt;
        }

        public DataTable individualPersonSales(string query)
        {
            DataTable dt = new DataTable();
            if (this.openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                this.closeConnection();
            }
            else
            {
                MessageBox.Show("Some error has occur when connecting to the database, please contact your Network Administrator");
            }

            return dt;
        }
    }
}
