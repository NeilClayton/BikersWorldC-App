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

    #region to do
    // interface improvements
    // key shortcuts
    // tab sequence 

    #endregion
    public partial class frmStaffManagement : Form
    {
        db search = new db();
        DataTable dt = new DataTable();
        string selectedID;
        int switch_on = 0;


        public frmStaffManagement()
        {
            InitializeComponent();
        }

        private void frmStaffManagement_Load(object sender, EventArgs e)
        {
           

            AppTools.disableControlsGrb(grbEdit);
           
              
           
           dt = search.getAllStaff();

           dgvStaffList.DataSource = dt;

            cboJobRoleEdit.DataSource = search.getJobRole();
            cboJobRoleEdit.DisplayMember = "Job_Role_name";
            cboJobRoleEdit.ValueMember = "job_role_id";

            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            selectedID = null;
            grbEdit.Text = "Staff N:";
            AppTools.ResetAllGrb(grbEdit);
            AppTools.disableControlsGrb(grbEdit);
            grbOptions.Visible = false;
            btnSubmit.Visible = false;
            btnLogin.Visible = false;

            if (string.IsNullOrWhiteSpace(txtStaffId.Text) && string.IsNullOrWhiteSpace(txtStaffFirstName.Text) && string.IsNullOrWhiteSpace(txtLastName.Text))
            {

               


                MessageBox.Show("please insert a valid value");

            }
            else
            {

                dt = search.getStaffSearch(txtStaffId.Text, txtStaffFirstName.Text, txtLastName.Text);

                dgvStaffList.DataSource = dt;
               
            }
            
         
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            switch_on = 2;
            AppTools.enableControlsGrb(grbEdit);
            btnLogin.Visible = false;
            btnSubmit.Visible = true;
            btnCancel.Visible = true;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


           

            switch (switch_on)
            {
                case 1:
                    search.newEmploeeTabbe(cboTitleEdit.Text, txtFirstNameEdit.Text, txtLastNameEdit.Text, txtAddressLineOneEdit.Text, txtAddressLineTwoEdit.Text, txtAddressLineThreeEdit.Text,
                     txtPostalCodeEdit.Text, txtTelephoneOneEdit.Text, txtTelephoneTwoEdit.Text, txtEmailEdit.Text, Convert.ToString(cboJobRoleEdit.SelectedValue));
                    dt = search.getLastEmplyeeEntry();
                    break;
                case 2:
                    search.updateEmploeeTabbe(selectedID, cboTitleEdit.Text, txtFirstNameEdit.Text, txtLastNameEdit.Text, txtAddressLineOneEdit.Text, txtAddressLineTwoEdit.Text, txtAddressLineThreeEdit.Text,
                    txtPostalCodeEdit.Text, txtTelephoneOneEdit.Text, txtTelephoneTwoEdit.Text, txtEmailEdit.Text, Convert.ToString(cboJobRoleEdit.SelectedValue));

                    dt = search.getStaffSearch(selectedID, "", "");
                    break;
                     

            }

            AppTools.ResetAllGrb(grbEdit);
            AppTools.disableControlsGrb(grbEdit);
            dgvStaffList.DataSource = dt;
            selectedID = null;
            grbEdit.Text = "Staff N:";
            btnLogin.Visible = false;
            btnSubmit.Visible = false;
            btnCancel.Visible = false;





        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            selectedID = null;
            grbEdit.Text = "Staff N:";
            btnLogin.Visible = false;
            btnSubmit.Visible = false;
            btnCancel.Visible = false;
            grbOptions.Visible = false;

            dt = search.getAllStaff();

            dgvStaffList.DataSource = dt;
            AppTools.ResetAllGrb(grbEdit);
            AppTools.disableControlsGrb(grbEdit);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee", "Delete confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                btnLogin.Visible = false;
                search.deleteEmploeeTabbe(selectedID);
                dt = search.getAllStaff();

                dgvStaffList.DataSource = dt;

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }


        }

        private void brnNew_Click(object sender, EventArgs e)
        {
            switch_on = 1; 
            dgvStaffList.ClearSelection();
            AppTools.ResetAllGrb(grbEdit);
            AppTools.enableControlsGrb(grbEdit);
            btnLogin.Visible = false;
            btnSubmit.Visible = true;
            btnCancel.Visible = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            

            frmLogins logins = new frmLogins(selectedID) ;
            logins.Show();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
          
            btnLogin.Visible = false;
            btnSubmit.Visible = false;
            btnCancel.Visible = false;
            AppTools.disableControlsGrb(grbEdit);

        }

<<<<<<< HEAD
        private void dgvStaffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedRow = dgvStaffList.CurrentRow.Index;


            selectedID = dgvStaffList.Rows[selectedRow].Cells[0].Value.ToString();
            cboTitleEdit.Text = dgvStaffList.Rows[selectedRow].Cells[1].Value.ToString();
            txtFirstNameEdit.Text = dgvStaffList.Rows[selectedRow].Cells[2].Value.ToString();
            txtLastNameEdit.Text = dgvStaffList.Rows[selectedRow].Cells[3].Value.ToString();
            txtAddressLineOneEdit.Text = dgvStaffList.Rows[selectedRow].Cells[4].Value.ToString();
            txtAddressLineTwoEdit.Text = dgvStaffList.Rows[selectedRow].Cells[5].Value.ToString();
            txtAddressLineThreeEdit.Text = dgvStaffList.Rows[selectedRow].Cells[6].Value.ToString();
            txtPostalCodeEdit.Text = dgvStaffList.Rows[selectedRow].Cells[7].Value.ToString();
            txtTelephoneOneEdit.Text = dgvStaffList.Rows[selectedRow].Cells[8].Value.ToString();
            txtTelephoneTwoEdit.Text = dgvStaffList.Rows[selectedRow].Cells[9].Value.ToString();
            txtEmailEdit.Text = dgvStaffList.Rows[selectedRow].Cells[10].Value.ToString();
            cboJobRoleEdit.Text = dgvStaffList.Rows[selectedRow].Cells[12].Value.ToString();

            AppTools.disableControlsGrb(grbEdit);
            grbEdit.Text = "Staff N:" + selectedID;
            grbOptions.Visible = true;
            btnLogin.Visible = true;
=======
        private void dgvStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

>>>>>>> refs/remotes/origin/master
        }

        
    }
}
