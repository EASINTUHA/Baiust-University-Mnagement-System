using hostel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BAIUST
{
    public partial class Hostel_leave_student : Form
    {
        public Hostel_leave_student()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Int64 Student_id = Int64.Parse(richTextBox1.Text);
            String name = richTextBox2.Text;
            String Department= richTextBox3.Text;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into hostel_leve_student (Student_id,Student_name,department) values ("+ Student_id + ",'"+ name + "','"+ Department + "') ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            MessageBox.Show("Data Saved ", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            catch (Exception ex)
             {
                 MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void Hostel_leave_student_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from hostel_leve_student";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 sid = Int64.Parse(textBox2.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from hostel_leve_student where Student_id =" + sid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hostel_main_page hostel_Main_Page = new Hostel_main_page();
            hostel_Main_Page.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HostelStudentFees hostelStudentFees = new HostelStudentFees();
            hostelStudentFees.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hostel_new_employee hostel_New_Employee = new hostel_new_employee();
            hostel_New_Employee.Show();
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hostel_leave_student hostel_Leave_ = new Hostel_leave_student();
            hostel_Leave_.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchHostelStudent searchHostelStudent = new SearchHostelStudent();
            searchHostelStudent.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hostel_Room hostel_Room = new Hostel_Room();
            hostel_Room.Show();
            this.Hide();
        }
    }
}
