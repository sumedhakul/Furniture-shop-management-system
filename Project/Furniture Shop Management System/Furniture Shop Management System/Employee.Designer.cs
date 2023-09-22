namespace Furniture_Shop_Management_System
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.lblIDNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDaily = new System.Windows.Forms.Label();
            this.lblDailySalary = new System.Windows.Forms.Label();
            this.lblWorkedDays = new System.Windows.Forms.Label();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDailySalary = new System.Windows.Forms.TextBox();
            this.txtWorkedDays = new System.Windows.Forms.TextBox();
            this.txtNetSalary = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblIDNum
            // 
            this.lblIDNum.AutoSize = true;
            this.lblIDNum.Location = new System.Drawing.Point(16, 19);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(43, 13);
            this.lblIDNum.TabIndex = 0;
            this.lblIDNum.Text = "ID Num";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Location = new System.Drawing.Point(16, 93);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(69, 13);
            this.lblDaily.TabIndex = 2;
            this.lblDaily.Text = "Contact Num";
            // 
            // lblDailySalary
            // 
            this.lblDailySalary.AutoSize = true;
            this.lblDailySalary.Location = new System.Drawing.Point(16, 135);
            this.lblDailySalary.Name = "lblDailySalary";
            this.lblDailySalary.Size = new System.Drawing.Size(62, 13);
            this.lblDailySalary.TabIndex = 3;
            this.lblDailySalary.Text = "Daily Salary";
            // 
            // lblWorkedDays
            // 
            this.lblWorkedDays.AutoSize = true;
            this.lblWorkedDays.Location = new System.Drawing.Point(16, 178);
            this.lblWorkedDays.Name = "lblWorkedDays";
            this.lblWorkedDays.Size = new System.Drawing.Size(72, 13);
            this.lblWorkedDays.TabIndex = 4;
            this.lblWorkedDays.Text = "Worked Days";
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.AutoSize = true;
            this.lblNetSalary.Location = new System.Drawing.Point(16, 212);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(56, 13);
            this.lblNetSalary.TabIndex = 5;
            this.lblNetSalary.Text = "Net Salary";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // txtDailySalary
            // 
            this.txtDailySalary.Location = new System.Drawing.Point(128, 132);
            this.txtDailySalary.Name = "txtDailySalary";
            this.txtDailySalary.Size = new System.Drawing.Size(100, 20);
            this.txtDailySalary.TabIndex = 9;
            // 
            // txtWorkedDays
            // 
            this.txtWorkedDays.Location = new System.Drawing.Point(128, 171);
            this.txtWorkedDays.Name = "txtWorkedDays";
            this.txtWorkedDays.Size = new System.Drawing.Size(100, 20);
            this.txtWorkedDays.TabIndex = 10;
            this.txtWorkedDays.TextChanged += new System.EventHandler(this.txtWorkedDays_TextChanged);
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.Location = new System.Drawing.Point(128, 205);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.Size = new System.Drawing.Size(100, 20);
            this.txtNetSalary.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 279);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(167, 279);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            //this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(284, 279);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            //this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            //this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 487);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNetSalary);
            this.Controls.Add(this.txtWorkedDays);
            this.Controls.Add(this.txtDailySalary);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNetSalary);
            this.Controls.Add(this.lblWorkedDays);
            this.Controls.Add(this.lblDailySalary);
            this.Controls.Add(this.lblDaily);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblIDNum);
            this.Name = "frmEmployee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDaily;
        private System.Windows.Forms.Label lblDailySalary;
        private System.Windows.Forms.Label lblWorkedDays;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDailySalary;
        private System.Windows.Forms.TextBox txtWorkedDays;
        private System.Windows.Forms.TextBox txtNetSalary;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}