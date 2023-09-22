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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
           
       private void btnLogin_Click(object sender, EventArgs e)
        {
            string USERNAME = "difurnitures";
            string PASSWORD = "1234";
            if (txtUsername.Text == USERNAME && txtPassword.Text == PASSWORD)
            {
                MessageBox.Show("You Can Log Into The System ", "LOGIN PERMISSION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMDIHomePage homepage = new frmMDIHomePage();
                homepage.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password.You Can Not Log Into The System", "LOGIN PERMISSION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();//GET THE FOCUS BACK TO THE USER NAME TEXT BOX
        }
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
  }
}
