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
    public partial class frmMDIHomePage : Form
    {
        public frmMDIHomePage()
        {
            InitializeComponent();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmBuying_Selling Customer = new frmBuying_Selling();
            Customer.Show();
            this.Hide();
            this.Close(); 
        
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee Employee = new frmEmployee();
            Employee.Show();
            this.Hide();
        }
    }
}
