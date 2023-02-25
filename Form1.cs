namespace BAIUST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 2;
            progressBar1.Value = startpos;
            label2.Text=startpos+"%";
            if(progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop(); 
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide(); 
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}