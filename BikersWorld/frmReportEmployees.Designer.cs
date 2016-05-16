namespace BikersWorld
{
    partial class frmReportEmployees
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblShartSales = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chartJobs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSales
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSales.Legends.Add(legend3);
            this.chartSales.Location = new System.Drawing.Point(12, 46);
            this.chartSales.Name = "chartSales";
            this.chartSales.Size = new System.Drawing.Size(391, 307);
            this.chartSales.TabIndex = 0;
            this.chartSales.Text = "Employee Sales";
            this.chartSales.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblShartSales
            // 
            this.lblShartSales.AutoSize = true;
            this.lblShartSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShartSales.Location = new System.Drawing.Point(115, 9);
            this.lblShartSales.Name = "lblShartSales";
            this.lblShartSales.Size = new System.Drawing.Size(161, 24);
            this.lblShartSales.TabIndex = 1;
            this.lblShartSales.Text = "Employee Sales";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "List of Emplyes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "List of Mechanics";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "List of Sales Personal";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chartJobs
            // 
            chartArea4.Name = "ChartArea1";
            this.chartJobs.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartJobs.Legends.Add(legend4);
            this.chartJobs.Location = new System.Drawing.Point(569, 46);
            this.chartJobs.Name = "chartJobs";
            this.chartJobs.Size = new System.Drawing.Size(391, 307);
            this.chartJobs.TabIndex = 5;
            this.chartJobs.Text = "Employee Sales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(680, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mechanic Jobs";
            // 
            // frmReportEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartJobs);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblShartSales);
            this.Controls.Add(this.chartSales);
            this.Name = "frmReportEmployees";
            this.Text = "frmReportEmployeescs";
            this.Load += new System.EventHandler(this.frmReportEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblShartSales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartJobs;
        private System.Windows.Forms.Label label1;
    }
}