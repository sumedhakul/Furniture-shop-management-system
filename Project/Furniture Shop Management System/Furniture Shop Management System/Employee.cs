using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Furniture_Shop_Management_System
{
    public partial class frmEmployee : Form
    {
        private double DailySalary;
        private double WorkedDays;
        private double NetSalary;
        private Image bitmap;
        public frmEmployee()
        {
            InitializeComponent();
        }

        

        private void txtWorkedDays_TextChanged(object sender, EventArgs e)
        {
            DailySalary = Convert.ToDouble(txtDailySalary.Text);
            WorkedDays = Convert.ToDouble(txtWorkedDays.Text);
            NetSalary = DailySalary * WorkedDays;
            txtNetSalary.Text = NetSalary.ToString();
        }

       
        

        
    }
}
