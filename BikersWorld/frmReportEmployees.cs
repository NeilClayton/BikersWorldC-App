using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novacode;

namespace BikersWorld
{
    public partial class frmReportEmployees : Form
    {
        dbR myDB = new dbR();
        DataTable dtSales = new DataTable();
        DataTable dtJobs = new DataTable();


        public frmReportEmployees()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void frmReportEmployees_Load(object sender, EventArgs e)
        {

           dtSales = myDB.getDataTable("SELECT (count(item_id)) AS Total, sales.employee_id, (employee.forename) AS Name FROM bikersworld.sales  inner join employee ON sales.employee_id = employee.employee_id GROUP BY employee_id");
            chartSales.Series.Add("Employees");
            chartSales.Series["Employees"].XValueMember = "Name";
            chartSales.Series["Employees"].YValueMembers = "Total";
            chartSales.DataSource = dtSales;
            chartSales.DataBind();
            chartSales.Series["Employees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            dtJobs = myDB.getDataTable(" SELECT(count(job_id)) as Jobs, (employee.forename) as Name, jobs.employee_id FROM jobs inner join employee ON jobs.employee_id = employee.employee_id Group by jobs.employee_id");
            chartJobs.Series.Add("Mechanic");
            chartJobs.Series["Mechanic"].XValueMember = "Name";
            chartJobs.Series["Mechanic"].YValueMembers = "Jobs";
            chartJobs.DataSource = dtJobs;
            chartJobs.DataBind();
            chartJobs.Series["Mechanic"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
