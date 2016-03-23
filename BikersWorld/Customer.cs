using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class Customer : Person
    {
        dbEW accessDB = new dbEW();
        DataTable dt = new DataTable();

        public Customer() { }

        private int _CustomerID;


        public int CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }


            #region Elliott Additions

        }

            #endregion

        public Customer(int _CustomerID, string _Title, string _Fname, string _Lname, string _Address1,
            string _Address2, string _Address3, string _Postcode, string _Email, string _Telephone1, string _Telephone2)
        {

            CustomerID = _CustomerID;
            this.Title = _Title;
            this.Fname = _Fname;
            this.Lname = _Lname;
            this.Address1 = _Address1;
            this.Address2 = _Address2;
            this.Address3 = _Address3;
            this.Postcode = _Postcode;
            this.Email = _Email;
            this.Telephone1 = _Telephone1;
            this.Telephone2 = _Telephone2;



        }

        public DataTable getCustomers()
        {
            string query = "select * FROM customer";
            dt = accessDB.grabAll(query);
            return dt;
        }

        public void insertCustomer(Customer cust) 
        {
            string query = "INSERT INTO customer(title, forename, surname, address_1, address_2, address_3, " +
                "postcode, telephone_1, telephone_2, email)" +
            "VALUES ('" + cust.Title + "', '" + cust.Fname + "', '" + cust.Lname + "', '" + cust.Address1 + "', '" + cust.Address2 + "', '" + cust.Address3 + "', '" + cust.Postcode + "', '" + cust.Telephone1 + "', '" + cust.Telephone2 + "', '" + cust.Email + "')";
            accessDB.DataInsert(query);
        }
    }
}
