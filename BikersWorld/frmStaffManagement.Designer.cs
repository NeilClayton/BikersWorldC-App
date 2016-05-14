namespace BikersWorld
{
    partial class frmStaffManagement
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.labelStaffId = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStaffFirstName = new System.Windows.Forms.TextBox();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.dgvStaffList = new System.Windows.Forms.DataGridView();
            this.txtFirstNameEdit = new System.Windows.Forms.TextBox();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboJobRoleEdit = new System.Windows.Forms.ComboBox();
            this.lblJovRoleEdit = new System.Windows.Forms.Label();
            this.lblEmailEdit = new System.Windows.Forms.Label();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.lblTelephoneTwoEdit = new System.Windows.Forms.Label();
            this.txtTelephoneTwoEdit = new System.Windows.Forms.TextBox();
            this.lblTelephoneOneEdit = new System.Windows.Forms.Label();
            this.txtTelephoneOneEdit = new System.Windows.Forms.TextBox();
            this.lblPostalCodeEdit = new System.Windows.Forms.Label();
            this.txtPostalCodeEdit = new System.Windows.Forms.TextBox();
            this.lblAddressThreeEdit = new System.Windows.Forms.Label();
            this.txtAddressLineThreeEdit = new System.Windows.Forms.TextBox();
            this.lblAddressLineTwoEdit = new System.Windows.Forms.Label();
            this.txtAddressLineTwoEdit = new System.Windows.Forms.TextBox();
            this.lblAddressLineOneEdit = new System.Windows.Forms.Label();
            this.txtAddressLineOneEdit = new System.Windows.Forms.TextBox();
            this.cboTitleEdit = new System.Windows.Forms.ComboBox();
            this.lblTitleEdit = new System.Windows.Forms.Label();
            this.lblLastNameEdit = new System.Windows.Forms.Label();
            this.txtLastNameEdit = new System.Windows.Forms.TextBox();
            this.lblFirstNameEdit = new System.Windows.Forms.Label();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.brnNew = new System.Windows.Forms.Button();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).BeginInit();
            this.grbEdit.SuspendLayout();
            this.grbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnReset);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.labelLastName);
            this.grbSearch.Controls.Add(this.lblFirstName);
            this.grbSearch.Controls.Add(this.labelStaffId);
            this.grbSearch.Controls.Add(this.txtLastName);
            this.grbSearch.Controls.Add(this.txtStaffFirstName);
            this.grbSearch.Controls.Add(this.txtStaffId);
            this.grbSearch.Location = new System.Drawing.Point(12, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(317, 109);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 30);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(105, 57);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(102, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // labelStaffId
            // 
            this.labelStaffId.AutoSize = true;
            this.labelStaffId.Location = new System.Drawing.Point(15, 14);
            this.labelStaffId.Name = "labelStaffId";
            this.labelStaffId.Size = new System.Drawing.Size(43, 13);
            this.labelStaffId.TabIndex = 3;
            this.labelStaffId.Text = "Staff ID";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(102, 74);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtStaffFirstName
            // 
            this.txtStaffFirstName.Location = new System.Drawing.Point(102, 30);
            this.txtStaffFirstName.Name = "txtStaffFirstName";
            this.txtStaffFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtStaffFirstName.TabIndex = 1;
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(18, 30);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(69, 20);
            this.txtStaffId.TabIndex = 0;
            // 
            // dgvStaffList
            // 
            this.dgvStaffList.AllowUserToAddRows = false;
            this.dgvStaffList.AllowUserToDeleteRows = false;
            this.dgvStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffList.GridColor = System.Drawing.Color.DarkGray;
            this.dgvStaffList.Location = new System.Drawing.Point(12, 152);
            this.dgvStaffList.Name = "dgvStaffList";
            this.dgvStaffList.ReadOnly = true;
            this.dgvStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffList.Size = new System.Drawing.Size(573, 188);
<<<<<<< HEAD
            this.dgvStaffList.TabIndex = 2;
            this.dgvStaffList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffList_CellClick);

=======
            this.dgvStaffList.TabIndex = 1;
            this.dgvStaffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffList_CellContentClick);
            this.dgvStaffList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaffList_RowHeaderMouseClick);
