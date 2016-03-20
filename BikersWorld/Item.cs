using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class Item
    {

        //private variables
        protected int ItemID;
        protected string ItemName;
        protected string Description;
        protected float Price;
        protected int Quantity;
        protected string SupplierName;
        protected int SupplierID;


        //Constructors

        public Item() { } //default
        public Item(int itemID, string itemName, string description, float price, int quantity, string suppliername )
        {
            ItemID = itemID;
            ItemName = itemName;
            Description = description;
            Price = price;
            Quantity = quantity;
            SupplierName = suppliername;
        }



        //access modifiers
        public int itemID
        {
            get
            {
                return ItemID;
            }
            set
            {
                ItemID = value;
            }
        }

        public string itemName
        {
            get
            {
                return ItemName;
            }
            set
            {
                ItemName = value;
            }
        }

        public string description
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }

        public float price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }
    
        public int quantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
            }
        }

        public string supplierName
        {
            get
            {
                return SupplierName;
            }
            set
            {
                SupplierName = value;
            }
        }

        public int supplierID
        {
            get
            {
                return SupplierID;
            }
            set
            {
                SupplierID = value;
            }
        }



    }
}
