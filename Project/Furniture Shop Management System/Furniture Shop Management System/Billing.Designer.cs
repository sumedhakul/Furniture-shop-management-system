namespace Furniture_Shop_Management_System
{
    partial class frmBilling
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
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblAmount1 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbBilling = new System.Windows.Forms.GroupBox();
            this.dgvBilling = new System.Windows.Forms.DataGridView();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBilling = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Location = new System.Drawing.Point(0, 9);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(55, 13);
            this.lblItemCode.TabIndex = 0;
            this.lblItemCode.Text = "Item Code";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(332, 9);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(0, 93);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(332, 93);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(0, 179);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";
            // 
            // lblAmount1
            // 
            this.lblAmount1.AutoSize = true;
            this.lblAmount1.Location = new System.Drawing.Point(86, 179);
            this.lblAmount1.Name = "lblAmount1";
            this.lblAmount1.Size = new System.Drawing.Size(13, 13);
            this.lblAmount1.TabIndex = 5;
            this.lblAmount1.Text = "0";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(89, 12);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(100, 20);
            this.txtItemCode.TabIndex = 0;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(419, 9);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(89, 106);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(419, 93);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(89, 222);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "ADD ITEM";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(288, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(419, 222);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbBilling
            // 
            this.gbBilling.Location = new System.Drawing.Point(14, 267);
            this.gbBilling.Name = "gbBilling";
            this.gbBilling.Size = new System.Drawing.Size(601, 169);
            this.gbBilling.TabIndex = 9;
            this.gbBilling.TabStop = false;
            this.gbBilling.Text = "Billing";
            // 
            // dgvBilling
            // 
            this.dgvBilling.AllowUserToAddRows = false;
            this.dgvBilling.AllowUserToDeleteRows = false;
            this.dgvBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvBilling.Location = new System.Drawing.Point(41, 305);
            this.dgvBilling.Name = "dgvBilling";
            this.dgvBilling.ReadOnly = true;
            this.dgvBilling.Size = new System.Drawing.Size(601, 111);
            this.dgvBilling.TabIndex = 0;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(293, 478);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(416, 478);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal1_Click);
            // 
            // itemcode
            // 
            this.itemcode.HeaderText = "itemcode";
            this.itemcode.Name = "itemcode";
            // 
            // itemname
            // 
            this.itemname.HeaderText = "itemname";
            this.itemname.Name = "itemname";
            // 
            // code
            // 
            this.code.HeaderText = "ItemCode";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "ItemName";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "price";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "amount";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(189, 222);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(75, 23);
            this.btnBilling.TabIndex = 12;
            this.btnBilling.Text = "BILLING";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 531);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.dgvBilling);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.gbBilling);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.lblAmount1);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemCode);
            this.Name = "frmBilling";
            this.Text = "Billing ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblAmount1;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbBilling;
        private System.Windows.Forms.DataGridView dgvBilling;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Item_Code;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnBilling;
    }
}