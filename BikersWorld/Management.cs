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
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void stockControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockControl stock = new frmStockControl();
            stock.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStockControl_Click(object sender, EventArgs e)
        {
            frmStockControl stock = new frmStockControl();
            stock.ShowDialog();
        }
    }
}
