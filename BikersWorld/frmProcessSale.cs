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
    public partial class frmProcessSale : Form
    {
        dbB newDB = new dbB();
        DataTable newGrid = new DataTable();
        Item items = new Item();
        Customer thisCustomer = new Customer();
        public frmProcessSale()
        {
            InitializeComponent();
        }

        private void frmProcessSale_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM  customer";
            newGrid = newDB.getDataTable(query);
            dgvCustomers.DataSource = newGrid;

            query = "SELECT * FROM items";
            newGrid = newDB.getDataTable(query);
            dgvItems.DataSource = newGrid;

            grpItems.Enabled = false;
            btnProcessOrder.Enabled = false;
            


        }
        /// <summary>
        /// Search for products within the database on name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnItemSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter some criteria in order to search upon!", "No Search Criteria", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtItemName.Focus();
            }
            else if (txtItemName.Text.Length > 0)
            {
                newGrid = items.searchProducts(txtItemName.Text, null, "product");
                dgvItems.DataSource = newGrid;
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM  items";
            newGrid = newDB.getDataTable(query);
            dgvItems.DataSource = newGrid;
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            items.ItemID = Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value);
            items.ItemName = (dgvItems.CurrentRow.Cells[1].Value.ToString());
            items.ItemDescription = (dgvItems.CurrentRow.Cells[2].Value.ToString());
            items.ItemSupplierID = Convert.ToInt32(dgvItems.CurrentRow.Cells[3].Value);
            items.ItemPrice = Convert.ToDouble(dgvItems.CurrentRow.Cells[4].Value);
            items.ItemStock = Convert.ToInt32(dgvItems.CurrentRow.Cells[5].Value);

            lblSelectedID.Text = items.ItemID.ToString();
            lblSelectedName.Text = items.ItemName;
            txtQuantity.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int quantity;

            if (int.TryParse(txtQuantity.Text, out quantity)){
                
                lstItemsOrdered.Items.Add(lblSelectedID.Text + " - " + lblSelectedName.Text + " - Qty: " + txtQuantity.Text);
                txtQuantity.Text = "";
                btnProcessOrder.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Clear();
                txtQuantity.Focus();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtPostcode.Text) && string.IsNullOrWhiteSpace(txtID.Text) && string.IsNullOrWhiteSpace(txtTelephone.Text))
            {

                MessageBox.Show("please insert a valid value");

            }
            else
            {
                string query = "SELECT * FROM  customer WHERE customer_id LIKE '" + txtID.Text + "' OR postcode LIKE '" + txtPostcode.Text + "' OR forename LIKE '" + txtName.Text + "'OR telephone_1 LIKE'" + txtTelephone.Text + "'";


                newGrid = newDB.getDataTable(query);
                dgvCustomers.DataSource = newGrid;

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM  customer";
            newGrid = newDB.getDataTable(query);
            dgvCustomers.DataSource = newGrid;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thisCustomer.CustomerID = Convert.ToInt16(dgvCustomers.CurrentRow.Cells[0].Value);

            grpItems.Enabled = true;
            txtQuantity.Enabled = false;
            btnAdd.Enabled = false;
        }
    }



    

    }
