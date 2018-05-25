using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace StudentChallan
{
    public partial class StaffRegister : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\acer\documents\visual studio 2010\Projects\StudentChallan\StudentChallanDb.mdf;Integrated Security=True;User Instance=True");
        public StaffRegister()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtStaffCode.Text == "bvimit")
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                }
                catch { }
                SqlCommand cmd = new SqlCommand("insert into staffRegister ([username],[password]) values('" + txtUsername.Text + "','" + txtPassword.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data Inserted Successfully");
                    Form1 sd = new Form1();
                    sd.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                con.Close();
            }
            else
                MessageBox.Show("Staff Code is incorrect");
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtStaffCode.Text = "";
        }
    }
}
