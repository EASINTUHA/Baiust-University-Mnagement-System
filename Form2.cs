using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TextBox = System.Windows.Forms.TextBox;

namespace BAIUST
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public TextBox tb1;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            tb1 = UserId;
        }

        private void Teacher_CheckedChanged(object sender, EventArgs e)
        {
            Student.Checked = false;
        }

        private void Student_CheckedChanged(object sender, EventArgs e)
        {
            Teacher.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UserId.Text;
                string password = Password.Text;
                string Gender = "";
                bool isChacked = Teacher.Checked;
                if (isChacked)
                {
                    Gender = Teacher.Text;
                    if (username == "admin" && password == "baiust")
                    {
                        main_form main_Form = new main_form();
                        main_Form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name And Password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT * FROM NewAdmission WHERE student_id = " + username + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        cmd.CommandText = "SELECT * FROM student_main_login WHERE Student_id = " + username + " AND password = '" + password + "'";
                        SqlDataAdapter da2 = new SqlDataAdapter(cmd);
                        DataSet ds2 = new DataSet();
                        da2.Fill(ds2);
                        if (ds2.Tables[0].Rows.Count != 0)
                        {
                            Student_main_form main_Form = new Student_main_form();
                            main_Form.Show();
                            this.Hide();
                        }
                        else
                        {
                            UserId.Clear();
                            Password.Clear();
                            MessageBox.Show("wrong user id or password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        UserId.Clear();
                        Password.Clear();
                        MessageBox.Show("You are not student of baiust because your student id is not in database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
