using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BAIUST
{
    public partial class NewAdmission : Form
    {
        public NewAdmission()
        {
            InitializeComponent();
        }

        private void NewAdmission_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

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
            try
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
            if(isChacked )
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
                SqlConnection Co = new SqlConnection();
                Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Co;

                cmd.CommandText = "insert into NewAdmission(student_id,FIRST_Name,Last_Name,Father_Name,Mother_Name,Semester,Department,Gender,Level_,Term,Date_Of_birth,Mobile_no,Email,Address) values(" + student_id + ",'" + FIRST_Name + "','" + Last_Name + "','" + Father_Name + "','" + Mother_Name + "','" + Semester + "','" + Department + "','" + Gender + "','" + Level_ + "','" + Term + "','" + Date_Of_birth + "','" + Mobile_no + "','" + Email + "','" + Address + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);
                Co.Close();
                MessageBox.Show("Data Saved . Remember the Student Id", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void texEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void texMotherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void texFatherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }
    }
}
