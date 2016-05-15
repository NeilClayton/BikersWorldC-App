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
    public partial class frmSuppliersManagement : Form
    {

        supplier suppSearch = new supplier();
        string selectedID;
        int switch_on = 0;
        public frmSuppliersManagement()
        {
            InitializeComponent();
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {

          
            AppTools.ResetAllGrb(grbEdit);
            AppTools.disableControlsGrb(grbEdit);
            pnlOptions.Visible = false;
            btnSubmit.Visible = false;


            if (string.IsNullOrWhiteSpace(txtSuppId.Text) && string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {




                MessageBox.Show("please insert a valid value");

            }
            else
            {


                dgvSuppList.DataSource = suppSearch.getSearchSuppliers(txtSuppId.Text, txtSupplierName.Text);

            }


            this.populatForm();


        }


     


        private void frmSuppliersManagement_Load(object sender, EventArgs e)
        {
            dgvSuppList.DataSource = suppSearch.getAllSuppliers();
            AppTools.disableControlsGrb(grbEdit);
            pnlOptions.Visible = false;
            this.populatForm();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            
           
            #region group components handler 
            /*
             * 
             * code used to reset the content of the group boxes
             * and disable controls
             * 
             * */
            AppTools.ResetAllGrb(grbEdit);
            AppTools.ResetAllGrb(grbSearch);
            AppTools.disableControlsGrb(grbEdit);
            pnlOptions.Visible = false;
            btnSubmit.Visible = false;
            btnCancel.Visible = false;

            #endregion

            #region populate data grid view 
            /*
             *Get all Suppliers 
             */
            dgvSuppList.DataSource = suppSearch.getAllSuppliers();
            #endregion

            this.populatForm();
        }

        private void brnNew_Click(object sender, EventArgs e)
        {
            AppTools.ResetAllGrb(grbEdit);
            AppTools.enableControlsGrb(grbEdit);
            btnSubmit.Visible = true;
            btnCancel.Visible = true;
            switch_on = 1;
            pnlOptions.Visible = false;
        }

       

        private void dgvSuppList_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            int selectedRow = dgvSuppList.CurrentRow.Index;


            this.populatForm();


            AppTools.disableControlsGrb(grbEdit);
            
            pnlOptions.Visible = true;
          

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = false;
            AppTools.enableControlsGrb(grbEdit);
            btnSubmit.Visible = true;
            btnCancel.Visible = true;
            switch_on = 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlOptions.Visible = true;
            btnSubmit.Visible = false;
            btnCancel.Visible = false;
            AppTools.disableControlsGrb(grbEdit);

            
                this.populatForm();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            supplier supplierSubmit = new supplier( txtSupplierNameEdit.Text, txtAddressLineOneEdit.Text, txtAddressLineTwoEdit.Text, 
                txtAddressLineThreeEdit.Text,txtPostalCodeEdit.Text,
                txtTelephoneOneEdit.Text, txtTelephoneTwoEdit.Text,  txtEmailEdit.Text );


            switch (switch_on)
            {
                case 1:
                    supplierSubmit.submit();
                    break;
                    

                case 2 :
                    supplierSubmit.update(Convert.ToInt16(selectedID));

                    break;





            }
            #region populate data grid view
            /*
             *Get all Suppliers 
             */
            dgvSuppList.DataSource = suppSearch.getAllSuppliers();
            #endregion
          
            btnSubmit.Visible = false;
            btnCancel.Visible = false;
            AppTools.disableControlsGrb(grbEdit);

           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {



        }

        private  void populatForm()
        {
            if (dgvSuppList.SelectedRows.Count > 0)
            {
                int selectedRow = dgvSuppList.CurrentRow.Index;
                selectedID = dgvSuppList.Rows[selectedRow].Cells[0].Value.ToString();

                txtSupplierNameEdit.Text = dgvSuppList.Rows[selectedRow].Cells[1].Value.ToString();

                txtAddressLineOneEdit.Text = dgvSuppList.Rows[selectedRow].Cells[2].Value.ToString();
                txtAddressLineTwoEdit.Text = dgvSuppList.Rows[selectedRow].Cells[3].Value.ToString();
                txtAddressLineThreeEdit.Text = dgvSuppList.Rows[selectedRow].Cells[4].Value.ToString();
                txtPostalCodeEdit.Text = dgvSuppList.Rows[selectedRow].Cells[5].Value.ToString();
                txtTelephoneOneEdit.Text = dgvSuppList.Rows[selectedRow].Cells[6].Value.ToString();
                txtTelephoneTwoEdit.Text = dgvSuppList.Rows[selectedRow].Cells[7].Value.ToString();
                txtEmailEdit.Text = dgvSuppList.Rows[selectedRow].Cells[8].Value.ToString();
                grbEdit.Text = "Staff N:" + selectedID;
                pnlOptions.Visible = true;
            }
    

        }
    }
}
