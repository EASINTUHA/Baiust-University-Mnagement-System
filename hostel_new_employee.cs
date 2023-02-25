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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BAIUST
{
    public partial class hostel_new_employee : Form
    {
        public hostel_new_employee()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            employee_id.Clear();
            FirstName.Clear();
            LastName.Clear();
            FatherName.Clear();
            MotherName.Clear();
            Gender.Items.Clear();
            email.Clear();
            mobileno.Clear();
            address.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
           {
                SqlConnection Co = new SqlConnection();
                Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Co;
                cmd.CommandText = "insert into Persons(employee_id,FirstName,LastName,FatherName,MotherName,Gender,dob ,email,mobileno,address) values('" + address.Text + "','" + FirstName.Text + "','" + LastName.Text + "','" + FatherName.Text + "','" + MotherName.Text + "','" + Gender.Text + "','" + dob.Text + "','" + email.Text + "','" + mobileno.Text + "','" + address.Text + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);
                Co.Close();
                MessageBox.Show("Data Saved . Pleace contract hostel mnager", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hostel_new_employee hostel_New_employee = new hostel_new_employee();
            hostel_New_employee.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hostel_leave_student hostel_Leave_ = new Hostel_leave_student();
            hostel_Leave_.Show();
            this.Hide();
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchHostelStudent searchHostelStudent = new SearchHostelStudent();
            searchHostelStudent.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hostel_Room hostel_Room = new Hostel_Room();
            hostel_Room.Show();
            this.Hide();
        }
    }
}
