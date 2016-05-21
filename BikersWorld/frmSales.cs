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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }




        private void btn_check_coustomer_Click(object sender, EventArgs e)
        {
            // frmSales form1 = new frmSales(); 
            frmCheckCustomers form4 = new frmCheckCustomers();
            this.Hide(); 
            form4.Show();
            //
            //frmSales.  
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {

            frmOrders1 form5 = new frmOrders1();
 this.Hide();
            form5.Show();
           
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AppTools.formVerifyAndOpen<frmAddNewCustomer>("frmAddNewCustomer");


        }

        private void addCoustomoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomer form3 = new frmAddCustomer();
            this.Hide(); 
            form3.ShowDialog();
            
        }

        private void checkCutomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckCustomers form4 = new frmCheckCustomers();
             this.Hide();  
            form4.ShowDialog();
           
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders1 form5 = new frmOrders1();
             this.Hide();
    form5.ShowDialog();
           
        }

        private void salesHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales form1 = new frmSales();
            this.Hide();
            form1.Show();  
 
        }

        private void frmSales_Load(object sender, EventArgs e)
        {

        }
    }
}
