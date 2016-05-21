namespace BikersWorld
{
    partial class frmCheckCustomers
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
            this.bntClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkCostomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dvgCostumers = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCostumers)).BeginInit();
            this.SuspendLayout();
            // 
            // bntClose
            // 
            this.bntClose.Location = new System.Drawing.Point(664, 322);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(125, 44);
            this.bntClose.TabIndex = 0;
            this.bntClose.Text = "Close";
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.bntCheck_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(325, 96);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(52, 13);
            this.lblPostcode.TabIndex = 2;
            this.lblPostcode.Text = "Postcode";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(399, 92);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(153, 20);
            this.txtPostcode.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(626, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(36, 20);
            this.txtId.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(602, 96);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fielToolStripMenuItem,
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fielToolStripMenuItem
            // 
            this.fielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fielToolStripMenuItem.Name = "fielToolStripMenuItem";
            this.fielToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fielToolStripMenuItem.Text = "file";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.addCustomersToolStripMenuItem,
            this.checkCostomersToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.formsToolStripMenuItem.Text = "forms&x";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.salesToolStripMenuItem.Text = "sales ";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // addCustomersToolStripMenuItem
            // 
            this.addCustomersToolStripMenuItem.Name = "addCustomersToolStripMenuItem";
            this.addCustomersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addCustomersToolStripMenuItem.Text = "add customers";
            this.addCustomersToolStripMenuItem.Click += new System.EventHandler(this.addCustomersToolStripMenuItem_Click);
            // 
            // checkCostomersToolStripMenuItem
            // 
            this.checkCostomersToolStripMenuItem.Name = "checkCostomersToolStripMenuItem";
            this.checkCostomersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.checkCostomersToolStripMenuItem.Text = "check costomers";
            this.checkCostomersToolStripMenuItem.Click += new System.EventHandler(this.checkCostomersToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ordersToolStripMenuItem.Text = "orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(94, 135);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(48, 13);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "telphone";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(164, 127);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(724, 91);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(58, 32);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dvgCostumers
            // 
            this.dvgCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCostumers.Location = new System.Drawing.Point(46, 153);
            this.dvgCostumers.Name = "dvgCostumers";
            this.dvgCostumers.Size = new System.Drawing.Size(736, 150);
            this.dvgCostumers.TabIndex = 11;
            // 
            // frmCheckCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 383);
            this.Controls.Add(this.dvgCostumers);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.bntClose);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCheckCustomers";
            this.Text = "check coustmers";
            this.Load += new System.EventHandler(this.frmCheckCustomers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCostumers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkCostomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dvgCostumers;
    }
}