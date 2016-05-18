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

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {

           
            AppTools.formVerifyAndOpen<frmStaffManagement>("frmStaffManagement");


        }   



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStockControl_Click(object sender, EventArgs e)
        {
            
            AppTools.formVerifyAndOpen<frmStockControl>("frmStockControl");
        }

        private void btnProcessJob_Click(object sender, EventArgs e)
        {
            AppTools.formVerifyAndOpen<frmTechnicianHub>("frmTechnicianHub");
        }

        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            
            AppTools.formVerifyAndOpen<frmSales>("frmSales");


        }

        private void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            AppTools.formVerifyAndOpen<frmSuppliersManagement>("frmSuppliersManagement");
        }

        private void btnJobReports_Click(object sender, EventArgs e)
        {
            AppTools.formVerifyAndOpen<frmReportJob>("frmReportJob");
        }

        private void btnEmployeeReports_Click(object sender, EventArgs e)
        {
            AppTools.formVerifyAndOpen<frmReportEmployees>("frmReportEmployees");
        }

        private void btnSalesReports_Click(object sender, EventArgs e)
        {
            AppTools.formVerifyAndOpen<frmReportSales>("frmReportSales");
        }

        private void btnProductsManagement_Click(object sender, EventArgs e)
        {
            AppTools.formVerifyAndOpen<frmManagementProducts>("frmManagementProducts");

        }
    }
}
