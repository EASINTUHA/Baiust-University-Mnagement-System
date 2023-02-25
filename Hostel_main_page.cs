using BAIUST;
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

namespace hostel
{
    public partial class Hostel_main_page : Form
    {
        public Hostel_main_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            Hostel_main_page hostel_Main_Page = new Hostel_main_page();
            hostel_Main_Page.Show();
            this.Hide();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            TxtLastName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
            comboBoxSemester.SelectedIndex = -1;
            comboBoxDepertment.SelectedIndex = -1;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            comboBoxLevel.SelectedIndex = -1;
            comboBoxTerm.SelectedIndex = -1;
            dateTimePickerDate.ResetText();
            txtEmail.Clear();
            txtMobileNo.Clear();
            txtAddress.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Int64 student_id = Int64.Parse(txtStudentId.Text);
            string FIRST_Name = txtFirstName.Text;
            string Last_Name = TxtLastName.Text;
            string Father_Name = txtFatherName.Text;
            string Mother_Name = txtMotherName.Text;
            string Semester = comboBoxSemester.Text;
            string Department = comboBoxDepertment.Text;
            string Gender = "";
            bool isChacked = radioButtonMale.Checked;
            if (isChacked)
            {
                Gender = radioButtonMale.Text;
            }
            else
            {
                Gender = radioButtonFemale.Text;
            }
            string Level_ = comboBoxLevel.Text;
            string Term = comboBoxTerm.Text;
            string Date_Of_birth = dateTimePickerDate.Text;
            string Email = txtEmail.Text;
            string Mobile_no = txtMobileNo.Text;
            string Address = txtAddress.Text;
            try
            {
                SqlConnection Co = new SqlConnection();
                Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Co;

                cmd.CommandText = "insert into hostel_student(student_id,FIRST_Name,Last_Name,Father_Name,Mother_Name,Semester,Department,Gender,Level_,Term,Date_Of_birth,Mobile_no,Èmail,Address) values(" + student_id + ",'" + FIRST_Name + "','" + Last_Name + "','" + Father_Name + "','" + Mother_Name + "','" + Semester + "','" + Department + "','" + Gender + "','" + Level_ + "','" + Term + "','" + Date_Of_birth + "','" + Mobile_no + "','" + Email + "','" + Address + "')";

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

        private void button2_Click(object sender, EventArgs e)
        {
            HostelStudentFees hostelStudentFees = new HostelStudentFees();
            hostelStudentFees.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SearchHostelStudent searchHostelStudent = new SearchHostelStudent();
            searchHostelStudent.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hostel_Room hostel_Room = new Hostel_Room();
            hostel_Room.Show();
            this.Hide();
        }

        private void Hostel_main_page_Load(object sender, EventArgs e)
        {

        }
    }
}
