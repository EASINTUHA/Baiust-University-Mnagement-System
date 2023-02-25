using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAIUST
{
    public partial class UpgrateSemester : Form
    {
        public UpgrateSemester()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 student_id = Int64.Parse(textBox1studentid.Text);
                string Semester = comboBoxTo.Text;
                string Level_ = comboBoxlevel.Text;
                string Term = comboBoxterm.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE NewAdmission SET Semester = '" + Semester + "' WHERE student_id = " + student_id + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.CommandText = "UPDATE NewAdmission SET Level_ = '" + Level_ + "' WHERE student_id = " + student_id + "";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);

                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                cmd.CommandText = "UPDATE NewAdmission SET Term = '" + Term + "' WHERE student_id = " + student_id + "";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);

                DataSet ds2 = new DataSet();
                da.Fill(ds2);
                MessageBox.Show("Data Saved ." + "upgrated The Semester,Level and Term", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpgrateSemester_Load(object sender, EventArgs e)
        {

        }
    }
}
