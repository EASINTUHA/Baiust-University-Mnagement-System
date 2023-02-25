using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BAIUST
{
    public partial class Student_main_form : Form
    {
        public Student_main_form()
        {
            InitializeComponent();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_main_form form5 = new Student_main_form();
            form5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void feeStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentPament studentPament = new StudentPament();
            studentPament.Show();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUSSCHEDULE bUSSCHEDULE = new BUSSCHEDULE();
            bUSSCHEDULE.Show();
        }

        private void busCardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BUSCARD bUSCARD = new BUSCARD();
            bUSCARD.Show();
        }

        private void searchTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher Sec_teacherc = new SearchTeacher();
            Sec_teacherc.Show();
        }

        private void cSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CSE cse = new CSE();
            cse.Show();
        }

        private void eEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EEE eee = new EEE();
            eee.Show();
        }

        private void cEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CE ce = new CE();
            ce.Show();
        }

        private void dbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBA ce = new DBA();
            ce.Show();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ENGLISH ce = new ENGLISH();
            ce.Show();
        }

        private void lLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LAW law = new LAW();
            law.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about details = new about();
            details.Show();
        }

        private void Student_main_form_Load(object sender, EventArgs e)
        {
            try
            {
                Int64 studentid = Int64.Parse(Form2.instance.tb1.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = TUHA\\SQLEXPRESS; database = BAIUST ; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from NewAdmission where student_id=" + studentid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    FIRST_Name.Text = ds.Tables[0].Rows[0][1].ToString();
                    Last_Name.Text = ds.Tables[0].Rows[0][2].ToString();
                    Father_Name.Text = ds.Tables[0].Rows[0][3].ToString();
                    Mother_Name.Text = ds.Tables[0].Rows[0][4].ToString();
                    Semester.Text = ds.Tables[0].Rows[0][5].ToString();
                    Department.Text = ds.Tables[0].Rows[0][6].ToString();
                    Gender.Text = ds.Tables[0].Rows[0][7].ToString();
                    Level_.Text = ds.Tables[0].Rows[0][8].ToString();
                    lTerm.Text = ds.Tables[0].Rows[0][9].ToString();
                    Date_Of_birth.Text = ds.Tables[0].Rows[0][10].ToString();
                    Email.Text = ds.Tables[0].Rows[0][11].ToString();
                    Mobile_no.Text = ds.Tables[0].Rows[0][12].ToString();
                    Address.Text = ds.Tables[0].Rows[0][13].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            HostelAdminLogin hostelAdminLogin = new HostelAdminLogin();
            hostelAdminLogin.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            library.Show();
        }

        private void teacherEvulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacherevulation teacherevulation = new teacherevulation();
            teacherevulation.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Student_result_student student = new Student_result_student();
            student.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndvidualDetails studentIndvidualDetails = new StudentIndvidualDetails();
            studentIndvidualDetails.Show();
        }

        private void teacherEvulationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeacherEvulationStudent teacher = new TeacherEvulationStudent();
            teacher.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void routineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            routone routone = new routone();
            routone.Show();
        }
    }
}
