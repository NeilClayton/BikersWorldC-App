using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikersWorld
{
    public class Person
    {

        private string _Fname;
        private string _Title;
        private string _Lname;
        private string _Address1;
        private string _Address2;
        private string _Address3;
        private string _Telephone1;
        private string _Telephone2;
        private string _Email;
        private string _Postcode;

   
    
        public string Fname
        {
            get
            {
                return _Fname;
            }
            set
            {
                _Fname = value;
            }
        }


        public string Title
        {
            get
            {
                return _Title;  
            }
            set
            {
                _Title = value;

            }
        }

        public string Lname
        {
            get
            {
                return _Lname;
            }
            set
            {
                _Lname = value;
            }
        }

        public string Address1
        {
            get
            {
                return _Address1;
            }
            set
            {
                _Address1 = value;
            }
        }

        public string Address2
        {
            get
            {
                return _Address2;
            }
            set
            {
                _Address2 = value;
            }
        }

        public string Address3
        {
            get
            {
                return _Address3;
            }
            set
            {
                _Address3 = value;
            }
        }

        public string Telephone1
        {
            get
            {
                return _Telephone1;
            }
            set
            {
                _Telephone1 = value;
            }
        }

        public string Telephone2
        {
            get
            {
                return _Telephone2;
            }
            set
            {
                _Telephone2 = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        public string Postcode
        {
            get
            {
                return _Postcode;
            }
            set
            {
                _Postcode = value;
            }
        }
    }
}
