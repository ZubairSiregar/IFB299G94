namespace PptyMgmtSys
{
    partial class StaffMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageTenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllTenantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTenantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageTenantsToolStripMenuItem
            // 
            this.manageTenantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTenantToolStripMenuItem,
            this.viewAllTenantsToolStripMenuItem});
            this.manageTenantsToolStripMenuItem.Name = "manageTenantsToolStripMenuItem";
            this.manageTenantsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.manageTenantsToolStripMenuItem.Text = "Manage Tenants";
            // 
            // newTenantToolStripMenuItem
            // 
            this.newTenantToolStripMenuItem.Name = "newTenantToolStripMenuItem";
            this.newTenantToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newTenantToolStripMenuItem.Text = "New Tenant";
            this.newTenantToolStripMenuItem.Click += new System.EventHandler(this.newTenantToolStripMenuItem_Click);
            // 
            // viewAllTenantsToolStripMenuItem
            // 
            this.viewAllTenantsToolStripMenuItem.Name = "viewAllTenantsToolStripMenuItem";
            this.viewAllTenantsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewAllTenantsToolStripMenuItem.Text = "View All Tenants";
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 381);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.Load += new System.EventHandler(this.StaffMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageTenantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllTenantsToolStripMenuItem;
    }
}