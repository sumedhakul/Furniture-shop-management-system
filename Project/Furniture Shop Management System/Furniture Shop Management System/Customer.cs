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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            frmItems Items = new frmItems();
            Items.Show();
            this.Hide();
            this.Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            frmBilling Billing= new frmBilling();
            Billing.Show();
            this.Hide();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMDIHomePage MDIHomePage = new frmMDIHomePage();
            MDIHomePage.Show();
            this.Hide();
            this.Close();
        }
    }
}
