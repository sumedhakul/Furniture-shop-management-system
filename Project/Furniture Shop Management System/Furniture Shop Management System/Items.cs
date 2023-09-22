using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Furniture_Shop_Management_System
{
    public partial class frmItems : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\Project\Furniture Shop Management System\Furniture Shop Management System\Database1.mdf;Integrated Security=True");
        SqlCommand com;
        public frmItems()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlselect = "select * from furniture where ItemCode='"+txtItemcode.Text+"'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Item Code can't be duplicated - Please enter another", "Record existance check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemcode.Clear();
                    txtItemname.Clear();
                    txtPrice.Clear();
                    txtItemcode.Focus();
                }
                else
                {
                    try
                    {
                        con.Close();
                        con.Open();
                        string sqlinsert = "insert into furniture(ItemCode,ItemName,Price)values('" + txtItemcode.Text + "','" + txtItemname.Text + "','" + txtPrice.Text + "')";
                        com = new SqlCommand(sqlinsert, con);
                        com.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Succesfully Inserted a Record", "Insert Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItemcode.Text = "";
                        txtItemname.Text = "";
                        txtPrice.Text = "";
                        txtItemcode.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();
                string SqlUpdate = "update furniture set ItemName='"+txtItemname.Text+"',Price='"+txtPrice.Text+"' where ItemCode='"+txtItemcode.Text+"'";
                com = new SqlCommand(SqlUpdate, con);
                com.ExecuteNonQuery();
                MessageBox.Show("changes are saved in the table", "Update Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

           
            try
            {
            con.Open();
            string SqlSearch="Select * from furniture where ItemCode='"+txtItemcode.Text+"'";
            com=new SqlCommand(SqlSearch,con);
            SqlDataReader dr;
            dr=com.ExecuteReader();
            if(dr.Read())
            {
                txtItemname.Text=dr["ItemName"].ToString();
                txtPrice.Text=dr["Price"].ToString();
                txtItemname.Focus();
        }
            else
            {
                MessageBox.Show("Record not found","Search Record",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            con.Close();
            }
            catch(Exception ex)
            {
            MessageBox.Show(ex.Message);
        }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           txtItemcode.Clear();
            txtItemname.Clear();
            txtPrice.Clear();
            txtItemcode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqldelete = "Delete from furniture where ItemCode='" + txtItemcode.Text + "'";
            com=new SqlCommand(sqldelete,con);
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully delete the record","Delete record",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void txtItemcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                if (txtItemcode.Text.Length!=4)
                {
                    MessageBox.Show("Wrong length - Please enter 4 characters for Item Code", "Length Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemcode.Clear();
                    txtItemcode.Focus();
                }
                else // correct length
                {
                    txtItemname.Focus();
                }
            }
        }

        

        

        

    }

}


     


