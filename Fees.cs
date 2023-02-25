using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BAIUST
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Int64 student_id = Int64.Parse(textBoxStudentId.Text);
            String Full_name=textBoxFullName.Text;
            String Current_Semester = comboBoxSemester.Text;
            String Level = comboBoxLevel.Text;
            String Term = comboBoxTerm.Text;
            String Fees = textBoxFees.Text;
            String Date = dateTimePickerDate.Text;
            try
            {
                SqlConnection Co = new SqlConnection();
                Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Co;
                cmd.CommandText = "insert into Fees(student_id,Full_name,Current_Semester,Level,Term,Fees,Date) values(" + student_id + ",'" + Full_name + "','" + Current_Semester + "','" + Level + "','" + Term + "','" + Fees + "','" + Date + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                MessageBox.Show("Data Saved . Thanks .", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Fees_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Co = new SqlConnection();
                Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Co;
                cmd.CommandText = "Select max(serial_no) from Fees";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
                serial.Text = abc.ToString();
                Co.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxStudentId.Clear();
            textBoxFullName.Clear();
            comboBoxSemester.SelectedIndex = -1;
            comboBoxLevel.SelectedIndex = -1;
            comboBoxTerm.SelectedIndex = -1;
            textBoxFees.Clear();
            dateTimePickerDate.ResetText();
        }
    }
}
