using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class sale
    {

        DataTable dt = new DataTable();
        db accessDB = new db();

        public int SalesID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int CustomerID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int ItemID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Quantity
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Date
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int EmployeeID
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DataTable getfrmOrders1()
        {

            string query = "SELECT sales.sales_id, items.item_id,item_name, sales.quantity, customer.customer_id, title, forename, surname, sales.date FROM orderline LEFT JOIN sales ON orderline.sales_id = sales.sales_id LEFT JOIN items ON orderline.item_id = items.item_id LEFT JOIN customer ON sales.customer_id = customer.customer_id";
            dt = accessDB.getAllOrders(query);
            //dt = sale.Populate_dvgOrders();
            return dt;


        }
    }
}
