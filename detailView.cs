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
    public partial class detailView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Acer\Documents\Visual Studio 2010\Projects\StudentChallan\StudentChallanDb.mdf;Integrated Security=True;User Instance=True");
        public detailView()
        {
            InitializeComponent();
        }

        private void detailView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentChallanDbDataSet5.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter2.Fill(this.studentChallanDbDataSet5.studentData);
            // TODO: This line of code loads data into the 'studentChallanDbDataSet4.studentData' table. You can move, or remove it, as needed.
            this.studentDataTableAdapter1.Fill(this.studentChallanDbDataSet4.studentData);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchQuery = "select adNo,sum(yearFrom) as Year from studentData GROUP BY ROLLUP(adNo,yearFrom)";
            SqlCommand cmd1 = new SqlCommand(searchQuery, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchQuery = "select adNo,sum(caste) as Year from studentData GROUP BY ROLLUP(adNo,caste)";
            SqlCommand cmd2 = new SqlCommand(searchQuery, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
