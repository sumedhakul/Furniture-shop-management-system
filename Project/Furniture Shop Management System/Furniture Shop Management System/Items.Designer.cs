namespace Furniture_Shop_Management_System
{
    partial class frmItems
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
            this.lblItemcode = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.iblPrice = new System.Windows.Forms.Label();
            this.txtItemcode = new System.Windows.Forms.TextBox();
            this.txtItemname = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblItemcode
            // 
            this.lblItemcode.AutoSize = true;
            this.lblItemcode.Location = new System.Drawing.Point(12, 42);
            this.lblItemcode.Name = "lblItemcode";
            this.lblItemcode.Size = new System.Drawing.Size(55, 13);
            this.lblItemcode.TabIndex = 0;
            this.lblItemcode.Text = "Item Code";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(12, 104);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // iblPrice
            // 
            this.iblPrice.AutoSize = true;
            this.iblPrice.Location = new System.Drawing.Point(12, 156);
            this.iblPrice.Name = "iblPrice";
            this.iblPrice.Size = new System.Drawing.Size(31, 13);
            this.iblPrice.TabIndex = 2;
            this.iblPrice.Text = "Price";
            // 
            // txtItemcode
            // 
            this.txtItemcode.Location = new System.Drawing.Point(131, 42);
            this.txtItemcode.Name = "txtItemcode";
            this.txtItemcode.Size = new System.Drawing.Size(226, 20);
            this.txtItemcode.TabIndex = 0;
            this.txtItemcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemcode_KeyPress);
            // 
            // txtItemname
            // 
            this.txtItemname.Location = new System.Drawing.Point(131, 101);
            this.txtItemname.Name = "txtItemname";
            this.txtItemname.Size = new System.Drawing.Size(226, 20);
            this.txtItemname.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(131, 149);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(226, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 226);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 226);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(339, 226);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(568, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(451, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 364);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemname);
            this.Controls.Add(this.txtItemcode);
            this.Controls.Add(this.iblPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemcode);
            this.Name = "frmItems";
            this.Text = "ITEMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemcode;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label iblPrice;
        private System.Windows.Forms.TextBox txtItemcode;
        private System.Windows.Forms.TextBox txtItemname;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
    }
}