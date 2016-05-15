namespace BikersWorld
{
    partial class frmManagementProducts
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
            this.lblProdName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblQtydit = new System.Windows.Forms.Label();
            this.txtStackEdit = new System.Windows.Forms.TextBox();
            this.lblPriceEdit = new System.Windows.Forms.Label();
            this.txtPriceEdit = new System.Windows.Forms.TextBox();
            this.lblSupplEdit = new System.Windows.Forms.Label();
            this.brnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.labelProdId = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblProdDescriptionEdit = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.dgvProdList = new System.Windows.Forms.DataGridView();
            this.txtDescriptionEdit = new System.Windows.Forms.TextBox();
            this.lblProdNameEdit = new System.Windows.Forms.Label();
            this.txtProdNameEdit = new System.Windows.Forms.TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.txtProndId = new System.Windows.Forms.TextBox();
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.grbEdit.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(102, 13);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(75, 13);
            this.lblProdName.TabIndex = 4;
            this.lblProdName.Text = "Product Name";
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
            // lblQtydit
            // 
            this.lblQtydit.AutoSize = true;
            this.lblQtydit.Location = new System.Drawing.Point(264, 189);
            this.lblQtydit.Name = "lblQtydit";
            this.lblQtydit.Size = new System.Drawing.Size(35, 13);
            this.lblQtydit.TabIndex = 22;
            this.lblQtydit.Text = "Stack";
            this.lblQtydit.Click += new System.EventHandler(this.lblEmailEdit_Click);
            // 
            // txtStackEdit
            // 
            this.txtStackEdit.Location = new System.Drawing.Point(267, 209);
            this.txtStackEdit.Name = "txtStackEdit";
            this.txtStackEdit.Size = new System.Drawing.Size(153, 20);
            this.txtStackEdit.TabIndex = 21;
            // 
            // lblPriceEdit
            // 
            this.lblPriceEdit.AutoSize = true;
            this.lblPriceEdit.Location = new System.Drawing.Point(145, 190);
            this.lblPriceEdit.Name = "lblPriceEdit";
            this.lblPriceEdit.Size = new System.Drawing.Size(31, 13);
            this.lblPriceEdit.TabIndex = 20;
            this.lblPriceEdit.Text = "Price";
            // 
            // txtPriceEdit
            // 
            this.txtPriceEdit.Location = new System.Drawing.Point(139, 211);
            this.txtPriceEdit.Name = "txtPriceEdit";
            this.txtPriceEdit.Size = new System.Drawing.Size(100, 20);
            this.txtPriceEdit.TabIndex = 19;
            // 
            // lblSupplEdit
            // 
            this.lblSupplEdit.AutoSize = true;
            this.lblSupplEdit.Location = new System.Drawing.Point(11, 190);
            this.lblSupplEdit.Name = "lblSupplEdit";
            this.lblSupplEdit.Size = new System.Drawing.Size(45, 13);
            this.lblSupplEdit.TabIndex = 18;
            this.lblSupplEdit.Text = "Supplier";
            // 
            // brnNew
            // 
            this.brnNew.Location = new System.Drawing.Point(250, 102);
            this.brnNew.Name = "brnNew";
            this.brnNew.Size = new System.Drawing.Size(75, 23);
            this.brnNew.TabIndex = 43;
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelProdId
            // 
            this.labelProdId.AutoSize = true;
            this.labelProdId.Location = new System.Drawing.Point(15, 14);
            this.labelProdId.Name = "labelProdId";
            this.labelProdId.Size = new System.Drawing.Size(59, 13);
            this.labelProdId.TabIndex = 3;
            this.labelProdId.Text = "Supplier ID";
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
            // lblProdDescriptionEdit
            // 
            this.lblProdDescriptionEdit.AutoSize = true;
            this.lblProdDescriptionEdit.Location = new System.Drawing.Point(11, 83);
            this.lblProdDescriptionEdit.Name = "lblProdDescriptionEdit";
            this.lblProdDescriptionEdit.Size = new System.Drawing.Size(100, 13);
            this.lblProdDescriptionEdit.TabIndex = 10;
            this.lblProdDescriptionEdit.Text = "Product Description";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(102, 30);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 20);
            this.txtProdName.TabIndex = 1;
            // 
            // dgvProdList
            // 
            this.dgvProdList.AllowUserToAddRows = false;
            this.dgvProdList.AllowUserToDeleteRows = false;
            this.dgvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdList.GridColor = System.Drawing.Color.DarkGray;
            this.dgvProdList.Location = new System.Drawing.Point(11, 156);
            this.dgvProdList.Name = "dgvProdList";
            this.dgvProdList.ReadOnly = true;
            this.dgvProdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdList.Size = new System.Drawing.Size(573, 188);
            this.dgvProdList.TabIndex = 39;
            this.dgvProdList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdList_CellClick);
            // 
            // txtDescriptionEdit
            // 
            this.txtDescriptionEdit.Location = new System.Drawing.Point(14, 102);
            this.txtDescriptionEdit.Multiline = true;
            this.txtDescriptionEdit.Name = "txtDescriptionEdit";
            this.txtDescriptionEdit.Size = new System.Drawing.Size(549, 60);
            this.txtDescriptionEdit.TabIndex = 9;
            // 
            // lblProdNameEdit
            // 
            this.lblProdNameEdit.AutoSize = true;
            this.lblProdNameEdit.Location = new System.Drawing.Point(18, 27);
            this.lblProdNameEdit.Name = "lblProdNameEdit";
            this.lblProdNameEdit.Size = new System.Drawing.Size(75, 13);
            this.lblProdNameEdit.TabIndex = 3;
            this.lblProdNameEdit.Text = "Product Name";
            // 
            // txtProdNameEdit
            // 
            this.txtProdNameEdit.Location = new System.Drawing.Point(18, 46);
            this.txtProdNameEdit.Name = "txtProdNameEdit";
            this.txtProdNameEdit.Size = new System.Drawing.Size(174, 20);
            this.txtProdNameEdit.TabIndex = 2;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnReset);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.lblProdName);
            this.grbSearch.Controls.Add(this.labelProdId);
            this.grbSearch.Controls.Add(this.txtProdName);
            this.grbSearch.Controls.Add(this.txtProndId);
            this.grbSearch.Location = new System.Drawing.Point(11, 16);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(233, 109);
            this.grbSearch.TabIndex = 40;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // txtProndId
            // 
            this.txtProndId.Location = new System.Drawing.Point(18, 30);
            this.txtProndId.Name = "txtProndId";
            this.txtProndId.Size = new System.Drawing.Size(69, 20);
            this.txtProndId.TabIndex = 0;
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.cmbSupplier);
            this.grbEdit.Controls.Add(this.pnlOptions);
            this.grbEdit.Controls.Add(this.btnCancel);
            this.grbEdit.Controls.Add(this.btnSubmit);
            this.grbEdit.Controls.Add(this.lblQtydit);
            this.grbEdit.Controls.Add(this.txtStackEdit);
            this.grbEdit.Controls.Add(this.lblPriceEdit);
            this.grbEdit.Controls.Add(this.txtPriceEdit);
            this.grbEdit.Controls.Add(this.lblSupplEdit);
            this.grbEdit.Controls.Add(this.lblProdDescriptionEdit);
            this.grbEdit.Controls.Add(this.txtDescriptionEdit);
            this.grbEdit.Controls.Add(this.lblProdNameEdit);
            this.grbEdit.Controls.Add(this.txtProdNameEdit);
            this.grbEdit.Location = new System.Drawing.Point(12, 364);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Size = new System.Drawing.Size(572, 261);
            this.grbEdit.TabIndex = 41;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Supplier N: ";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(4, 210);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplier.TabIndex = 45;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnEdit);
            this.pnlOptions.Location = new System.Drawing.Point(483, 19);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(80, 28);
            this.pnlOptions.TabIndex = 44;
            // 
            // frmManagementProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 657);
            this.Controls.Add(this.brnNew);
            this.Controls.Add(this.dgvProdList);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.grbEdit);
            this.Name = "frmManagementProducts";
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.frmManagementProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdList)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQtydit;
        private System.Windows.Forms.TextBox txtStackEdit;
        private System.Windows.Forms.Label lblPriceEdit;
        private System.Windows.Forms.TextBox txtPriceEdit;
        private System.Windows.Forms.Label lblSupplEdit;
        private System.Windows.Forms.Button brnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelProdId;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblProdDescriptionEdit;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.DataGridView dgvProdList;
        private System.Windows.Forms.TextBox txtDescriptionEdit;
        private System.Windows.Forms.Label lblProdNameEdit;
        private System.Windows.Forms.TextBox txtProdNameEdit;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.TextBox txtProndId;
        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.ComboBox cmbSupplier;
    }
}