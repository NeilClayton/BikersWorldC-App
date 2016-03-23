using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region
/*
 * Submit button functionality
 * Submit button menu strip
*/

#endregion

namespace BikersWorld
{
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            combTitle.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            combTitle.Text = ("");
            txtForename.Clear();
            txtSurname.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtAddress3.Clear();
            txtPostcode.Clear();
            txtTelephone1.Clear();
            txtTelephone2.Clear();
            txtEmail.Clear();
            txtEmployeeID.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            combTitle.Text = ("");
            txtForename.Clear();
            txtSurname.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtAddress3.Clear();
            txtPostcode.Clear();
            txtTelephone1.Clear();
            txtTelephone2.Clear();
            txtEmail.Clear();
            txtEmployeeID.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool formCompleted = validate_form();
            if (formCompleted)
            {



                Customer cust = new Customer();

                
                cust.Title = combTitle.Text;
                cust.Fname = txtForename.Text;
                cust.Lname = txtSurname.Text;
                cust.Address1 = txtAddress1.Text;
                cust.Address2 = txtAddress2.Text;
                cust.Address3 = txtAddress3.Text;
                cust.Postcode = txtPostcode.Text;
                cust.Telephone1 = txtTelephone1.Text;
                cust.Telephone2 = txtTelephone2.Text;
                cust.Email = txtEmail.Text;

                cust.insertCustomer(cust);

            }
            else
            {
                MessageBox.Show("Please complete all fields.");
            }


        }

        public bool validate_form()

        {
            bool validate = true;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    if (((TextBox) x).Text==String.Empty)
                    {
                        validate=false;
                        break;
                    }
                }
            }
            return validate;
        }

    }

}