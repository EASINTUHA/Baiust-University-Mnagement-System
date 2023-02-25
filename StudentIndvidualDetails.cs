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
    public partial class StudentIndvidualDetails : Form
    {
        public StudentIndvidualDetails()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StudentIndvidualDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewAdmission where student_id=" + textBox1.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    FIRST_Name.Text = ds.Tables[0].Rows[0][1].ToString();
                    Last_Name.Text = ds.Tables[0].Rows[0][2].ToString();
                    Father_Name.Text = ds.Tables[0].Rows[0][3].ToString();
                    Mother_Name.Text = ds.Tables[0].Rows[0][4].ToString();
                    Semester.Text = ds.Tables[0].Rows[0][5].ToString();
                    Department.Text = ds.Tables[0].Rows[0][6].ToString();
                    Gender.Text = ds.Tables[0].Rows[0][7].ToString();
                    Level_.Text = ds.Tables[0].Rows[0][8].ToString();
                    lTerm.Text = ds.Tables[0].Rows[0][9].ToString();
                    Date_Of_birth.Text = ds.Tables[0].Rows[0][10].ToString();
                    Email.Text = ds.Tables[0].Rows[0][11].ToString();
                    Mobile_no.Text = ds.Tables[0].Rows[0][12].ToString();
                    Address.Text = ds.Tables[0].Rows[0][13].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found", "Wrong INput", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FIRST_Name.Text = "_____________";
                    Last_Name.Text = "_____________";
                    Father_Name.Text = "_____________";
                    Mother_Name.Text = "_____________";
                    Semester.Text = "_____________";
                    Department.Text = "_____________";
                    Gender.Text = "_____________";
                    Level_.Text = "_____________";
                    lTerm.Text = "_____________";
                    Date_Of_birth.Text = "_____________";
                    Email.Text = "_____________";
                    Mobile_no.Text = "_____________";
                    Address.Text = "_____________";
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void butReset_Click(object sender, EventArgs e)
        {
            FIRST_Name.Text = "_____________";
            Last_Name.Text = "_____________";
            Father_Name.Text = "_____________";
            Mother_Name.Text = "_____________";
            Semester.Text = "_____________";
            Department.Text = "_____________";
            Gender.Text = "_____________";
            Level_.Text = "_____________";
            lTerm.Text = "_____________";
            Date_Of_birth.Text = "_____________";
            Email.Text = "_____________";
            Mobile_no.Text = "_____________";
            Address.Text = "_____________";
            textBox1.Text = "";
        }
    }
}
