using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikersWorld
{
    public partial class frmCheckCustomers : Form
    {

        dbB newDB = new dbB();
        DataTable newGrid = new DataTable();
        string query = "";

        public frmCheckCustomers()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales form1 = new frmSales();
            this.Hide();
            form1.Show();
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomer form3 = new frmAddCustomer();
            this.Hide();
            form3.Show(); 
        }

        private void checkCostomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckCustomers form4 = new frmCheckCustomers();
            this.Hide();
            form4.Show();  
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders1 form5 = new frmOrders1();
            this.Hide(); 
            form5.Show();
            
        }

        private void bntCheck_Click(object sender, EventArgs e)
        {

            frmSales form1 = new frmSales();
            this.Hide();
            form1.Show();  
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSales form1 = new frmSales();
            this.Hide();
            form1.Show();  
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtPostcode.Text) && string.IsNullOrWhiteSpace(txtId.Text) && string.IsNullOrWhiteSpace(txtTel.Text))
            {




                MessageBox.Show("please insert a valid value");

            }
            else
            {
                query = "SELECT * FROM  customer WHERE customer_id LIKE '" + txtId.Text + "' OR postcode LIKE '" + txtPostcode.Text + "' OR forename LIKE '" + txtName.Text + "'OR telephone_1 LIKE'" + txtTel.Text + "'";


                newGrid = newDB.getDataTable(query);
                dvgCostumers.DataSource = newGrid;

            }
        }

        private void frmCheckCustomers_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM  customer";

            newGrid = newDB.getDataTable(query);
            dvgCostumers.DataSource = newGrid;
        }
    }
}
