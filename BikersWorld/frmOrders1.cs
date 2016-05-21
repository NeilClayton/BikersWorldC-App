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
    public partial class frmOrders1 : Form
    {
        sale sale = new sale();
        DataTable dt = new DataTable();

        public frmOrders1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomer form3 = new frmAddCustomer();
            this.Hide();
            form3.ShowDialog();  
        }

        private void checkCoustmersToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void formmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales form1 = new frmSales(); 
            this.Hide ();
            form1.Show();  
 
        }

        private void frmOrders1_Load(object sender, EventArgs e)
        {
            dt = sale.getfrmOrders1();
            dgvOrders.DataSource = dt;
        }
    }
}
