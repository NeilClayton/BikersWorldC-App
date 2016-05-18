namespace BikersWorld
{
    partial class frmManagement
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
            this.btnStaffManagement = new System.Windows.Forms.Button();
            this.btnProductsManagement = new System.Windows.Forms.Button();
            this.gbManagement = new System.Windows.Forms.GroupBox();
            this.btnSupplierManagement = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEmployeeReports = new System.Windows.Forms.Button();
            this.btnJobReports = new System.Windows.Forms.Button();
            this.btnSalesReports = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnProcessJob = new System.Windows.Forms.Button();
            this.btnProcessSale = new System.Windows.Forms.Button();
            this.btnStockControl = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businsTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proceessJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbManagement.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStaffManagement
            // 
            this.btnStaffManagement.Location = new System.Drawing.Point(23, 41);
            this.btnStaffManagement.Name = "btnStaffManagement";
            this.btnStaffManagement.Size = new System.Drawing.Size(75, 23);
            this.btnStaffManagement.TabIndex = 0;
            this.btnStaffManagement.Text = "&Staff";
            this.btnStaffManagement.UseVisualStyleBackColor = true;
            this.btnStaffManagement.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // btnProductsManagement
            // 
            this.btnProductsManagement.Location = new System.Drawing.Point(23, 70);
            this.btnProductsManagement.Name = "btnProductsManagement";
            this.btnProductsManagement.Size = new System.Drawing.Size(75, 23);
            this.btnProductsManagement.TabIndex = 1;
            this.btnProductsManagement.Text = "&Products";
            this.btnProductsManagement.UseVisualStyleBackColor = true;
            this.btnProductsManagement.Click += new System.EventHandler(this.btnProductsManagement_Click);
            // 
            // gbManagement
            // 
            this.gbManagement.Controls.Add(this.btnSupplierManagement);
            this.gbManagement.Controls.Add(this.btnStaffManagement);
            this.gbManagement.Controls.Add(this.btnProductsManagement);
            this.gbManagement.Location = new System.Drawing.Point(18, 40);
            this.gbManagement.Name = "gbManagement";
            this.gbManagement.Size = new System.Drawing.Size(135, 158);
            this.gbManagement.TabIndex = 2;
            this.gbManagement.TabStop = false;
            this.gbManagement.Text = "Management";
            // 
            // btnSupplierManagement
            // 
            this.btnSupplierManagement.Location = new System.Drawing.Point(23, 99);
            this.btnSupplierManagement.Name = "btnSupplierManagement";
            this.btnSupplierManagement.Size = new System.Drawing.Size(75, 23);
            this.btnSupplierManagement.TabIndex = 1;
            this.btnSupplierManagement.Text = "S&uppliers";
            this.btnSupplierManagement.UseVisualStyleBackColor = true;
            this.btnSupplierManagement.Click += new System.EventHandler(this.btnSupplierManagement_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEmployeeReports);
            this.groupBox2.Controls.Add(this.btnJobReports);
            this.groupBox2.Controls.Add(this.btnSalesReports);
            this.groupBox2.Location = new System.Drawing.Point(18, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reports";
            // 
            // btnEmployeeReports
            // 
            this.btnEmployeeReports.Location = new System.Drawing.Point(25, 99);
            this.btnEmployeeReports.Name = "btnEmployeeReports";
            this.btnEmployeeReports.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeReports.TabIndex = 2;
            this.btnEmployeeReports.Text = "&Employees";
            this.btnEmployeeReports.UseVisualStyleBackColor = true;
            this.btnEmployeeReports.Click += new System.EventHandler(this.btnEmployeeReports_Click);
            // 
            // btnJobReports
            // 
            this.btnJobReports.Location = new System.Drawing.Point(25, 70);
            this.btnJobReports.Name = "btnJobReports";
            this.btnJobReports.Size = new System.Drawing.Size(75, 23);
            this.btnJobReports.TabIndex = 1;
            this.btnJobReports.Text = "&Jobs";
            this.btnJobReports.UseVisualStyleBackColor = true;
            this.btnJobReports.Click += new System.EventHandler(this.btnJobReports_Click);
            // 
            // btnSalesReports
            // 
            this.btnSalesReports.Location = new System.Drawing.Point(25, 41);
            this.btnSalesReports.Name = "btnSalesReports";
            this.btnSalesReports.Size = new System.Drawing.Size(75, 23);
            this.btnSalesReports.TabIndex = 0;
            this.btnSalesReports.Text = "S&ales";
            this.btnSalesReports.UseVisualStyleBackColor = true;
            this.btnSalesReports.Click += new System.EventHandler(this.btnSalesReports_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnProcessJob);
            this.groupBox3.Controls.Add(this.btnProcessSale);
            this.groupBox3.Controls.Add(this.btnStockControl);
            this.groupBox3.Location = new System.Drawing.Point(190, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 158);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Business Tasks";
            // 
            // btnProcessJob
            // 
            this.btnProcessJob.Location = new System.Drawing.Point(13, 113);
            this.btnProcessJob.Name = "btnProcessJob";
            this.btnProcessJob.Size = new System.Drawing.Size(109, 23);
            this.btnProcessJob.TabIndex = 2;
            this.btnProcessJob.Text = "Process Jo&b";
            this.btnProcessJob.UseVisualStyleBackColor = true;
            this.btnProcessJob.Click += new System.EventHandler(this.btnProcessJob_Click);
            // 
            // btnProcessSale
            // 
            this.btnProcessSale.Location = new System.Drawing.Point(13, 69);
            this.btnProcessSale.Name = "btnProcessSale";
            this.btnProcessSale.Size = new System.Drawing.Size(109, 23);
            this.btnProcessSale.TabIndex = 1;
            this.btnProcessSale.Text = "P&rocess Sale";
            this.btnProcessSale.UseVisualStyleBackColor = true;
            this.btnProcessSale.Click += new System.EventHandler(this.btnProcessSale_Click);
            // 
            // btnStockControl
            // 
            this.btnStockControl.Location = new System.Drawing.Point(13, 28);
            this.btnStockControl.Name = "btnStockControl";
            this.btnStockControl.Size = new System.Drawing.Size(109, 23);
            this.btnStockControl.TabIndex = 0;
            this.btnStockControl.Text = "Stock &Control";
            this.btnStockControl.UseVisualStyleBackColor = true;
            this.btnStockControl.Click += new System.EventHandler(this.btnStockControl_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(272, 374);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(53, 23);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Log O&ut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.businsTasksToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.supliersToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "&Management";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.staffToolStripMenuItem.Text = "&Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.btnStaffManagement_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productsToolStripMenuItem.Text = "&Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.btnProductsManagement_Click);
            // 
            // supliersToolStripMenuItem
            // 
            this.supliersToolStripMenuItem.Name = "supliersToolStripMenuItem";
            this.supliersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supliersToolStripMenuItem.Text = "S&upliers";
            this.supliersToolStripMenuItem.Click += new System.EventHandler(this.btnSupplierManagement_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.jobsToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesToolStripMenuItem.Text = "S&ales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.btnSalesReports_Click);
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jobsToolStripMenuItem.Text = "&Jobs";
            this.jobsToolStripMenuItem.Click += new System.EventHandler(this.btnJobReports_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.employeesToolStripMenuItem.Text = "&Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.btnEmployeeReports_Click);
            // 
            // businsTasksToolStripMenuItem
            // 
            this.businsTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockControlToolStripMenuItem,
            this.processSaleToolStripMenuItem,
            this.proceessJobToolStripMenuItem});
            this.businsTasksToolStripMenuItem.Name = "businsTasksToolStripMenuItem";
            this.businsTasksToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.businsTasksToolStripMenuItem.Text = "Business Tasks";
            // 
            // stockControlToolStripMenuItem
            // 
            this.stockControlToolStripMenuItem.Name = "stockControlToolStripMenuItem";
            this.stockControlToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stockControlToolStripMenuItem.Text = "Stock &Control";
            this.stockControlToolStripMenuItem.Click += new System.EventHandler(this.btnStockControl_Click);
            // 
            // processSaleToolStripMenuItem
            // 
            this.processSaleToolStripMenuItem.Name = "processSaleToolStripMenuItem";
            this.processSaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processSaleToolStripMenuItem.Text = "P&rocess Sale";
            this.processSaleToolStripMenuItem.Click += new System.EventHandler(this.btnProcessSale_Click);
            // 
            // proceessJobToolStripMenuItem
            // 
            this.proceessJobToolStripMenuItem.Name = "proceessJobToolStripMenuItem";
            this.proceessJobToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.proceessJobToolStripMenuItem.Text = "Proceess jo&b";
            this.proceessJobToolStripMenuItem.Click += new System.EventHandler(this.btnProcessJob_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 424);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbManagement);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmManagement";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.gbManagement.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStaffManagement;
        private System.Windows.Forms.Button btnProductsManagement;
        private System.Windows.Forms.GroupBox gbManagement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSupplierManagement;
        private System.Windows.Forms.Button btnEmployeeReports;
        private System.Windows.Forms.Button btnJobReports;
        private System.Windows.Forms.Button btnSalesReports;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnProcessJob;
        private System.Windows.Forms.Button btnProcessSale;
        private System.Windows.Forms.Button btnStockControl;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businsTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proceessJobToolStripMenuItem;
    }
}

