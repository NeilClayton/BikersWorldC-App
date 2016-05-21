using Novacode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikersWorld
{
    class salesNC : sale
    {
        string query;
        DataTable dt = new DataTable();
        dbNC accessDB = new dbNC();


        public void reportSalesPerson(int id, string name, string start, string end) {
            query = "SELECT * FROM sales WHERE employee_id = " + id + " AND date >= '" + start + "' AND date <= '" + end + "'";

            dt = accessDB.individualPersonSales(query);

            // inform user where file is to be saved
            MessageBox.Show("This document will be saved as default to your desktop", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = path + "\\" + name +"SalesReport.docx";
            var doc = DocX.Create(fileName);
            doc.PageLayout.Orientation = Novacode.Orientation.Landscape;
            var company = doc.InsertParagraph("Biker's World");
            company.StyleName = "Heading1";
            doc.InsertParagraph();
            doc.InsertParagraph("Report Type: \tSales Person Report");
            doc.InsertParagraph();
            doc.InsertParagraph("Printed: \t" + DateTime.Now);
            doc.InsertParagraph();
            doc.InsertParagraph("Description: \tThis report details the sales of " + name + " from " + start + " to " + end);
            doc.InsertParagraph();


            int rows = dt.Rows.Count;
            int columns = 5;
            Table brief = doc.AddTable(2, columns);
            brief.Alignment = Alignment.center;
            brief.Design = TableDesign.MediumGrid1Accent5;

            brief.Rows[0].Cells[0].Paragraphs.First().Append("Employee ID");
            brief.Rows[0].Cells[1].Paragraphs.First().Append("Employee Name");
            brief.Rows[0].Cells[2].Paragraphs.First().Append("Start Date");
            brief.Rows[0].Cells[3].Paragraphs.First().Append("End Date");
            brief.Rows[0].Cells[4].Paragraphs.First().Append("Total Sales");

            brief.Rows[1].Cells[0].Paragraphs.First().Append(id.ToString());
            brief.Rows[1].Cells[1].Paragraphs.First().Append(name);
            brief.Rows[1].Cells[2].Paragraphs.First().Append(start);
            brief.Rows[1].Cells[3].Paragraphs.First().Append(end);
            brief.Rows[1].Cells[4].Paragraphs.First().Append(dt.Rows.Count.ToString());


            Table t = doc.AddTable(brief.Rows.Count, 6);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.MediumGrid1Accent5;
            
            t.Rows[0].Cells[0].Paragraphs.First().Append("Sale ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("Order Date");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Item Sold");
            t.Rows[0].Cells[3].Paragraphs.First().Append("Quantity");
            t.Rows[0].Cells[4].Paragraphs.First().Append("Price");
            t.Rows[0].Cells[5].Paragraphs.First().Append("Total");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                query = "SELECT sales.sales_id, sales.date, items.item_name, orderline.quantity, items.price FROM bikersworld.sales LEFT JOIN bikersworld.orderline ON sales.sales_id = orderline.sales_id LEFT JOIN bikersworld.items ON  orderline.item_id = items.item_id WHERE sales.sales_id = " + dt.Rows[i]["sales_id"];
                DataTable individualSalesInformation = new DataTable();
                individualSalesInformation = accessDB.individualPersonSales(query);
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    for (int k = 0; k < individualSalesInformation.Rows.Count; k++)
                    {
                        t.Rows[k + 1].Cells[0].Paragraphs.First().Append(individualSalesInformation.Rows[k]["sales_id"].ToString());
                        t.Rows[k + 1].Cells[1].Paragraphs.First().Append(individualSalesInformation.Rows[k]["date"].ToString());
                        t.Rows[k + 1].Cells[2].Paragraphs.First().Append(individualSalesInformation.Rows[k]["item_name"].ToString());
                        t.Rows[k + 1].Cells[3].Paragraphs.First().Append(individualSalesInformation.Rows[k]["quantity"].ToString());
                        t.Rows[k + 1].Cells[4].Paragraphs.First().Append(individualSalesInformation.Rows[k]["price"].ToString());
                        double total = Convert.ToDouble(individualSalesInformation.Rows[k]["quantity"]) * Convert.ToDouble(individualSalesInformation.Rows[k]["price"]);
                        t.Rows[k + 1].Cells[5].Paragraphs.First().Append(total.ToString());

                    }
                }

            }
            
            

            doc.InsertTable(brief);
            doc.InsertParagraph();
            doc.InsertTable(t);
            doc.Save();

            Process.Start("WINWORD.EXE", fileName);


        }

        public void reportProduct(int id, string name, string start, string end)
        {
            query = "SELECT * FROM sales WHERE item_id = " + id + " AND date >= '" + start + "' AND date <= '" + end + "'";

            dt = accessDB.individualPersonSales(query);

            // inform user where file is to be saved
            MessageBox.Show("This document will be saved as default to your desktop", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = path + "\\" + name + "SaleReport.docx";
            var doc = DocX.Create(fileName);
            doc.PageLayout.Orientation = Novacode.Orientation.Landscape;
            var company = doc.InsertParagraph("Biker's World");
            company.StyleName = "Heading1";
            doc.InsertParagraph();
            doc.InsertParagraph("Report Type: \tProduct " + name + " Sale Report");
            doc.InsertParagraph();
            doc.InsertParagraph("Printed: \t" + DateTime.Now);
            doc.InsertParagraph();
            doc.InsertParagraph("Description: \tThis report details the sale of Product " + name + " from " + start + " to " + end);
            doc.InsertParagraph();


            int rows = dt.Rows.Count;
            int columns = 5;
            Table brief = doc.AddTable(2, columns);
            brief.Alignment = Alignment.center;
            brief.Design = TableDesign.MediumGrid1Accent5;

            brief.Rows[0].Cells[0].Paragraphs.First().Append("Item ID");
            brief.Rows[0].Cells[1].Paragraphs.First().Append("Item Name");
            brief.Rows[0].Cells[2].Paragraphs.First().Append("Start Date");
            brief.Rows[0].Cells[3].Paragraphs.First().Append("End Date");
            brief.Rows[0].Cells[4].Paragraphs.First().Append("Total Sales");

            brief.Rows[1].Cells[0].Paragraphs.First().Append(id.ToString());
            brief.Rows[1].Cells[1].Paragraphs.First().Append(name);
            brief.Rows[1].Cells[2].Paragraphs.First().Append(start);
            brief.Rows[1].Cells[3].Paragraphs.First().Append(end);
            brief.Rows[1].Cells[4].Paragraphs.First().Append(dt.Rows.Count.ToString());


            Table t = doc.AddTable(brief.Rows.Count, 5);
            t.Alignment = Alignment.center;
            t.Design = TableDesign.MediumGrid1Accent5;

            t.Rows[0].Cells[0].Paragraphs.First().Append("Sale ID");
            t.Rows[0].Cells[1].Paragraphs.First().Append("Customer ID");
            t.Rows[0].Cells[2].Paragraphs.First().Append("Quantity");
            t.Rows[0].Cells[3].Paragraphs.First().Append("Employee ID");
            t.Rows[0].Cells[4].Paragraphs.First().Append("Date");
            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                        t.Rows[i + 1].Cells[0].Paragraphs.First().Append(dt.Rows[i]["sales_id"].ToString());
                        t.Rows[i + 1].Cells[1].Paragraphs.First().Append(dt.Rows[i]["customer_id"].ToString());
                        t.Rows[i + 1].Cells[2].Paragraphs.First().Append(dt.Rows[i]["quantity"].ToString());
                        t.Rows[i + 1].Cells[3].Paragraphs.First().Append(dt.Rows[i]["employee_id"].ToString());
                        t.Rows[i + 1].Cells[4].Paragraphs.First().Append(dt.Rows[i]["date"].ToString());
                        
                    
                

            }



            doc.InsertTable(brief);
            doc.InsertParagraph();
            doc.InsertTable(t);
            doc.Save();

            Process.Start("WINWORD.EXE", fileName);
        }

    }
}
