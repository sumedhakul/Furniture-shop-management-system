namespace Furniture_Shop_Management_System
{
    partial class frmMDIHomePage
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
            this.MenuStri1 = new System.Windows.Forms.MenuStrip();
            this.vIEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aEmployeeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersDatailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuyingSelling = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.MenuStri1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStri1
            // 
            this.MenuStri1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vIEWToolStripMenuItem,
            this.hELPToolStripMenuItem});
            this.MenuStri1.Location = new System.Drawing.Point(0, 0);
            this.MenuStri1.Name = "MenuStri1";
            this.MenuStri1.Size = new System.Drawing.Size(738, 24);
            this.MenuStri1.TabIndex = 0;
            this.MenuStri1.Text = "Employee Details";
            // 
            // vIEWToolStripMenuItem
            // 
            this.vIEWToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemListToolStripMenuItem,
            this.aEmployeeDetailsToolStripMenuItem,
            this.suppliersDatailsToolStripMenuItem});
            this.vIEWToolStripMenuItem.Name = "vIEWToolStripMenuItem";
            this.vIEWToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.vIEWToolStripMenuItem.Text = "VIEW";
            // 
            // itemListToolStripMenuItem
            // 
            this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
            this.itemListToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.itemListToolStripMenuItem.Text = "Item List";
            // 
            // aEmployeeDetailsToolStripMenuItem
            // 
            this.aEmployeeDetailsToolStripMenuItem.Name = "aEmployeeDetailsToolStripMenuItem";
            this.aEmployeeDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aEmployeeDetailsToolStripMenuItem.Text = "Employee Details";
            // 
            // suppliersDatailsToolStripMenuItem
            // 
            this.suppliersDatailsToolStripMenuItem.Name = "suppliersDatailsToolStripMenuItem";
            this.suppliersDatailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.suppliersDatailsToolStripMenuItem.Text = "Suppliers Datails";
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.contactDetailsToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewHelpToolStripMenuItem.Text = "View help";
            // 
            // contactDetailsToolStripMenuItem
            // 
            this.contactDetailsToolStripMenuItem.Name = "contactDetailsToolStripMenuItem";
            this.contactDetailsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.contactDetailsToolStripMenuItem.Text = "Contact Details";
            // 
            // btnBuyingSelling
            // 
            this.btnBuyingSelling.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyingSelling.Location = new System.Drawing.Point(173, 99);
            this.btnBuyingSelling.Name = "btnBuyingSelling";
            this.btnBuyingSelling.Size = new System.Drawing.Size(150, 63);
            this.btnBuyingSelling.TabIndex = 1;
            this.btnBuyingSelling.Text = "Buying and Selling";
            this.btnBuyingSelling.UseVisualStyleBackColor = true;
            this.btnBuyingSelling.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(173, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(173, 184);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(137, 43);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // frmMDIHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Furniture_Shop_Management_System.Properties.Resources.f7585bf1acaa8705ded243e048be41a12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 432);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBuyingSelling);
            this.Controls.Add(this.MenuStri1);
            this.MainMenuStrip = this.MenuStri1;
            this.Name = "frmMDIHomePage";
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStri1.ResumeLayout(false);
            this.MenuStri1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStri1;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aEmployeeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppliersDatailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnBuyingSelling;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmployee;
    }
}