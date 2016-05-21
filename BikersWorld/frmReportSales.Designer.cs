namespace BikersWorld
{
    partial class frmReportSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpMonthlySalesComparasion = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpSalesPresonReport = new System.Windows.Forms.GroupBox();
            this.btnRunSalesPerson = new System.Windows.Forms.Button();
            this.cboSalesPerson = new System.Windows.Forms.ComboBox();
            this.dtpSalePersonEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpSalesPersonStart = new System.Windows.Forms.DateTimePicker();
            this.grpReportByProduct = new System.Windows.Forms.GroupBox();
            this.btnRunProductReport = new System.Windows.Forms.Button();
            this.cboProducts = new System.Windows.Forms.ComboBox();
            this.dtpProductEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpProductStart = new System.Windows.Forms.DateTimePicker();
            this.grpMonthlySalesComparasion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.grpSalesPresonReport.SuspendLayout();
            this.grpReportByProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMonthlySalesComparasion
            // 
            this.grpMonthlySalesComparasion.Controls.Add(this.chart1);
            this.grpMonthlySalesComparasion.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpMonthlySalesComparasion.Location = new System.Drawing.Point(13, 13);
            this.grpMonthlySalesComparasion.Name = "grpMonthlySalesComparasion";
            this.grpMonthlySalesComparasion.Size = new System.Drawing.Size(458, 361);
            this.grpMonthlySalesComparasion.TabIndex = 0;
            this.grpMonthlySalesComparasion.TabStop = false;
            this.grpMonthlySalesComparasion.Text = "Sales Comparasion By Month";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 20);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(445, 341);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // grpSalesPresonReport
            // 
            this.grpSalesPresonReport.Controls.Add(this.btnRunSalesPerson);
            this.grpSalesPresonReport.Controls.Add(this.cboSalesPerson);
            this.grpSalesPresonReport.Controls.Add(this.dtpSalePersonEnd);
            this.grpSalesPresonReport.Controls.Add(this.dtpSalesPersonStart);
            this.grpSalesPresonReport.Location = new System.Drawing.Point(478, 13);
            this.grpSalesPresonReport.Name = "grpSalesPresonReport";
            this.grpSalesPresonReport.Size = new System.Drawing.Size(512, 162);
            this.grpSalesPresonReport.TabIndex = 1;
            this.grpSalesPresonReport.TabStop = false;
            this.grpSalesPresonReport.Text = "Sales Person Report";
            // 
            // btnRunSalesPerson
            // 
            this.btnRunSalesPerson.Location = new System.Drawing.Point(283, 120);
            this.btnRunSalesPerson.Name = "btnRunSalesPerson";
            this.btnRunSalesPerson.Size = new System.Drawing.Size(167, 23);
            this.btnRunSalesPerson.TabIndex = 3;
            this.btnRunSalesPerson.Text = "Get &Sales Person Report";
            this.btnRunSalesPerson.UseVisualStyleBackColor = true;
            this.btnRunSalesPerson.Click += new System.EventHandler(this.btnRunSalesPerson_Click);
            // 
            // cboSalesPerson
            // 
            this.cboSalesPerson.FormattingEnabled = true;
            this.cboSalesPerson.Location = new System.Drawing.Point(7, 122);
            this.cboSalesPerson.Name = "cboSalesPerson";
            this.cboSalesPerson.Size = new System.Drawing.Size(200, 21);
            this.cboSalesPerson.TabIndex = 2;
            // 
            // dtpSalePersonEnd
            // 
            this.dtpSalePersonEnd.Location = new System.Drawing.Point(6, 74);
            this.dtpSalePersonEnd.Name = "dtpSalePersonEnd";
            this.dtpSalePersonEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpSalePersonEnd.TabIndex = 1;
            // 
            // dtpSalesPersonStart
            // 
            this.dtpSalesPersonStart.Location = new System.Drawing.Point(7, 30);
            this.dtpSalesPersonStart.Name = "dtpSalesPersonStart";
            this.dtpSalesPersonStart.Size = new System.Drawing.Size(200, 20);
            this.dtpSalesPersonStart.TabIndex = 0;
            // 
            // grpReportByProduct
            // 
            this.grpReportByProduct.Controls.Add(this.btnRunProductReport);
            this.grpReportByProduct.Controls.Add(this.cboProducts);
            this.grpReportByProduct.Controls.Add(this.dtpProductEnd);
            this.grpReportByProduct.Controls.Add(this.dtpProductStart);
            this.grpReportByProduct.Location = new System.Drawing.Point(478, 181);
            this.grpReportByProduct.Name = "grpReportByProduct";
            this.grpReportByProduct.Size = new System.Drawing.Size(512, 193);
            this.grpReportByProduct.TabIndex = 2;
            this.grpReportByProduct.TabStop = false;
            this.grpReportByProduct.Text = "Report by Product";
            // 
            // btnRunProductReport
            // 
            this.btnRunProductReport.Location = new System.Drawing.Point(283, 128);
            this.btnRunProductReport.Name = "btnRunProductReport";
            this.btnRunProductReport.Size = new System.Drawing.Size(167, 23);
            this.btnRunProductReport.TabIndex = 3;
            this.btnRunProductReport.Text = "Get &Product Sales Report";
            this.btnRunProductReport.UseVisualStyleBackColor = true;
            this.btnRunProductReport.Click += new System.EventHandler(this.btnRunProductReport_Click);
            // 
            // cboProducts
            // 
            this.cboProducts.FormattingEnabled = true;
            this.cboProducts.Location = new System.Drawing.Point(7, 128);
            this.cboProducts.Name = "cboProducts";
            this.cboProducts.Size = new System.Drawing.Size(200, 21);
            this.cboProducts.TabIndex = 2;
            // 
            // dtpProductEnd
            // 
            this.dtpProductEnd.Location = new System.Drawing.Point(7, 80);
            this.dtpProductEnd.Name = "dtpProductEnd";
            this.dtpProductEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpProductEnd.TabIndex = 1;
            // 
            // dtpProductStart
            // 
            this.dtpProductStart.Location = new System.Drawing.Point(7, 34);
            this.dtpProductStart.Name = "dtpProductStart";
            this.dtpProductStart.Size = new System.Drawing.Size(200, 20);
            this.dtpProductStart.TabIndex = 0;
            // 
            // frmReportSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 386);
            this.Controls.Add(this.grpReportByProduct);
            this.Controls.Add(this.grpSalesPresonReport);
            this.Controls.Add(this.grpMonthlySalesComparasion);
            this.Name = "frmReportSales";
            this.Text = "Sales Reports";
            this.Load += new System.EventHandler(this.frmReportSales_Load);
            this.grpMonthlySalesComparasion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.grpSalesPresonReport.ResumeLayout(false);
            this.grpReportByProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMonthlySalesComparasion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox grpSalesPresonReport;
        private System.Windows.Forms.ComboBox cboSalesPerson;
        private System.Windows.Forms.DateTimePicker dtpSalePersonEnd;
        private System.Windows.Forms.DateTimePicker dtpSalesPersonStart;
        private System.Windows.Forms.GroupBox grpReportByProduct;
        private System.Windows.Forms.ComboBox cboProducts;
        private System.Windows.Forms.DateTimePicker dtpProductEnd;
        private System.Windows.Forms.DateTimePicker dtpProductStart;
        private System.Windows.Forms.Button btnRunSalesPerson;
        private System.Windows.Forms.Button btnRunProductReport;
    }
}