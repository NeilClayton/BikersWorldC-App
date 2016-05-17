namespace BikersWorld
{
    partial class frmEditOpenJob
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
            this.dgvEditOpenJob = new System.Windows.Forms.DataGridView();
            this.grpJobSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEditJob = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEditClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.txtCompletionDate = new System.Windows.Forms.MaskedTextBox();
            this.txtDateStarted = new System.Windows.Forms.MaskedTextBox();
            this.txtEstimatedCompletionDate = new System.Windows.Forms.MaskedTextBox();
            this.lblDateStarted = new System.Windows.Forms.Label();
            this.combJobOpenClosed = new System.Windows.Forms.ComboBox();
            this.lblAnd = new System.Windows.Forms.Label();
            this.lblJobOpenClosed = new System.Windows.Forms.Label();
            this.lblCompletionDate = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblEstimatedCompletionDate = new System.Windows.Forms.Label();
            this.txtDateLogged = new System.Windows.Forms.MaskedTextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDateLogged = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditOpenJob)).BeginInit();
            this.grpJobSearch.SuspendLayout();
            this.grpEditJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEditOpenJob
            // 
            this.dgvEditOpenJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditOpenJob.Location = new System.Drawing.Point(13, 113);
            this.dgvEditOpenJob.Name = "dgvEditOpenJob";
            this.dgvEditOpenJob.Size = new System.Drawing.Size(943, 174);
            this.dgvEditOpenJob.TabIndex = 15;
            this.dgvEditOpenJob.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditOpenJob_CellClick);
            this.dgvEditOpenJob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditOpenJob_CellClick);
            // 
            // grpJobSearch
            // 
            this.grpJobSearch.Controls.Add(this.btnClear);
            this.grpJobSearch.Controls.Add(this.btnSearch);
            this.grpJobSearch.Controls.Add(this.txtDescription);
            this.grpJobSearch.Controls.Add(this.txtCustomerID);
            this.grpJobSearch.Controls.Add(this.label2);
            this.grpJobSearch.Controls.Add(this.label1);
            this.grpJobSearch.Location = new System.Drawing.Point(13, 8);
            this.grpJobSearch.Name = "grpJobSearch";
            this.grpJobSearch.Size = new System.Drawing.Size(943, 99);
            this.grpJobSearch.TabIndex = 1;
            this.grpJobSearch.TabStop = false;
            this.grpJobSearch.Text = "Job Search";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(488, 63);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(363, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(422, 27);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(502, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(92, 27);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(195, 20);
            this.txtCustomerID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // grpEditJob
            // 
            this.grpEditJob.Controls.Add(this.btnSubmit);
            this.grpEditJob.Controls.Add(this.btnEditClear);
            this.grpEditJob.Controls.Add(this.btnExit);
            this.grpEditJob.Controls.Add(this.lblDisclaimer);
            this.grpEditJob.Controls.Add(this.txtCompletionDate);
            this.grpEditJob.Controls.Add(this.txtDateStarted);
            this.grpEditJob.Controls.Add(this.txtEstimatedCompletionDate);
            this.grpEditJob.Controls.Add(this.lblDateStarted);
            this.grpEditJob.Controls.Add(this.combJobOpenClosed);
            this.grpEditJob.Controls.Add(this.lblAnd);
            this.grpEditJob.Controls.Add(this.lblJobOpenClosed);
            this.grpEditJob.Controls.Add(this.lblCompletionDate);
            this.grpEditJob.Controls.Add(this.lblCustomerName);
            this.grpEditJob.Controls.Add(this.lblEstimatedCompletionDate);
            this.grpEditJob.Controls.Add(this.txtDateLogged);
            this.grpEditJob.Controls.Add(this.txtDesc);
            this.grpEditJob.Controls.Add(this.lblDateLogged);
            this.grpEditJob.Controls.Add(this.lblDescription);
            this.grpEditJob.Location = new System.Drawing.Point(13, 293);
            this.grpEditJob.Name = "grpEditJob";
            this.grpEditJob.Size = new System.Drawing.Size(943, 199);
            this.grpEditJob.TabIndex = 2;
            this.grpEditJob.TabStop = false;
            this.grpEditJob.Text = "Edit Job";
            this.grpEditJob.Enter += new System.EventHandler(this.grpEditJob_Enter);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(816, 47);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 27);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "S&ubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnEditClear
            // 
            this.btnEditClear.Location = new System.Drawing.Point(816, 95);
            this.btnEditClear.Name = "btnEditClear";
            this.btnEditClear.Size = new System.Drawing.Size(74, 27);
            this.btnEditClear.TabIndex = 13;
            this.btnEditClear.Text = "C&lear";
            this.btnEditClear.UseVisualStyleBackColor = true;
            this.btnEditClear.Click += new System.EventHandler(this.btnEditClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(816, 142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 25);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.AutoSize = true;
            this.lblDisclaimer.Location = new System.Drawing.Point(6, 183);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(175, 13);
            this.lblDisclaimer.TabIndex = 40;
            this.lblDisclaimer.Text = "*Dates must be logged in US format";
            // 
            // txtCompletionDate
            // 
            this.txtCompletionDate.Location = new System.Drawing.Point(606, 99);
            this.txtCompletionDate.Mask = "00/00/0000 90:00";
            this.txtCompletionDate.Name = "txtCompletionDate";
            this.txtCompletionDate.Size = new System.Drawing.Size(190, 20);
            this.txtCompletionDate.TabIndex = 10;
            this.txtCompletionDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtDateStarted
            // 
            this.txtDateStarted.Location = new System.Drawing.Point(102, 143);
            this.txtDateStarted.Mask = "00/00/0000 90:00";
            this.txtDateStarted.Name = "txtDateStarted";
            this.txtDateStarted.Size = new System.Drawing.Size(214, 20);
            this.txtDateStarted.TabIndex = 8;
            this.txtDateStarted.ValidatingType = typeof(System.DateTime);
            // 
            // txtEstimatedCompletionDate
            // 
            this.txtEstimatedCompletionDate.Location = new System.Drawing.Point(606, 52);
            this.txtEstimatedCompletionDate.Mask = "00/00/0000 90:00";
            this.txtEstimatedCompletionDate.Name = "txtEstimatedCompletionDate";
            this.txtEstimatedCompletionDate.Size = new System.Drawing.Size(190, 20);
            this.txtEstimatedCompletionDate.TabIndex = 9;
            this.txtEstimatedCompletionDate.ValidatingType = typeof(System.DateTime);
            this.txtEstimatedCompletionDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtEstimatedCompletionDate_MaskInputRejected);
            // 
            // lblDateStarted
            // 
            this.lblDateStarted.AutoSize = true;
            this.lblDateStarted.Location = new System.Drawing.Point(17, 146);
            this.lblDateStarted.Name = "lblDateStarted";
            this.lblDateStarted.Size = new System.Drawing.Size(71, 13);
            this.lblDateStarted.TabIndex = 48;
            this.lblDateStarted.Text = "Date Started*";
            // 
            // combJobOpenClosed
            // 
            this.combJobOpenClosed.AutoCompleteCustomSource.AddRange(new string[] {
            "Open",
            "Closed"});
            this.combJobOpenClosed.FormattingEnabled = true;
            this.combJobOpenClosed.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.combJobOpenClosed.Location = new System.Drawing.Point(606, 146);
            this.combJobOpenClosed.Name = "combJobOpenClosed";
            this.combJobOpenClosed.Size = new System.Drawing.Size(190, 21);
            this.combJobOpenClosed.TabIndex = 11;
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(41, 41);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(25, 13);
            this.lblAnd.TabIndex = 47;
            this.lblAnd.Text = "and";
            // 
            // lblJobOpenClosed
            // 
            this.lblJobOpenClosed.AutoSize = true;
            this.lblJobOpenClosed.Location = new System.Drawing.Point(476, 146);
            this.lblJobOpenClosed.Name = "lblJobOpenClosed";
            this.lblJobOpenClosed.Size = new System.Drawing.Size(90, 13);
            this.lblJobOpenClosed.TabIndex = 38;
            this.lblJobOpenClosed.Text = "Job Open/Closed";
            // 
            // lblCompletionDate
            // 
            this.lblCompletionDate.AutoSize = true;
            this.lblCompletionDate.Location = new System.Drawing.Point(476, 99);
            this.lblCompletionDate.Name = "lblCompletionDate";
            this.lblCompletionDate.Size = new System.Drawing.Size(89, 13);
            this.lblCompletionDate.TabIndex = 37;
            this.lblCompletionDate.Text = "Completion Date*";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 46;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblEstimatedCompletionDate
            // 
            this.lblEstimatedCompletionDate.AutoSize = true;
            this.lblEstimatedCompletionDate.Location = new System.Drawing.Point(477, 46);
            this.lblEstimatedCompletionDate.Name = "lblEstimatedCompletionDate";
            this.lblEstimatedCompletionDate.Size = new System.Drawing.Size(89, 26);
            this.lblEstimatedCompletionDate.TabIndex = 36;
            this.lblEstimatedCompletionDate.Text = "Estimated \r\nCompletion Date*";
            // 
            // txtDateLogged
            // 
            this.txtDateLogged.Location = new System.Drawing.Point(102, 99);
            this.txtDateLogged.Mask = "00/00/0000 90:00";
            this.txtDateLogged.Name = "txtDateLogged";
            this.txtDateLogged.Size = new System.Drawing.Size(214, 20);
            this.txtDateLogged.TabIndex = 7;
            this.txtDateLogged.ValidatingType = typeof(System.DateTime);
            this.txtDateLogged.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDateLogged_MaskInputRejected);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(102, 19);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(281, 55);
            this.txtDesc.TabIndex = 6;
            // 
            // lblDateLogged
            // 
            this.lblDateLogged.AutoSize = true;
            this.lblDateLogged.Location = new System.Drawing.Point(17, 99);
            this.lblDateLogged.Name = "lblDateLogged";
            this.lblDateLogged.Size = new System.Drawing.Size(73, 13);
            this.lblDateLogged.TabIndex = 43;
            this.lblDateLogged.Text = "Date Logged*";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 42;
            this.lblDescription.Text = "Description";
            // 
            // frmEditOpenJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 500);
            this.Controls.Add(this.grpEditJob);
            this.Controls.Add(this.grpJobSearch);
            this.Controls.Add(this.dgvEditOpenJob);
            this.Name = "frmEditOpenJob";
            this.Text = "Edit Open Job";
            this.Load += new System.EventHandler(this.frmEditOpenJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditOpenJob)).EndInit();
            this.grpJobSearch.ResumeLayout(false);
            this.grpJobSearch.PerformLayout();
            this.grpEditJob.ResumeLayout(false);
            this.grpEditJob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditOpenJob;
        private System.Windows.Forms.GroupBox grpJobSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpEditJob;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.MaskedTextBox txtDateLogged;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDateLogged;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.MaskedTextBox txtDateStarted;
        private System.Windows.Forms.Label lblDateStarted;
        private System.Windows.Forms.MaskedTextBox txtCompletionDate;
        private System.Windows.Forms.MaskedTextBox txtEstimatedCompletionDate;
        private System.Windows.Forms.ComboBox combJobOpenClosed;
        private System.Windows.Forms.Label lblJobOpenClosed;
        private System.Windows.Forms.Label lblCompletionDate;
        private System.Windows.Forms.Label lblEstimatedCompletionDate;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditClear;
        private System.Windows.Forms.Button btnSubmit;
    }
}