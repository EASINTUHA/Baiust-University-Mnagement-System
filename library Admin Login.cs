﻿using System;
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
    public partial class library_Admin_Login : Form
    {
        public library_Admin_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = UserId.Text;
            string password = Password.Text;
            if (userid == "admin" && password == "library")
            {
                AddAndSearchBook addAndSearchBook = new AddAndSearchBook();
                addAndSearchBook.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name And Password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void library_Admin_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
