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
        string query;

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

                    
            query = "SELECT sales.sales_id, items.item_id,item_name, orderline.quantity, customer.customer_id, title, forename, surname, sales.date FROM orderline LEFT JOIN sales ON orderline.sales_id = sales.sales_id LEFT JOIN items ON orderline.item_id = items.item_id LEFT JOIN customer ON sales.customer_id = customer.customer_id";
            dt = accessDB.getAllOrders(query);
            //dt = sale.Populate_dvgOrders();
            return dt;

        }

        public void addSale(int customerID, List<int> cartItems, List<int> cartQuantities)
        {
            string items = "";
            for (int i = 0; i < cartItems.Count; i++)
            {
                if (i < cartItems.Count - 1)
                {
                    items += " (@last_id_in_sales, " + cartItems[i] + ", " + cartQuantities[i] + "),";
                }
                else
                {
                    items += " (@last_id_in_sales, " + cartItems[i] + ", " + cartQuantities[i] + ")";
                }
            }
            query = "INSERT INTO bikersworld.sales (customer_id) VALUES (" + customerID + "); SET @last_id_in_sales = LAST_INSERT_ID(); INSERT INTO bikersworld.orderline (sales_id, item_id, quantity) VALUES "+ items +";";
            accessDB.insertIntoDB(query);
            

            
        }

    }
}
