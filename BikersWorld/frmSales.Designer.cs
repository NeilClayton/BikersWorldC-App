namespace BikersWorld
{
    partial class frmSales
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCheckCustomer = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCoustomoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkCutomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Add Costomer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnCheckCustomer
            // 
            this.btnCheckCustomer.Location = new System.Drawing.Point(243, 24);
            this.btnCheckCustomer.Name = "btnCheckCustomer";
            this.btnCheckCustomer.Size = new System.Drawing.Size(195, 36);
            this.btnCheckCustomer.TabIndex = 1;
            this.btnCheckCustomer.Text = "&check coustomer";
            this.btnCheckCustomer.UseVisualStyleBackColor = true;
            this.btnCheckCustomer.Click += new System.EventHandler(this.btn_check_coustomer_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(482, 24);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(126, 36);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "&Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&file";
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
            this.addCoustomoreToolStripMenuItem,
            this.checkCutomerToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.addOrdersToolStripMenuItem,
            this.salesHubToolStripMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.formsToolStripMenuItem.Text = "fo&rms";
            // 
            // addCoustomoreToolStripMenuItem
            // 
            this.addCoustomoreToolStripMenuItem.Name = "addCoustomoreToolStripMenuItem";
            this.addCoustomoreToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addCoustomoreToolStripMenuItem.Text = "add coustomore";
            this.addCoustomoreToolStripMenuItem.Click += new System.EventHandler(this.addCoustomoreToolStripMenuItem_Click);
            // 
            // checkCutomerToolStripMenuItem
            // 
            this.checkCutomerToolStripMenuItem.Name = "checkCutomerToolStripMenuItem";
            this.checkCutomerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.checkCutomerToolStripMenuItem.Text = "check cutomer";
            this.checkCutomerToolStripMenuItem.Click += new System.EventHandler(this.checkCutomerToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ordersToolStripMenuItem.Text = "orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // addOrdersToolStripMenuItem
            // 
            this.addOrdersToolStripMenuItem.Name = "addOrdersToolStripMenuItem";
            this.addOrdersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addOrdersToolStripMenuItem.Text = "add orders";
            // 
            // salesHubToolStripMenuItem
            // 
            this.salesHubToolStripMenuItem.Name = "salesHubToolStripMenuItem";
            this.salesHubToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.salesHubToolStripMenuItem.Text = "sales hub";
            this.salesHubToolStripMenuItem.Click += new System.EventHandler(this.salesHubToolStripMenuItem_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(659, 24);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(82, 35);
            this.btnAddOrder.TabIndex = 4;
            this.btnAddOrder.Text = "A&dd Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 382);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCheckCustomer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSales";
            this.Text = "sales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCheckCustomer;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCoustomoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkCutomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesHubToolStripMenuItem;
    }
}