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
    public partial class frmReportSales : Form
    {
        public frmReportSales()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();
        Item item = new Item();
        DataTable dt = new DataTable();
        salesNC sales = new salesNC();
        private void frmReportSales_Load(object sender, EventArgs e)
        {
            dt = employee.getEmployeeIDandName();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboSalesPerson.Items.Add(dt.Rows[i]["employee_id"] + " " + dt.Rows[i]["forename"] + " " + dt.Rows[i]["surname"]);
            }

            cboSalesPerson.SelectedIndex = 0;

            
            dt = item.getItems();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboProducts.Items.Add(dt.Rows[i]["item_id"] + " " + dt.Rows[i]["item_name"]);
            }

            cboProducts.SelectedIndex = 0;            
        }
        
        

        private void btnRunSalesPerson_Click(object sender, EventArgs e)
        {
            string salesPerson = cboSalesPerson.Text.ToString();
            //splits the string by null - in this instance null defaults to a space
            string[] split = salesPerson.Split(null);
            //grabs the first part of the split that is stored in an array and coverts it to an integer for report purposes
            int employeeID = Convert.ToInt16(split[0]);
            string concatenatedName = split[1] + " " + split[2];
            string start = dtpSalesPersonStart.Value.ToString("yyyy/MM/dd");
            string end = dtpSalePersonEnd.Value.ToString("yyyy/MM/dd");

            sales.reportSalesPerson(employeeID, concatenatedName, start, end);

        }

        private void btnRunProductReport_Click(object sender, EventArgs e)
        {
            string selectedItem = cboProducts.Text.ToString();

            string[] split = selectedItem.Split(null);
            int itemID = Convert.ToInt16(split[0]);
            string itemName = "";
            for (int i = 1; i < split.Length - 1; i++)
            {
                itemName += " " + split[i].ToString();
            }
            string start = dtpProductStart.Value.ToString("yyyy/MM/dd");
            string end = dtpProductEnd.Value.ToString("yyyy/MM/dd");

            sales.reportProduct(itemID, itemName, start, end);
        }
    }
}
