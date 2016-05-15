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
    public partial class frmManagementProducts : Form
    {

        Item newItem = new Item();
        supplier newsuppl = new supplier();
        string selectedID;
        bool submitNew; 
        string query = "";     

        public frmManagementProducts()
        {
            InitializeComponent();
        }

        private void lblEmailEdit_Click(object sender, EventArgs e)
        {

        }

        private void frmManagementProducts_Load(object sender, EventArgs e)
        {
            getAllProducts();


        }
        private void populateForm()
        {
            if (dgvProdList.SelectedRows.Count > 0)
            {
                int selectedRow = dgvProdList.CurrentRow.Index;
                selectedID = dgvProdList.Rows[selectedRow].Cells[0].Value.ToString();
                txtProdNameEdit.Text = dgvProdList.Rows[selectedRow].Cells[1].Value.ToString();
                txtDescriptionEdit.Text = dgvProdList.Rows[selectedRow].Cells[2].Value.ToString();
                cmbSupplier.DataSource = newsuppl.getSupplIdList();
                cmbSupplier.DisplayMember = "supplier_name";
                cmbSupplier.ValueMember = "supplier_id";
                cmbSupplier.SelectedValue = Int32.Parse(dgvProdList.Rows[selectedRow].Cells[3].Value.ToString());
                txtPriceEdit.Text = dgvProdList.Rows[selectedRow].Cells[5].Value.ToString();
                txtStackEdit.Text = dgvProdList.Rows[selectedRow].Cells[6].Value.ToString();
                grbEdit.Text = "Product Id:" + selectedID;
                pnlOptions.Visible = true;
                btnCancel.Visible = false;
                btnSubmit.Visible = false;
                AppTools.disableControlsGrb(grbEdit);

            }


        }

        private void dgvProdList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            populateForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
      

            AppTools.ResetAllGrb(grbEdit);
            AppTools.disableControlsGrb(grbEdit);
            pnlOptions.Visible = false;
            btnSubmit.Visible = false;


            if (string.IsNullOrWhiteSpace(txtProndId.Text) && string.IsNullOrWhiteSpace(txtProdName.Text))
            {




                MessageBox.Show("please insert a valid value");

            }
            else
            {

                query = "select item_id,item_name, description, items.supplier_id, suppliers.supplier_name, price, quantity"+
                    " from bikersworld.items  inner join suppliers ON items.supplier_id = suppliers.supplier_id  WHERE item_id ='"+ txtProndId.Text + "' OR item_name LIKE '"+ txtProdName.Text + "' ORDER BY item_id ";
                dgvProdList.DataSource = dgvProdList.DataSource = newItem.getProducts(query);
                populateForm();

            }


         


        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            getAllProducts();
          

        }
        private void getAllProducts()
        {
            query = "select item_id,item_name, description, items.supplier_id, suppliers.supplier_name, price, quantity from bikersworld.items  inner join suppliers ON items.supplier_id = suppliers.supplier_id ORDER BY item_id ";
            dgvProdList.DataSource = newItem.getProducts(query);
            populateForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AppTools.enableControlsGrb(grbEdit);
            btnCancel.Visible = true;
            btnSubmit.Visible = true;
            pnlOptions.Visible = false;
            submitNew = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

          
            populateForm();
        }

        private void brnNew_Click(object sender, EventArgs e)
        {
            submitNew = true;
            AppTools.ResetAllGrb(grbEdit);
            AppTools.enableControlsGrb(grbEdit);
            btnCancel.Visible = true;
            btnSubmit.Visible = true;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Item submitItem = new Item(Convert.ToInt16(selectedID), txtProdNameEdit.Text, txtDescriptionEdit.Text, Convert.ToInt16(cmbSupplier.SelectedValue.ToString()), cmbSupplier.SelectedText,Convert.ToDouble( txtPriceEdit.Text), Convert.ToInt32 (txtStackEdit.Text));

            switch (submitNew)
            {
                case true:
                    submitItem.newProduct();
                    getAllProducts();
                  int total= dgvProdList.Rows.Count -1 ;
                   dgvProdList.CurrentCell = dgvProdList.Rows[total].Cells[0];
                    populateForm();
                    
                    break;

                case false:
                
                    submitItem.updateProducts();
                    string  valTest = Convert.ToString(submitItem.ItemID);
                    getAllProducts();

                    int rowIndex = -1;

                    DataGridViewRow row = dgvProdList.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => r.Cells[0].Value.ToString().Equals(valTest))
                        .First();

                    rowIndex = row.Index;   

                    dgvProdList.CurrentCell = dgvProdList.Rows[rowIndex].Cells[0];
                    populateForm();

                    break;

            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
