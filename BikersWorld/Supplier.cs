using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class supplier : Person
    {

        dbR mydb = new dbR();
        DataTable dt = new DataTable();
        private string _SupplierName;
        private string _SupplierID;


        public string SupplierName
        {
            get
            {
                return _SupplierName;
            }
            set
            {
                _SupplierName = value;
            }
        }

        public string SupplierID
        {
            get
            {
                return _SupplierID;
            }
            set
            {
                _SupplierID = value;
            }
        }

        public supplier( string _SupplierName, string _Address1,
            string _Address2, string _Address3, string _Postcode, string _Telephone1, string _Telephone2, string _Email)
        {

<<<<<<< HEAD
            SupplierID = _SupplierID;
            SupplierName = _SupplierName;
         
            this.Address1 = _Address1;
            this.Address2 = _Address2;
            this.Address3 = _Address3;
            this.Postcode = _Postcode;
            this.Telephone1 = _Telephone1;
            this.Telephone2 = _Telephone2;
            this.Email = _Email;
=======
            _SupplierID = SupplierID;
            _SupplierName = SupplierName;
            this.Title = Title;
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.Address3 = Address3;
            this.Postcode = Postcode;
            this.Telephone1 = Telephone1;
            this.Telephone2 = Telephone2;
            this.Email = Email;
>>>>>>> refs/remotes/origin/master
        }

        public supplier()
        {
        }

        public DataTable getAllSuppliers()

        {

            string query = "SELECT * FROM suppliers;";

            return dt = mydb.getDataTable(query);

        }

        public DataTable getSearchSuppliers(string supplierId, string supplierName)

        {

            string query = "SELECT * FROM suppliers where supplier_id ='" + supplierId + "' or supplier_name LIKE '" + supplierName + "';";

            return dt = mydb.getDataTable(query);

        }
        public bool  submit ()
        {

            string query = "INSERT INTO suppliers (`supplier_name`,`address_1`,`address_2`,`address_3`,`postcode`,`telephone_1`,`telephone_2`,`email`) VALUES ('" + SupplierName + "' ,'" + Address1 + "' ,'" + Address2 + "' ,'" + Address3 + "' ,'" + Postcode + "' ,'" + Telephone1 + "' ,'" + Telephone2 + "' ,'" + Email + "' )";

            mydb.insert(query);
            return false;

        }


        public bool update(int supID)
        {

            string query = "UPDATE suppliers "+
                            "SET supplier_name='" + SupplierName + "', address_1='" + Address1 + "',address_2= '" + Address2 + "',"+
                            "address_3='" + Address3 + "',postcode='" + Postcode + "',telephone_1='" + Telephone1 + "',"+
                            "telephone_2='" + Telephone2 + "',email='" + Email + "'"+
                            "WHERE supplier_id = '" + supID + "'";

            mydb.update(query);
            return false;

        }
    }
}
