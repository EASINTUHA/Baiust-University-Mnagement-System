using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BAIUST
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                if (textBox2.Text == textBox1.Text)
                {
                    Int64 Student_id = Int64.Parse(textBox3.Text);
                    String password = textBox2.Text;
                    String email = UserId.Text;
                    String phone = Password.Text;
                    SqlConnection Co = new SqlConnection();
                    Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Co;
                    cmd.CommandText = "insert into student_main_login (Student_id,password,email,phone) values(" + Student_id + ",'" + password + "','" + email + "','" + phone + "')";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    Co.Close();
                MessageBox.Show("data saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                else
                {
                    MessageBox.Show("you password and conferm password din not match.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
           {
                MessageBox.Show("Data Not Saved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
        private void UserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
