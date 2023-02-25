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
    public partial class photo_gallary2 : Form
    {
        public photo_gallary2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            photo_gallary3 photo_Gallary3 = new photo_gallary3();
            photo_Gallary3.Show();
            this.Hide();
        }
    }
}
