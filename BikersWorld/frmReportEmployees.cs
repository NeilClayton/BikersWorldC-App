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
using System.Diagnostics;

namespace BikersWorld
{
    public partial class frmReportEmployees : Form
    {
        dbR myDB = new dbR();
        DataTable dtSales = new DataTable();
        DataTable dtJobs = new DataTable();
        DataTable dt = new DataTable();


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
            dt = myDB.getDataTable("SELECT employee_id, Title, CONCAT(forename,' ' ,surname) as 'Name', CONCAT(address_1,'    ',address_2,'    ' ,address_3)AS 'Adress', postcode, CONCAT('CTC1:(',telephone_1,')  CTC2:(',telephone_2,')') AS contacts, email, (date_format(date,'%d-%m-%Y'))As 'date'  From employee where job_role_id= 2");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string wordFile = path + "\\TechnicianReport_"+DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")+".docx";
            var doc = DocX.Create(wordFile);
            doc.PageLayout.Orientation = Novacode.Orientation.Landscape;
            var company = doc.InsertParagraph("Biker's World");
            company.StyleName = "Heading1";
            doc.InsertParagraph();
            doc.InsertParagraph("Report Type: \tTechnician List");
            doc.InsertParagraph();
            doc.InsertParagraph("Printed: \t" + DateTime.Now);
            doc.InsertParagraph();
            doc.InsertParagraph("Description: \tThis Report contains a list of all technician");
            doc.InsertParagraph();
          
            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;
            Table tb = doc.AddTable(rows + 1, columns);

            tb.Alignment = Alignment.center;
            tb.Design = TableDesign.MediumGrid1Accent5;
            

            tb.Rows[0].Cells[0].Paragraphs.First().Append("ID");
            tb.Rows[0].Cells[1].Paragraphs.First().Append("Title");
            tb.Rows[0].Cells[2].Paragraphs.First().Append("Name");
            tb.Rows[0].Cells[3].Paragraphs.First().Append("Address");
            tb.Rows[0].Cells[4].Paragraphs.First().Append("Postal Code");
            tb.Rows[0].Cells[5].Paragraphs.First().Append("Contacts");
            tb.Rows[0].Cells[6].Paragraphs.First().Append("Email");
            tb.Rows[0].Cells[7].Paragraphs.First().Append("Date Added");
           

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tb.Rows[i + 1].Cells[j].Paragraphs.First().Append(dt.Rows[i][j].ToString());
                }
            }

            doc.InsertTable(tb);


            doc.Save();

            Process.Start("WINWORD.EXE", wordFile);
        
    }


       

        private void button1_Click(object sender, EventArgs e)
        {
            dt = myDB.getDataTable("SELECT employee_id, Title, CONCAT(forename,' ' ,surname) as 'Name', CONCAT(address_1,'    ',address_2,'    ' ,address_3), postcode, CONCAT('CTC1:(',telephone_1,')  CTC2:(',telephone_2,')') AS contacts, email, (date_format(date,'%d-%m-%Y'))As 'date' , job_role.job_role_name From employee  inner join job_role ON employee.job_role_id = job_role.job_role_id ");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string wordFile = path + "\\EmployeeReport_"+DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")+".docx";
            var doc = DocX.Create(wordFile);
            doc.PageLayout.Orientation = Novacode.Orientation.Landscape;
            var company = doc.InsertParagraph("Biker's World");
            company.StyleName = "Heading1";
            doc.InsertParagraph();
            doc.InsertParagraph("Report Type: \tEmployee List");
            doc.InsertParagraph();
            doc.InsertParagraph("Printed: \t" + DateTime.Now);
            doc.InsertParagraph();
            doc.InsertParagraph("Description: \tThis Report contains a list of all employees");
            doc.InsertParagraph();
          
            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;
            Table tb = doc.AddTable(rows + 1, columns);

            tb.Alignment = Alignment.center;
            tb.Design = TableDesign.MediumGrid1Accent5;
            

            tb.Rows[0].Cells[0].Paragraphs.First().Append("ID");
            tb.Rows[0].Cells[1].Paragraphs.First().Append("Title");
            tb.Rows[0].Cells[2].Paragraphs.First().Append("Name");
            tb.Rows[0].Cells[3].Paragraphs.First().Append("Address");
            tb.Rows[0].Cells[4].Paragraphs.First().Append("Postal Code");
            tb.Rows[0].Cells[5].Paragraphs.First().Append("Contacts");
            tb.Rows[0].Cells[6].Paragraphs.First().Append("Email");
            tb.Rows[0].Cells[7].Paragraphs.First().Append("Date Added");
            tb.Rows[0].Cells[8].Paragraphs.First().Append("job Role");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tb.Rows[i + 1].Cells[j].Paragraphs.First().Append(dt.Rows[i][j].ToString());
                }
            }

            doc.InsertTable(tb);


            doc.Save();

            Process.Start("WINWORD.EXE", wordFile);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt = myDB.getDataTable("SELECT employee_id, Title, CONCAT(forename,' ' ,surname) as 'Name', CONCAT(address_1,'    ',address_2,'    ' ,address_3)AS 'Adress', postcode, CONCAT('CTC1:(',telephone_1,')  CTC2:(',telephone_2,')') AS contacts, email, (date_format(date,'%d-%m-%Y'))As 'date'  From employee where job_role_id= 3");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string wordFile = path + "\\salesPersonalReport_" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".docx";
            var doc = DocX.Create(wordFile);
            doc.PageLayout.Orientation = Novacode.Orientation.Landscape;
            var company = doc.InsertParagraph("Biker's World");
            company.StyleName = "Heading1";
            doc.InsertParagraph();
            doc.InsertParagraph("Report Type: \tSales personal list");
            doc.InsertParagraph();
            doc.InsertParagraph("Printed: \t" + DateTime.Now);
            doc.InsertParagraph();
            doc.InsertParagraph("Description: \tThis report contains a list of all sales personal");
            doc.InsertParagraph();

            int rows = dt.Rows.Count;
            int columns = dt.Columns.Count;
            Table tb = doc.AddTable(rows + 1, columns);

            tb.Alignment = Alignment.center;
            tb.Design = TableDesign.MediumGrid1Accent5;


            tb.Rows[0].Cells[0].Paragraphs.First().Append("ID");
            tb.Rows[0].Cells[1].Paragraphs.First().Append("Title");
            tb.Rows[0].Cells[2].Paragraphs.First().Append("Name");
            tb.Rows[0].Cells[3].Paragraphs.First().Append("Address");
            tb.Rows[0].Cells[4].Paragraphs.First().Append("Postal Code");
            tb.Rows[0].Cells[5].Paragraphs.First().Append("Contacts");
            tb.Rows[0].Cells[6].Paragraphs.First().Append("Email");
            tb.Rows[0].Cells[7].Paragraphs.First().Append("Date Added");


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tb.Rows[i + 1].Cells[j].Paragraphs.First().Append(dt.Rows[i][j].ToString());
                }
            }

            doc.InsertTable(tb);


            doc.Save();

            Process.Start("WINWORD.EXE", wordFile);

        }
    }
}
