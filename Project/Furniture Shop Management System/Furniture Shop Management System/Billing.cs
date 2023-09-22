using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_Shop_Management_System
{
    public partial class frmBilling : Form
    {
        public frmBilling()
        {
            InitializeComponent();
        }


        Double price, quantity, amount, total = 0;


        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                price = Convert.ToDouble(txtPrice.Text);
                quantity = Convert.ToDouble(txtQuantity.Text);
                amount = price * quantity;
                lblAmount1.Text = amount.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            dgvBilling.Rows.Add(txtItemCode.Text, txtItemName.Text, price, quantity, amount);
            txtItemCode.Clear();
            txtItemName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void lblTotal1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBilling.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvBilling.Rows[i].Cells["Amount"].Value.ToString());
            }
            lblTotalAmount.Text = total.ToString();



        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBilling.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvBilling.Rows[i].Cells["Column3"].Value.ToString());
            }

            lblTotal.Text = total.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

