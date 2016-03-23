namespace BikersWorld
{
    partial class frmLogNewJob
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
            this.lblLogNewJob = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDateLogged = new System.Windows.Forms.Label();
            this.lblDateStarted = new System.Windows.Forms.Label();
            this.lblEstimatedCompletionDate = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.lblJobOpenClosed = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDateStarted = new System.Windows.Forms.TextBox();
            this.txtEstimatedCompletionDate = new System.Windows.Forms.TextBox();
            this.txtDateCompleted = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.txtDateLogged = new System.Windows.Forms.TextBox();
            this.combJobOpenClose = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogNewJob
            // 
            this.lblLogNewJob.AutoSize = true;
            this.lblLogNewJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogNewJob.Location = new System.Drawing.Point(254, 31);
            this.lblLogNewJob.Name = "lblLogNewJob";
            this.lblLogNewJob.Size = new System.Drawing.Size(127, 25);
            this.lblLogNewJob.TabIndex = 1;
            this.lblLogNewJob.Text = "Log New Job";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "&Functions";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.submitToolStripMenuItem.Text = "S&ubmit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(22, 82);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(22, 135);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(67, 13);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "Employee ID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 194);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblDateLogged
            // 
            this.lblDateLogged.AutoSize = true;
            this.lblDateLogged.Location = new System.Drawing.Point(22, 255);
            this.lblDateLogged.Name = "lblDateLogged";
            this.lblDateLogged.Size = new System.Drawing.Size(69, 13);
            this.lblDateLogged.TabIndex = 6;
            this.lblDateLogged.Text = "Date Logged";
            // 
            // lblDateStarted
            // 
            this.lblDateStarted.AutoSize = true;
            this.lblDateStarted.Location = new System.Drawing.Point(331, 82);
            this.lblDateStarted.Name = "lblDateStarted";
            this.lblDateStarted.Size = new System.Drawing.Size(67, 13);
            this.lblDateStarted.TabIndex = 7;
            this.lblDateStarted.Text = "Date Started";
            // 
            // lblEstimatedCompletionDate
            // 
            this.lblEstimatedCompletionDate.AutoSize = true;
            this.lblEstimatedCompletionDate.Location = new System.Drawing.Point(331, 135);
            this.lblEstimatedCompletionDate.Name = "lblEstimatedCompletionDate";
            this.lblEstimatedCompletionDate.Size = new System.Drawing.Size(134, 13);
            this.lblEstimatedCompletionDate.TabIndex = 8;
            this.lblEstimatedCompletionDate.Text = "Estimated Completion Date";
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Location = new System.Drawing.Point(331, 194);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(83, 13);
            this.lblCompletionDate.TabIndex = 9;
            this.lblCompletionDate.Text = "Date Completed";
            // 
            // lblJobOpenClosed
            // 
            this.lblJobOpenClosed.AutoSize = true;
            this.lblJobOpenClosed.Location = new System.Drawing.Point(331, 255);
            this.lblJobOpenClosed.Name = "lblJobOpenClosed";
            this.lblJobOpenClosed.Size = new System.Drawing.Size(90, 13);
            this.lblJobOpenClosed.TabIndex = 10;
            this.lblJobOpenClosed.Text = "Job Open/Closed";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 175);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(175, 55);
            this.txtDescription.TabIndex = 30;
            // 
            // txtDateStarted
            // 
            this.txtDateStarted.Location = new System.Drawing.Point(466, 79);
            this.txtDateStarted.Name = "txtDateStarted";
            this.txtDateStarted.Size = new System.Drawing.Size(108, 20);
            this.txtDateStarted.TabIndex = 32;
            // 
            // txtEstimatedCompletionDate
            // 
            this.txtEstimatedCompletionDate.Location = new System.Drawing.Point(466, 132);
            this.txtEstimatedCompletionDate.Name = "txtEstimatedCompletionDate";
            this.txtEstimatedCompletionDate.Size = new System.Drawing.Size(108, 20);
            this.txtEstimatedCompletionDate.TabIndex = 33;
            // 
            // txtDateCompleted
            // 
            this.txtDateCompleted.Location = new System.Drawing.Point(466, 191);
            this.txtDateCompleted.Name = "txtDateCompleted";
            this.txtDateCompleted.Size = new System.Drawing.Size(108, 20);
            this.txtDateCompleted.TabIndex = 34;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(171, 306);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 31);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(337, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 31);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 25);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(107, 79);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(108, 20);
            this.txtCustomerID.TabIndex = 28;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(107, 132);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(108, 20);
            this.txtEmployeeID.TabIndex = 29;
            // 
            // txtDateLogged
            // 
            this.txtDateLogged.Location = new System.Drawing.Point(107, 252);
            this.txtDateLogged.Name = "txtDateLogged";
            this.txtDateLogged.Size = new System.Drawing.Size(108, 20);
            this.txtDateLogged.TabIndex = 31;
            // 
            // combJobOpenClose
            // 
            this.combJobOpenClose.AutoCompleteCustomSource.AddRange(new string[] {
            "Open",
            "Closed"});
            this.combJobOpenClose.FormattingEnabled = true;
            this.combJobOpenClose.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.combJobOpenClose.Location = new System.Drawing.Point(467, 255);
            this.combJobOpenClose.Name = "combJobOpenClose";
            this.combJobOpenClose.Size = new System.Drawing.Size(107, 21);
            this.combJobOpenClose.TabIndex = 35;
            // 
            // frmLogNewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 384);
            this.Controls.Add(this.combJobOpenClose);
            this.Controls.Add(this.txtDateLogged);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtDateCompleted);
            this.Controls.Add(this.txtEstimatedCompletionDate);
            this.Controls.Add(this.txtDateStarted);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblJobOpenClosed);
            this.Controls.Add(this.lblCompletionDate);
            this.Controls.Add(this.lblEstimatedCompletionDate);
            this.Controls.Add(this.lblDateStarted);
            this.Controls.Add(this.lblDateLogged);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblLogNewJob);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLogNewJob";
            this.Text = "Log New Job";
            this.Load += new System.EventHandler(this.frmLogNewJob_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogNewJob;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDateLogged;
        private System.Windows.Forms.Label lblDateStarted;
        private System.Windows.Forms.Label lblEstimatedCompletionDate;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.Label lblJobOpenClosed;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDateStarted;
        private System.Windows.Forms.TextBox txtEstimatedCompletionDate;
        private System.Windows.Forms.TextBox txtDateCompleted;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtDateLogged;
        private System.Windows.Forms.ComboBox combJobOpenClose;
    }
}