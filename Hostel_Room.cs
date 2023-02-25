using hostel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAIUST
{
    public partial class Hostel_Room : Form
    {
        public Hostel_Room()
        {
            InitializeComponent();
        }

        private void Hostel_Room_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from Rooms";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Choice.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Int64 Room_No =Int64.Parse( roomno.Text);
            String Status = rStatus.Text;
            String Seat = seat.Text;
            String Date = date.Text;
            String Bilding_no = bildingno.Text;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into Rooms (Room_No,Status,Seat,Date,bilding_no) values ("+ Room_No + ",'"+ Status + "','"+ Seat + "','"+ Date + "','"+ Bilding_no + "')";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Data Insert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Choice.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Int64 Room_No = Int64.Parse(roomno.Text);
            String Status = rStatus.Text;
            String Seat = seat.Text;
            String Date = date.Text;
            String Bilding_no = bildingno.Text;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "UPDATE Rooms SET Status = '" + Status + "' WHERE Room_No = " + Room_No + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);
                cmd.CommandText = "UPDATE Rooms SET Seat = '" + Seat + "' WHERE Room_No = " + Room_No + "";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);

                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                cmd.CommandText = "UPDATE Rooms SET Bilding_no = '" + Bilding_no + "' WHERE Room_No = " + Room_No + "";
                SqlDataAdapter da2 = new SqlDataAdapter(cmd);

                DataSet ds2 = new DataSet();
                da.Fill(ds2);
                MessageBox.Show("Data Saved ." + "upgrated The Information.", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Choice.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hostel_Room hostel_Room = new Hostel_Room();
            hostel_Room.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection Co = new SqlConnection();
                    Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Co;


                    cmd.CommandText = "DELETE FROM Rooms WHERE Room_No = " + roomno.Text + "";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    MessageBox.Show("Successfully Removed", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            roomno.Clear();
            rStatus.SelectedIndex = -1;
            seat.SelectedIndex= -1;
            bildingno.SelectedIndex= -1;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from Rooms";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Choice.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HostelStudentFees hostelStudentFees = new HostelStudentFees();
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

        private void button6_Click(object sender, EventArgs e)
        {
            SearchHostelStudent searchHostelStudent = new SearchHostelStudent();
            searchHostelStudent.Show();
            this.Hide();
        }
    }
}
