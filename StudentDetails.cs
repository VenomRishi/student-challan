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
    public partial class StudentDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Acer\Documents\Visual Studio 2010\Projects\StudentChallan\StudentChallanDb.mdf;Integrated Security=True;User Instance=True");
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caste = comboCaste.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand("insert into studentData ([adNo],[name],[yearFrom],[yearTo],[mobile],[caste]) values('"+txtAdNo.Text+"','"+txtFname.Text+"','"+txtYearFrom.Text+"','"+txtYearTo.Text+"','"+txtMobile.Text+"','"+caste+"')",con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            if (i > 0)
            { MessageBox.Show("Data inserted"); }
            else
                MessageBox.Show("error");
            con.Close();

            //
            string searchQuery = "select * from studentData";
            SqlCommand cmd1 = new SqlCommand(searchQuery,con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            
            
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentChallanDbDataSet3.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter1.Fill(this.studentChallanDbDataSet3.studentData);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdNo.Text = "";
            txtFname.Text = "";
            txtMobile.Text = "";
            txtYearFrom.Text = "";
            comboCaste.SelectedItem = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            detailView dv = new detailView();
            this.Hide();
            dv.Show();

        }
    }
}
