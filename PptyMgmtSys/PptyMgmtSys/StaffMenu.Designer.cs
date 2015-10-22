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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTenantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 24);
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
            this.manageTenantsToolStripMenuItem.Visible = false;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tenant Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Properties";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(112, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "My Profle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 279);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}