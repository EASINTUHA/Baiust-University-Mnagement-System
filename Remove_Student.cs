using Microsoft.VisualBasic;
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
    public partial class Remove_Student : Form
    {
        public Remove_Student()
        {
            InitializeComponent();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection Co = new SqlConnection();
                    Co.ConnectionString = "data source =TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Co;


                    cmd.CommandText = "DELETE FROM NewAdmission WHERE student_id = " + textBoxRemoveStudent.Text + "; DELETE FROM Fees WHERE student_id = " + textBoxRemoveStudent.Text + " ";
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
    }
}
