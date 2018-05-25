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
using System.Configuration;

namespace StudentChallan
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\acer\documents\visual studio 2010\Projects\StudentChallan\StudentChallanDb.mdf;Integrated Security=True;User Instance=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffRegister sr = new StaffRegister();
            sr.ShowDialog();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

            }
            catch { }
            SqlCommand cmd = new SqlCommand("select * from staffRegister where username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("@username",txtUsername.Text);
            cmd.Parameters.AddWithValue("@password",txtPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i = cmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                StudentDetails sd = new StudentDetails();
                sd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password is incorrect");
            }
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
