using hostel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BAIUST
{
    public partial class SearchHostelStudent : Form
    {
        public SearchHostelStudent()
        {
            InitializeComponent();
        }

        private void SearchHostelStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from hostel_student";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchHostelStudent searchHostelStudent = new SearchHostelStudent();
            searchHostelStudent.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from hostel_student where student_id =" + textBox2.Text + " ";
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
            HostelStudentFees hostelStudentFees= new HostelStudentFees();
            hostelStudentFees.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hostel_leave_student hostel_Leave_ = new Hostel_leave_student();
            hostel_Leave_.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hostel_new_employee hostel_New_Employee = new hostel_new_employee();
            hostel_New_Employee.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Hostel_Room hostel_Room = new Hostel_Room();
            hostel_Room.Show();
            this.Hide();
        }
    }
}
