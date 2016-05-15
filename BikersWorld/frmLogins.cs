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
    public partial class frmLogins : Form
    {
        private string selectedID;

        dbR myDB = new dbR();
        DataTable dt = new DataTable();
        bool loginStatus;



        private void  loginStat()
        {
            dt = myDB.getDataTable("SELECT * FROM login WHERE employee_id=" + selectedID + "");
            if (dt.Rows.Count > 0)
            {
                lbluser.Text = "Employee Number: " + selectedID + "         (Active)";
                txtUser.ReadOnly = true;

                loginStatus = true;
                txtUser.Text = dt.Rows[0].Field<string>(2);
            }
            else
            {
                lbluser.Text = "Employee Number: " + selectedID + "      (Login Not yet Created)";
                txtUser.ReadOnly = false;
                loginStatus = false;

            }
        }




        public frmLogins(string selectedID)
        {
            InitializeComponent();
            this.selectedID = selectedID;
        }
   

        private void frmLogins_Load(object sender, EventArgs e)
        {


            loginStat();
           


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("please insert a valid Username");


            }else
            {

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {




                    MessageBox.Show("please insert a valid Password");

                }
                else
                {

                    if (txtPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show("Password and Confirms password are not the same");

                    }
                    else
                    {
                        string password = myDB.getMD5Hash(txtPassword.Text);

                        switch (loginStatus)
                        {
                            case false:
                                myDB.insert(" insert into login (employee_id, username, password) value(" + selectedID + ", '" + txtUser.Text + "', '" + password + "')");
                                loginStat();


                                break;
                            case true:
                                myDB.update("update login set password='" + password + "'");

                                break;
                        }




                    }


                }

            }
    

        }

      
    }


}
