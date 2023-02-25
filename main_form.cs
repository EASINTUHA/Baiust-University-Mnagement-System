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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_form main_Form = new main_form();
            main_Form.Show();
            this.Hide();
        }

        private void pamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void admissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAdmission newAdmission = new NewAdmission();
            newAdmission.Show();
        }

        private void updateSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgrateSemester upgrateSemester = new UpgrateSemester();
            upgrateSemester.Show();
        }

        private void feeStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentPament studentPament = new StudentPament();
            studentPament.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_details studentDetails = new Student_details();
            studentDetails.Show();
        }

        private void indivdualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentIndvidualDetails student_ind_det = new StudentIndvidualDetails();
            student_ind_det.Show();
        }

        private void busCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUSCARD buscard = new BUSCARD();
            buscard.Show();
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
            CE cE = new CE();
            cE.Show();
        }

        private void dbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBA dba = new DBA();
            dba.Show();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ENGLISH english = new ENGLISH();
            english.Show();
        }

        private void lLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LAW law = new LAW();
            law.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_information tec = new Teacher_information();
            tec.Show();
        }

        private void searchTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher Sec_teacherc = new SearchTeacher();
            Sec_teacherc.Show();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUSSCHEDULE bUSSCHEDULE = new BUSSCHEDULE();
            bUSSCHEDULE.Show();
        }

        private void busCardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BUSCARD buscard = new BUSCARD();
            buscard.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUSCARDSEARCH bUSCARDSEARCH = new BUSCARDSEARCH();
            bUSCARDSEARCH.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Student remove_Student = new Remove_Student();
            remove_Student.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about details = new about();
            details.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            developer developer = new developer();
            developer.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void photoGallaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            photoGallary photoGallary = new photoGallary();
            photoGallary.Show();
        }

        private void studentLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form1form1 = new Form2();
            form1form1.Show();
            this.Hide();
        }

        private void adminLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form1form1 = new Form2();
            form1form1.Show();
            this.Hide();
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Library library = new Library();
            library.Show();

        }

        private void seePamentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paymentlist list = new paymentlist();
            list.Show();
        }

        private void makePamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fee = new Fees();
            fee.Show();
        }

        private void hostelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HostelAdminLogin hostelAdminLogin = new HostelAdminLogin();
            hostelAdminLogin.Show();
        }

        private void studentResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_result student_Result = new Student_result();
            student_Result.Show();
        }

        private void teacherEvulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teacherevulation teacherevulation = new teacherevulation();
            teacherevulation.Show();
        }

        private void messegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            meaaege meaaege = new meaaege();
            meaaege.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            meaaege meaaege = new meaaege();
            meaaege.Show();
        }

        private void routinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            routone routone = new routone();
            routone.Show();
        }
    }
}
