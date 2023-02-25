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
    public partial class Teacher_information : Form
    {
        public Teacher_information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 Facultry_id = Int64.Parse(texFacultryId.Text);
            string Full_Name = texFacultryName.Text;
            string Gender = "";
            bool isChacked = radioMale.Checked;
            if (isChacked)
            {
                Gender = radioMale.Text;
            }
            else
            {
                Gender = radioFemale.Text;
            }
            string Date_Of_birth = Date_of_birth.Text;
            string Mobile_no = texMobile_no.Text;
            string Email = txtEmail.Text;
            string Department = comboDepatrment.Text;
            string Designation = comboDesignation.Text;
            string Address = richTextBox1.Text;
           
                SqlConnection Co = new SqlConnection();
                Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Co;

                cmd.CommandText = "insert into Teacher(Teacher_Id,Full_Name,Gender,Date_Of_birth,Mobile_no,Email,Department,Designation,Address) values(" + Facultry_id + ",'" + Full_Name + "','" + Gender + "','" + Date_Of_birth + "','" + Mobile_no + "','" + Email + "','" + Department + "','" + Designation + "','" + Address + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();

                DA.Fill(DS);
                Co.Close();
                MessageBox.Show("Data Saved . Remember the Teacher Id", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Teacher_information_Load(object sender, EventArgs e)
        {

        }
    }
}
