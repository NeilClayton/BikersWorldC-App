namespace BikersWorld
{
    partial class frmStockControl
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
            this.dgvProductInformation = new System.Windows.Forms.DataGridView();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.grpItemDetails = new System.Windows.Forms.GroupBox();
            this.txtAddStockQty = new System.Windows.Forms.TextBox();
            this.tkbAddStockQuantity = new System.Windows.Forms.TrackBar();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblStockLevel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInformation)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.grpItemDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAddStockQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductInformation
            // 
            this.dgvProductInformation.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvProductInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductInformation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvProductInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductInformation.Location = new System.Drawing.Point(12, 118);
            this.dgvProductInformation.Name = "dgvProductInformation";
            this.dgvProductInformation.ReadOnly = true;
            this.dgvProductInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductInformation.Size = new System.Drawing.Size(781, 306);
            this.dgvProductInformation.TabIndex = 0;
            this.dgvProductInformation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductInformation_CellClick);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnClearFilters);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.lblManufacturer);
            this.grbSearch.Controls.Add(this.lblProductName);
            this.grbSearch.Controls.Add(this.txtManufacturer);
            this.grbSearch.Controls.Add(this.txtProductName);
            this.grbSearch.Location = new System.Drawing.Point(12, 12);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(547, 100);
            this.grbSearch.TabIndex = 1;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search";
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(443, 71);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilters.TabIndex = 5;
            this.btnClearFilters.Text = "&Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(443, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(219, 28);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 3;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(25, 28);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(222, 44);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(193, 20);
            this.txtManufacturer.TabIndex = 1;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(25, 44);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(172, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // grpItemDetails
            // 
            this.grpItemDetails.Controls.Add(this.txtAddStockQty);
            this.grpItemDetails.Controls.Add(this.tkbAddStockQuantity);
            this.grpItemDetails.Controls.Add(this.txtSupplier);
            this.grpItemDetails.Controls.Add(this.txtStockLevel);
            this.grpItemDetails.Controls.Add(this.txtPrice);
            this.grpItemDetails.Controls.Add(this.txtItemDescription);
            this.grpItemDetails.Controls.Add(this.txtItemName);
            this.grpItemDetails.Controls.Add(this.lblSupplier);
            this.grpItemDetails.Controls.Add(this.lblStockLevel);
            this.grpItemDetails.Controls.Add(this.lblPrice);
            this.grpItemDetails.Controls.Add(this.lblDescription);
            this.grpItemDetails.Controls.Add(this.lblItemName);
            this.grpItemDetails.Location = new System.Drawing.Point(12, 430);
            this.grpItemDetails.Name = "grpItemDetails";
            this.grpItemDetails.Size = new System.Drawing.Size(781, 235);
            this.grpItemDetails.TabIndex = 2;
            this.grpItemDetails.TabStop = false;
            this.grpItemDetails.Text = "Product Details";
            // 
            // txtAddStockQty
            // 
            this.txtAddStockQty.Location = new System.Drawing.Point(507, 184);
            this.txtAddStockQty.Name = "txtAddStockQty";
            this.txtAddStockQty.Size = new System.Drawing.Size(100, 20);
            this.txtAddStockQty.TabIndex = 11;
            this.txtAddStockQty.TextChanged += new System.EventHandler(this.txtAddStockQty_TextChanged);
            // 
            // tkbAddStockQuantity
            // 
            this.tkbAddStockQuantity.Location = new System.Drawing.Point(118, 174);
            this.tkbAddStockQuantity.Maximum = 100;
            this.tkbAddStockQuantity.Name = "tkbAddStockQuantity";
            this.tkbAddStockQuantity.Size = new System.Drawing.Size(366, 45);
            this.tkbAddStockQuantity.TabIndex = 10;
            this.tkbAddStockQuantity.Scroll += new System.EventHandler(this.tkbAddStockQuantity_Scroll);
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(489, 115);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(179, 20);
            this.txtSupplier.TabIndex = 9;
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.Location = new System.Drawing.Point(489, 75);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.Size = new System.Drawing.Size(100, 20);
            this.txtStockLevel.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(489, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 7;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(118, 75);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(242, 79);
            this.txtItemDescription.TabIndex = 6;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(118, 38);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(242, 20);
            this.txtItemName.TabIndex = 5;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(409, 118);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblStockLevel
            // 
            this.lblStockLevel.AutoSize = true;
            this.lblStockLevel.Location = new System.Drawing.Point(409, 78);
            this.lblStockLevel.Name = "lblStockLevel";
            this.lblStockLevel.Size = new System.Drawing.Size(67, 13);
            this.lblStockLevel.TabIndex = 3;
            this.lblStockLevel.Text = "Stock Level:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(409, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(11, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Item Description:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(11, 41);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(61, 13);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";
            // 
            // frmStockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 677);
            this.Controls.Add(this.grpItemDetails);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.dgvProductInformation);
            this.Name = "frmStockControl";
            this.Text = "Bikers World - Stock Control";
            this.Load += new System.EventHandler(this.frmStockControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductInformation)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grpItemDetails.ResumeLayout(false);
            this.grpItemDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbAddStockQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductInformation;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox grpItemDetails;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblStockLevel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtAddStockQty;
        private System.Windows.Forms.TrackBar tkbAddStockQuantity;
    }
}