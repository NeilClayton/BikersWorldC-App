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
    public partial class frmStockControl : Form
    {
        public frmStockControl()
        {
            InitializeComponent();
        }

        private void frmStockControl_Load(object sender, EventArgs e)
        {
            //populate datagridview with all current products in the database
            db stockControl = new db();
            DataTable dt = new DataTable();
            if (dt != null)
            {
                dt = stockControl.getProducts();
                dgvProductInformation.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Unable to retrieve information from database, please contact your network administrator if the problem persists!");
            }

            //hide check box that is used to edit product details if the item name field is empty
           

            //disable and enable text fields used to end a item
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            db filterStock = new db();
            DataTable dt = new DataTable();

            if (string.IsNullOrWhiteSpace(txtProductName.Text) && string.IsNullOrWhiteSpace(txtManufacturer.Text))
            {
                MessageBox.Show("Please complete a field in order to search the database");
            }
            else if (txtManufacturer.Text.Length > 0 && txtProductName.Text.Length > 0)
            {
                dt = filterStock.filterProducts(txtProductName.Text, txtManufacturer.Text);
            }
            else if (txtManufacturer.Text.Length > 1 && string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                dt = filterStock.filterProducts(txtManufacturer.Text, "manufacturer");
            }
            else
            {
                dt = filterStock.filterProducts(txtProductName.Text, "product");
            }

            if (dt != null)
            {
                dgvProductInformation.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Unable to retrieve information from database, please contact your network administrator if the problem persists!");
            }

            

        }

        private void dgvProductInformation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int itemID = (int)dgvProductInformation.SelectedRows[0].Cells[0].Value;
                MessageBox.Show(itemID.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            db refreshDGV = new db();
            DataTable refresh = new DataTable();

            refresh = refreshDGV.getProducts();
            dgvProductInformation.DataSource = refresh;
            txtProductName.Clear();
            txtManufacturer.Clear();
            txtProductName.Focus();
        }

        private void tkbAddStockQuantity_Scroll(object sender, EventArgs e)
        {
            txtAddStockQty.Text = tkbAddStockQuantity.Value.ToString();
        }

        private void txtAddStockQty_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(txtAddStockQty.Text) > 0)
                {
                    int value = Convert.ToInt32(txtAddStockQty.Text);
                    tkbAddStockQuantity.Value = value;
                }
                else if (string.IsNullOrWhiteSpace(txtAddStockQty.Text))
                {
                    tkbAddStockQuantity.Value = 0;
                }
                else if (Convert.ToInt32(txtAddStockQty.Text) < 0)
                {
                    MessageBox.Show("Please enter a positive value?");
                    txtAddStockQty.Text = "0";

                }
                else if (Convert.ToInt32(txtAddStockQty.Text) > 100)
                {
                    MessageBox.Show("A stock quantity greater than 100 can be be added!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Value must be numerical");
                txtAddStockQty.Text = "0";
            }
        }
    }
}
