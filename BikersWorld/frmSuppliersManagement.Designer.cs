namespace BikersWorld
{
    partial class frmSuppliersManagement
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
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEmailEdit = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.lblSupplierNameEdit = new System.Windows.Forms.Label();
            this.txtSupplierNameEdit = new System.Windows.Forms.TextBox();
            this.dgvSuppList = new System.Windows.Forms.DataGridView();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSuppId = new System.Windows.Forms.TextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.labelSuppId = new System.Windows.Forms.Label();
            this.brnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.grbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppList)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.pnlOptions);
            this.grbEdit.Controls.Add(this.btnCancel);
            this.grbEdit.Controls.Add(this.btnSubmit);
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
            this.grbEdit.Controls.Add(this.lblSupplierNameEdit);
            this.grbEdit.Controls.Add(this.txtSupplierNameEdit);
            this.grbEdit.Location = new System.Drawing.Point(28, 364);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Size = new System.Drawing.Size(572, 261);
            this.grbEdit.TabIndex = 36;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Supplier N: ";
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
            // lblEmailEdit
            // 
            this.lblEmailEdit.AutoSize = true;
            this.lblEmailEdit.Location = new System.Drawing.Point(264, 189);
            this.lblEmailEdit.Name = "lblEmailEdit";
            this.lblEmailEdit.Size = new System.Drawing.Size(32, 13);
            this.lblEmailEdit.TabIndex = 22;
            this.lblEmailEdit.Text = "Email";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Location = new System.Drawing.Point(4, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // lblSupplierNameEdit
            // 
            this.lblSupplierNameEdit.AutoSize = true;
            this.lblSupplierNameEdit.Location = new System.Drawing.Point(18, 27);
            this.lblSupplierNameEdit.Name = "lblSupplierNameEdit";
            this.lblSupplierNameEdit.Size = new System.Drawing.Size(76, 13);
            this.lblSupplierNameEdit.TabIndex = 3;
            this.lblSupplierNameEdit.Text = "Supplier Name";
            // 
            // txtSupplierNameEdit
            // 
            this.txtSupplierNameEdit.Location = new System.Drawing.Point(18, 46);
            this.txtSupplierNameEdit.Name = "txtSupplierNameEdit";
            this.txtSupplierNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierNameEdit.TabIndex = 2;
            // 
            // dgvSuppList
            // 
            this.dgvSuppList.AllowUserToAddRows = false;
            this.dgvSuppList.AllowUserToDeleteRows = false;
            this.dgvSuppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppList.GridColor = System.Drawing.Color.DarkGray;
            this.dgvSuppList.Location = new System.Drawing.Point(27, 156);
            this.dgvSuppList.Name = "dgvSuppList";
            this.dgvSuppList.ReadOnly = true;
            this.dgvSuppList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppList.Size = new System.Drawing.Size(573, 188);
            this.dgvSuppList.TabIndex = 1;
            this.dgvSuppList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppList_CellClick);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(102, 30);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(100, 20);
            this.txtSupplierName.TabIndex = 1;
            // 
            // txtSuppId
            // 
            this.txtSuppId.Location = new System.Drawing.Point(18, 30);
            this.txtSuppId.Name = "txtSuppId";
            this.txtSuppId.Size = new System.Drawing.Size(69, 20);
            this.txtSuppId.TabIndex = 0;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Location = new System.Drawing.Point(102, 13);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(76, 13);
            this.lblSupplierName.TabIndex = 4;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // labelSuppId
            // 
            this.labelSuppId.AutoSize = true;
            this.labelSuppId.Location = new System.Drawing.Point(15, 14);
            this.labelSuppId.Name = "labelSuppId";
            this.labelSuppId.Size = new System.Drawing.Size(59, 13);
            this.labelSuppId.TabIndex = 3;
            this.labelSuppId.Text = "Supplier ID";
            // 
            // brnNew
            // 
            this.brnNew.Location = new System.Drawing.Point(276, 102);
            this.brnNew.Name = "brnNew";
            this.brnNew.Size = new System.Drawing.Size(75, 23);
            this.brnNew.TabIndex = 38;
            this.brnNew.Text = "New";
            this.brnNew.UseVisualStyleBackColor = true;
            this.brnNew.Click += new System.EventHandler(this.brnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(22, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnReset);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.lblSupplierName);
            this.grbSearch.Controls.Add(this.labelSuppId);
            this.grbSearch.Controls.Add(this.txtSupplierName);
            this.grbSearch.Controls.Add(this.txtSuppId);
            this.grbSearch.Location = new System.Drawing.Point(27, 16);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(233, 109);
            this.grbSearch.TabIndex = 34;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(118, 71);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnEdit);
            this.pnlOptions.Location = new System.Drawing.Point(481, 19);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(85, 36);
            this.pnlOptions.TabIndex = 39;
            // 
            // frmSuppliersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 641);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.dgvSuppList);
            this.Controls.Add(this.brnNew);
            this.Controls.Add(this.grbSearch);
            this.Name = "frmSuppliersManagement";
            this.Text = "frmSuppliersManagement";
            this.Load += new System.EventHandler(this.frmSuppliersManagement_Load);
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppList)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
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
        private System.Windows.Forms.Label lblSupplierNameEdit;
        private System.Windows.Forms.TextBox txtSupplierNameEdit;
        private System.Windows.Forms.DataGridView dgvSuppList;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSuppId;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label labelSuppId;
        private System.Windows.Forms.Button brnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlOptions;
    }
}