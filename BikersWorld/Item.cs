using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BikersWorld
{
    public class Item
    {
        db accessDB = new db();
        DataTable dt = new DataTable();
        string query = "SELECT * FROM items LEFT JOIN suppliers ON items.supplier_id = suppliers.supplier_id";

        //variables used to store item information in memory
        #region ClassAttributes
        private int itemID;
        private string itemName;
        private string itemDescription;
        private int itemSupplierID;
        private string itemSupplierName;
        private double itemPrice;
        private int itemStock;
        #endregion
        
        //accessor methods for item class
        #region Accessors
        public int ItemID
        {
            get
            {
                return itemID;
            }
            set
            {
                itemID = value;
            }
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }

        public string ItemDescription
        {
            get
            {
                return itemDescription;
            }
            set
            {
                itemDescription = value;
            }
        }

        public int ItemSupplierID
        {
            get
            {
                return itemSupplierID;
            }
            set
            {
                itemSupplierID = value;
            }
        }

        public string ItemSupplierName
        {
            get
            {
                return itemSupplierName;
            }
            set
            {
                itemSupplierName = value;
            }
        }


        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }
        }

        public int ItemStock
        {
            get
            {
                return itemStock;
            }
            set
            {
                itemStock = value;
            }
        }
        #endregion

        // constructors of item class
        #region Constructors

        //default constructor
        public Item() { }

        //completed details constructor
        public Item(int ID, string Name, string Description, int SupplierID, string SupplierName, double Price, int Stock)
        {
            itemID = ID;
            itemName = Name;
            itemDescription = Description;
            itemSupplierID = SupplierID;
            itemSupplierName = SupplierName;
            itemPrice = Price;
            itemStock = Stock;
        }

        #endregion

        //methods used within the item class
        #region Methods
        public DataTable Populate_dgvProducts()
        {
            query = "SELECT * FROM items LEFT JOIN suppliers ON items.supplier_id = suppliers.supplier_id";
            dt = accessDB.getProducts(query);
            return dt;

        }

        public DataTable searchProducts(string value, string optional, string criteriaType)
        {
            query = "SELECT * FROM items LEFT JOIN suppliers ON items.supplier_id = suppliers.supplier_id";
            switch (criteriaType)
            {
                case "product":
                    dt = accessDB.getProducts(query + " WHERE items.item_name LIKE '%" + value + "%'");
                                        break;
                case "supplier":
                    dt = accessDB.getProducts(query + " WHERE suppliers.supplier_name LIKE '%" + value + "%'");                    
                    break;
                case "both":
                    dt = accessDB.getProducts(query + " WHERE items.item_name LIKE '%" + value + "%' AND suppliers.supplier_name LIKE '%" + optional + "%'");

                    break;
            }
            return dt;

        }

        public void updateStock(int index, int quantity)
        {
            try {
                query = "UPDATE items SET quantity = " + quantity + " WHERE item_id = " + index;
                accessDB.updateStock(query);
            } catch (Exception ex)
            {
                MessageBox.Show("Unable to carry out stock management action, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }         
        }

        #endregion

        #region RF Methods
        dbR rfDB = new dbR();
        public DataTable getProducts(string query)
        {

           return dt = rfDB.getDataTable(query);


        }
        public void newProduct()
        {
            query = "INSERT INTO items (item_name, description, supplier_id, price, quantity) VALUE ('"+ItemName+"', '"+ItemDescription+"', "+ItemSupplierID+", "+ItemPrice+", "+ItemStock+" )";

            rfDB.insert(query);

        }

        public void updateProducts()
        {

            query = "update items set item_name='"+ ItemName + "', description='"+ItemDescription+"', supplier_id="+ ItemSupplierID + ", price = "+ ItemPrice + ", quantity= "+ ItemStock + " where item_id="+itemID+" ";
            rfDB.update(query);


        }
       
        #endregion

    }
}
