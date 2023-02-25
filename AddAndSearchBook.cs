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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BAIUST
{
    public partial class AddAndSearchBook : Form
    {
        public AddAndSearchBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from booklist where Book_Id =" + bookId.Text + " ";
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
            try
            {
                Int64 bookid = Int64.Parse(bookId.Text);
                String bookname = Bookname.Text;

                SqlConnection Co = new SqlConnection();
                Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Co;

                cmd.CommandText = "insert into booklist(Book_Id,Book_Name)values(" + bookid + ",'" + bookname + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                Co.Close();
                MessageBox.Show("Data Saved ", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            main_form main_Form = new main_form();
            main_Form.ShowDialog();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddAndSearchBook_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from booklist";
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
    }
}