>>>>>>> refs/remotes/origin/master
            // 
            // txtFirstNameEdit
            // 
            this.txtFirstNameEdit.Location = new System.Drawing.Point(114, 47);
            this.txtFirstNameEdit.Name = "txtFirstNameEdit";
            this.txtFirstNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNameEdit.TabIndex = 2;
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.btnCancel);
            this.grbEdit.Controls.Add(this.btnLogin);
            this.grbEdit.Controls.Add(this.btnSubmit);
            this.grbEdit.Controls.Add(this.cboJobRoleEdit);
            this.grbEdit.Controls.Add(this.lblJovRoleEdit);
            this.grbEdit.Controls.Add(this.lblEmailEdit);
            this.grbEdit.Controls.Add(this.txtEmailEdit);
            this.grbEdit.Controls.Add(this.lblTelephoneTwoEdit);
            this.grbEdit.Controls.Add(this.txtTelephoneTwoEdit);
            this.grbEdit.Controls.Add(this.lblTelephoneOneEdit);
            this.grbEdit.Controls.Add(this.txtTelephoneOneEdit);
            this.grbEdit.Controls.Add(this.lblPostalCodeEdit);
            this.grbEdit.Controls.Add(this.txtPostalCodeEdit);
            this.grbEdit.Controls.Add(this.lblAddressThreeEdit);
            this.grbEdit.Controls.Add(this.txtAddressLineThreeEdit);
            this.grbEdit.Controls.Add(this.lblAddressLineTwoEdit);
            this.grbEdit.Controls.Add(this.txtAddressLineTwoEdit);
            this.grbEdit.Controls.Add(this.lblAddressLineOneEdit);
            this.grbEdit.Controls.Add(this.txtAddressLineOneEdit);
            this.grbEdit.Controls.Add(this.cboTitleEdit);
            this.grbEdit.Controls.Add(this.lblTitleEdit);
            this.grbEdit.Controls.Add(this.lblLastNameEdit);
            this.grbEdit.Controls.Add(this.txtLastNameEdit);
            this.grbEdit.Controls.Add(this.lblFirstNameEdit);
            this.grbEdit.Controls.Add(this.txtFirstNameEdit);
            this.grbEdit.Location = new System.Drawing.Point(13, 360);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Size = new System.Drawing.Size(572, 261);
            this.grbEdit.TabIndex = 4;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Staff N: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(469, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(469, 184);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 29;
            this.btnLogin.Text = "Logins";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(469, 185);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboJobRoleEdit
            // 
            this.cboJobRoleEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJobRoleEdit.FormattingEnabled = true;
            this.cboJobRoleEdit.Items.AddRange(new object[] {
            "manager ",
            "technician",
            "salesperson"});
            this.cboJobRoleEdit.Location = new System.Drawing.Point(371, 47);
            this.cboJobRoleEdit.Name = "cboJobRoleEdit";
            this.cboJobRoleEdit.Size = new System.Drawing.Size(136, 21);
            this.cboJobRoleEdit.TabIndex = 25;
            // 
            // lblJovRoleEdit
            // 
            this.lblJovRoleEdit.AutoSize = true;
            this.lblJovRoleEdit.Location = new System.Drawing.Point(371, 28);
            this.lblJovRoleEdit.Name = "lblJovRoleEdit";
            this.lblJovRoleEdit.Size = new System.Drawing.Size(49, 13);
            this.lblJovRoleEdit.TabIndex = 24;
            this.lblJovRoleEdit.Text = "Job Role";
            // 
            // lblEmailEdit
            // 
            this.lblEmailEdit.AutoSize = true;
            this.lblEmailEdit.Location = new System.Drawing.Point(264, 189);
            this.lblEmailEdit.Name = "lblEmailEdit";
            this.lblEmailEdit.Size = new System.Drawing.Size(32, 13);
            this.lblEmailEdit.TabIndex = 22;
            this.lblEmailEdit.Text = "Email";
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(267, 209);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(153, 20);
            this.txtEmailEdit.TabIndex = 21;
            // 
            // lblTelephoneTwoEdit
            // 
            this.lblTelephoneTwoEdit.AutoSize = true;
            this.lblTelephoneTwoEdit.Location = new System.Drawing.Point(129, 190);
            this.lblTelephoneTwoEdit.Name = "lblTelephoneTwoEdit";
            this.lblTelephoneTwoEdit.Size = new System.Drawing.Size(122, 13);
            this.lblTelephoneTwoEdit.TabIndex = 20;
            this.lblTelephoneTwoEdit.Text = "Telephone Contact Two";
            // 
            // txtTelephoneTwoEdit
            // 
            this.txtTelephoneTwoEdit.Location = new System.Drawing.Point(132, 210);
            this.txtTelephoneTwoEdit.Name = "txtTelephoneTwoEdit";
            this.txtTelephoneTwoEdit.Size = new System.Drawing.Size(100, 20);
            this.txtTelephoneTwoEdit.TabIndex = 19;
            // 
            // lblTelephoneOneEdit
            // 
            this.lblTelephoneOneEdit.AutoSize = true;
            this.lblTelephoneOneEdit.Location = new System.Drawing.Point(11, 190);
            this.lblTelephoneOneEdit.Name = "lblTelephoneOneEdit";
            this.lblTelephoneOneEdit.Size = new System.Drawing.Size(98, 13);
            this.lblTelephoneOneEdit.TabIndex = 18;
            this.lblTelephoneOneEdit.Text = "Telephone Contact";
            // 
            // txtTelephoneOneEdit
            // 
            this.txtTelephoneOneEdit.Location = new System.Drawing.Point(14, 209);
            this.txtTelephoneOneEdit.Name = "txtTelephoneOneEdit";
            this.txtTelephoneOneEdit.Size = new System.Drawing.Size(100, 20);
            this.txtTelephoneOneEdit.TabIndex = 17;
            // 
            // lblPostalCodeEdit
            // 
            this.lblPostalCodeEdit.AutoSize = true;
            this.lblPostalCodeEdit.Location = new System.Drawing.Point(404, 83);
            this.lblPostalCodeEdit.Name = "lblPostalCodeEdit";
            this.lblPostalCodeEdit.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCodeEdit.TabIndex = 16;
            this.lblPostalCodeEdit.Text = "Postal Code";
            // 
            // txtPostalCodeEdit
            // 
            this.txtPostalCodeEdit.Location = new System.Drawing.Point(407, 102);
            this.txtPostalCodeEdit.Name = "txtPostalCodeEdit";
            this.txtPostalCodeEdit.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCodeEdit.TabIndex = 15;
            // 
            // lblAddressThreeEdit
            // 
            this.lblAddressThreeEdit.AutoSize = true;
            this.lblAddressThreeEdit.Location = new System.Drawing.Point(264, 83);
            this.lblAddressThreeEdit.Name = "lblAddressThreeEdit";
            this.lblAddressThreeEdit.Size = new System.Drawing.Size(73, 13);
            this.lblAddressThreeEdit.TabIndex = 14;
            this.lblAddressThreeEdit.Text = "Address line 3";
            // 
            // txtAddressLineThreeEdit
            // 
            this.txtAddressLineThreeEdit.Location = new System.Drawing.Point(267, 102);
            this.txtAddressLineThreeEdit.Multiline = true;
            this.txtAddressLineThreeEdit.Name = "txtAddressLineThreeEdit";
            this.txtAddressLineThreeEdit.Size = new System.Drawing.Size(100, 60);
            this.txtAddressLineThreeEdit.TabIndex = 13;
            // 
            // lblAddressLineTwoEdit
            // 
            this.lblAddressLineTwoEdit.AutoSize = true;
            this.lblAddressLineTwoEdit.Location = new System.Drawing.Point(148, 83);
            this.lblAddressLineTwoEdit.Name = "lblAddressLineTwoEdit";
            this.lblAddressLineTwoEdit.Size = new System.Drawing.Size(73, 13);
            this.lblAddressLineTwoEdit.TabIndex = 12;
            this.lblAddressLineTwoEdit.Text = "Address line 2";
            // 
            // txtAddressLineTwoEdit
            // 
            this.txtAddressLineTwoEdit.Location = new System.Drawing.Point(151, 102);
            this.txtAddressLineTwoEdit.Multiline = true;
            this.txtAddressLineTwoEdit.Name = "txtAddressLineTwoEdit";
            this.txtAddressLineTwoEdit.Size = new System.Drawing.Size(100, 60);
            this.txtAddressLineTwoEdit.TabIndex = 11;
            // 
            // lblAddressLineOneEdit
            // 
            this.lblAddressLineOneEdit.AutoSize = true;
            this.lblAddressLineOneEdit.Location = new System.Drawing.Point(11, 83);
            this.lblAddressLineOneEdit.Name = "lblAddressLineOneEdit";
            this.lblAddressLineOneEdit.Size = new System.Drawing.Size(73, 13);
            this.lblAddressLineOneEdit.TabIndex = 10;
            this.lblAddressLineOneEdit.Text = "Address line 1";
            // 
            // txtAddressLineOneEdit
            // 
            this.txtAddressLineOneEdit.Location = new System.Drawing.Point(14, 102);
            this.txtAddressLineOneEdit.Multiline = true;
            this.txtAddressLineOneEdit.Name = "txtAddressLineOneEdit";
            this.txtAddressLineOneEdit.Size = new System.Drawing.Size(100, 60);
            this.txtAddressLineOneEdit.TabIndex = 9;
            // 
            // cboTitleEdit
            // 
            this.cboTitleEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTitleEdit.FormattingEnabled = true;
            this.cboTitleEdit.Items.AddRange(new object[] {
            "Mr",
            "Mrs",
            "Ms",
            "Miss",
            "Mx",
            "Madam",
            "Sir",
            "Dr",
            "Prof"});
            this.cboTitleEdit.Location = new System.Drawing.Point(14, 45);
            this.cboTitleEdit.Name = "cboTitleEdit";
            this.cboTitleEdit.Size = new System.Drawing.Size(82, 21);
            this.cboTitleEdit.TabIndex = 8;
            // 
            // lblTitleEdit
            // 
            this.lblTitleEdit.AutoSize = true;
            this.lblTitleEdit.Location = new System.Drawing.Point(11, 28);
            this.lblTitleEdit.Name = "lblTitleEdit";
            this.lblTitleEdit.Size = new System.Drawing.Size(27, 13);
            this.lblTitleEdit.TabIndex = 7;
            this.lblTitleEdit.Text = "Title";
            this.lblTitleEdit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLastNameEdit
            // 
            this.lblLastNameEdit.AutoSize = true;
            this.lblLastNameEdit.Location = new System.Drawing.Point(230, 28);
            this.lblLastNameEdit.Name = "lblLastNameEdit";
            this.lblLastNameEdit.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameEdit.TabIndex = 5;
            this.lblLastNameEdit.Text = "Last Name";
            // 
            // txtLastNameEdit
            // 
            this.txtLastNameEdit.Location = new System.Drawing.Point(230, 47);
            this.txtLastNameEdit.Name = "txtLastNameEdit";
            this.txtLastNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameEdit.TabIndex = 4;
            // 
            // lblFirstNameEdit
            // 
            this.lblFirstNameEdit.AutoSize = true;
            this.lblFirstNameEdit.Location = new System.Drawing.Point(114, 28);
            this.lblFirstNameEdit.Name = "lblFirstNameEdit";
            this.lblFirstNameEdit.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameEdit.TabIndex = 3;
            this.lblFirstNameEdit.Text = "First Name";
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.btnDelete);
            this.grbOptions.Controls.Add(this.btnEdit);
            this.grbOptions.Location = new System.Drawing.Point(374, 83);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(211, 60);
            this.grbOptions.TabIndex = 5;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Options";
            this.grbOptions.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(23, 19);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // brnNew
            // 
            this.brnNew.Location = new System.Drawing.Point(445, 54);
            this.brnNew.Name = "brnNew";
            this.brnNew.Size = new System.Drawing.Size(75, 23);
            this.brnNew.TabIndex = 28;
            this.brnNew.Text = "New";
            this.brnNew.UseVisualStyleBackColor = true;
            this.brnNew.Click += new System.EventHandler(this.brnNew_Click);
            // 
            // frmStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 648);
            this.Controls.Add(this.brnNew);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.dgvStaffList);
            this.Controls.Add(this.grbSearch);
            this.Name = "frmStaffManagement";
            this.Text = "Staff Maagement";
            this.Load += new System.EventHandler(this.frmStaffManagement_Load);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffList)).EndInit();
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            this.grbOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label labelStaffId;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStaffFirstName;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.DataGridView dgvStaffList;
        private System.Windows.Forms.TextBox txtFirstNameEdit;
        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.Label lblLastNameEdit;
        private System.Windows.Forms.TextBox txtLastNameEdit;
        private System.Windows.Forms.Label lblFirstNameEdit;
        private System.Windows.Forms.Label lblTitleEdit;
        private System.Windows.Forms.ComboBox cboTitleEdit;
        private System.Windows.Forms.ComboBox cboJobRoleEdit;
        private System.Windows.Forms.Label lblJovRoleEdit;
        private System.Windows.Forms.Label lblEmailEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.Label lblTelephoneTwoEdit;
        private System.Windows.Forms.TextBox txtTelephoneTwoEdit;
        private System.Windows.Forms.Label lblTelephoneOneEdit;
        private System.Windows.Forms.TextBox txtTelephoneOneEdit;
        private System.Windows.Forms.Label lblPostalCodeEdit;
        private System.Windows.Forms.TextBox txtPostalCodeEdit;
        private System.Windows.Forms.Label lblAddressThreeEdit;
        private System.Windows.Forms.TextBox txtAddressLineThreeEdit;
        private System.Windows.Forms.Label lblAddressLineTwoEdit;
        private System.Windows.Forms.TextBox txtAddressLineTwoEdit;
        private System.Windows.Forms.Label lblAddressLineOneEdit;
        private System.Windows.Forms.TextBox txtAddressLineOneEdit;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button brnNew;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}

