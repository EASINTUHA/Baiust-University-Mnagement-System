using hostel;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAIUST
{
    public partial class HostelAdminLogin : Form
    {
        public HostelAdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = textBox1.Text;
            string password = textBox2.Text;
            if (userid == "admin" && password == "library")
            {
                Hostel_main_page hostel_Main_Page = new Hostel_main_page();
                hostel_Main_Page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name And Password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
