using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region
/*
 * Submit button functionality
 * Submit menu strip functionality
 */
#endregion

namespace BikersWorld
{
    public partial class frmLogNewJob : Form
    {
        public frmLogNewJob()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtEmployeeID.Clear();
            txtDescription.Clear();
            txtDateLogged.Clear();
            txtDateStarted.Clear();
            txtEstimatedCompletionDate.Clear();
            txtDateCompleted.Clear();
            combJobOpenClose.Text = ("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtEmployeeID.Clear();
            txtDescription.Clear();
            txtDateLogged.Clear();
            txtDateStarted.Clear();
            txtEstimatedCompletionDate.Clear();
            txtDateCompleted.Clear();
            combJobOpenClose.Text = ("");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogNewJob_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            job thisJob = new job();
            thisJob.CustomerID = Convert.ToInt16 (txtCustomerID.Text);
            thisJob.EmployeeID = Convert.ToInt16 (txtEmployeeID.Text);
            thisJob.Description = txtDescription.Text;
            thisJob.DateLogged = txtDateLogged.Text;
            thisJob.DateStarted = txtDateStarted.Text;
            thisJob.EstimatedCompletionDate = txtEstimatedCompletionDate.Text;
            thisJob.DateCompleted = txtDateCompleted.Text;
            thisJob.JobOpenClose = Convert.ToInt16 (combJobOpenClose.Text);

            thisJob.insertJob(thisJob);
        }
    }
}
