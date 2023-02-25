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
    public partial class StudentPament : Form
    {
        public StudentPament()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String department = comboBoxSemester.Text;
                String label = comboBoxLevel.Text;
                String term = comboBoxTerm.Text;
                if (department == "CSE")
                {
                    if (label == "1")
                    {
                        if (term == "1")
                        {
                            label1.Text = "76,600";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "85,000";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "2")
                    {
                        if (term == "1")
                        {
                            label1.Text = "82,200";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "79,400";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "3")
                    {
                        if (term == "1")
                        {
                            label1.Text = "83,600";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "83,600";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "4")
                    {
                        if (term == "1")
                        {
                            label1.Text = "73,800";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "76,600";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "New admission")
                    {
                        label1.Text = "56,000";
                    }
                    else if (label == "Total")
                    {
                        label1.Text = "6,96,800";
                    }
                    else if (label == "Referred")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Backlog")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Improvement")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Term Repeat")
                    {
                        label1.Text = "2800/- Per Credit";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input");
                    }
                }
                else if (department == "CE")
                {
                    if (label == "1")
                    {
                        if (term == "1")
                        {
                            label1.Text = "81,550";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "81,550";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }

                    }

                    else if (label == "2")
                    {
                        if (term == "1")
                        {
                            label1.Text = "78,850";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "76,150";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "3")
                    {
                        if (term == "1")
                        {
                            label1.Text = "77,500";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "81,550";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "4")
                    {
                        if (term == "1")
                        {
                            label1.Text = "76,150";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "80,200";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "New admission")
                    {
                        label1.Text = "56,000";
                    }
                    else if (label == "Total")
                    {
                        label1.Text = "6,89,500";
                    }
                    else if (label == "Referred")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Backlog")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Improvement")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Term Repeat")
                    {
                        label1.Text = "2700/- Per Credit";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input");
                    }
                }
                else if (department == "EEE")
                {
                    if (label == "1")
                    {
                        if (term == "1")
                        {
                            label1.Text = "75,225";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "83,837";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }

                    }
                    else if (label == "2")
                    {
                        if (term == "1")
                        {
                            label1.Text = "81,850";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "79,862";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "3")
                    {
                        if (term == "1")
                        {
                            label1.Text = "83,175";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "79,200";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "4")
                    {
                        if (term == "1")
                        {
                            label1.Text = "85,825";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "64,625";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "New admission")
                    {
                        label1.Text = "56,000";
                    }
                    else if (label == "Total")
                    {
                        label1.Text = "6,89,600";
                    }
                    else if (label == "Referred")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Backlog")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Improvement")
                    {
                        label1.Text = " 1060/- Per Credit";
                    }
                    else if (label == "Term Repeat")
                    {
                        label1.Text = "2650/- Per Credit";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input");
                    }
                }
                else if (department == "DBA")
                {
                    if (label == "1")
                    {
                        if (term == "1")
                        {
                            label1.Text = "53,300";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "57,000";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }

                    }
                    else if (label == "2")
                    {
                        if (term == "1")
                        {
                            label1.Text = "51,450";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "53,300";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "3")
                    {
                        if (term == "1")
                        {
                            label1.Text = "53,300";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "57,000";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "4")
                    {
                        if (term == "1")
                        {
                            label1.Text = "57,000";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "68,100";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "New admission")
                    {
                        label1.Text = "27,300";
                    }
                    else if (label == "Total")
                    {
                        label1.Text = "4,77,750";
                    }
                    else if (label == "Referred")
                    {
                        label1.Text = " 610/- Per Credit";
                    }
                    else if (label == "Backlog")
                    {
                        label1.Text = " 610/- Per Credit";
                    }
                    else if (label == "Improvement")
                    {
                        label1.Text = " 610/- Per Credit";
                    }
                    else if (label == "Term Repeat")
                    {
                        label1.Text = "1850/- Per Credit";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input");
                    }
                }
                else if (department == "ENGLISH")
                {
                    if (label == "1")
                    {
                        if (term == "1")
                        {
                            label1.Text = "45,450";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "49,800";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }

                    }
                    else if (label == "2")
                    {
                        if (term == "1")
                        {
                            label1.Text = "49,800";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "48,350";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "3")
                    {
                        if (term == "1")
                        {
                            label1.Text = "49,800";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "49,800";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "4")
                    {
                        if (term == "1")
                        {
                            label1.Text = "49,800";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "49,800";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "New admission")
                    {
                        label1.Text = "27,300";
                    }
                    else if (label == "Total")
                    {
                        label1.Text = "4,19,900";
                    }
                    else if (label == "Referred")
                    {
                        label1.Text = "360/- Per Credit";
                    }
                    else if (label == "Backlog")
                    {
                        label1.Text = "360/- Per Credit";
                    }
                    else if (label == "Improvement")
                    {
                        label1.Text = "360/- Per Credit";
                    }
                    else if (label == "Term Repeat")
                    {
                        label1.Text = "1450/- Per Credit";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input");
                    }
                }
                else if (department == "LAW")
                {
                    if (label == "1")
                    {
                        if (term == "1")
                        {
                            label1.Text = "27,300";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "51,700";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }

                    }
                    else if (label == "2")
                    {
                        if (term == "1")
                        {
                            label1.Text = "55,200";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "56,950";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "3")
                    {
                        if (term == "1")
                        {
                            label1.Text = "55,200";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "56,950";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "4")
                    {
                        if (term == "1")
                        {
                            label1.Text = "55,200";
                        }
                        else if (term == "2")
                        {
                            label1.Text = "58,700";
                        }
                        else
                        {
                            MessageBox.Show("Wrong Input");
                        }
                    }
                    else if (label == "New admission")
                    {
                        label1.Text = "27,300";
                    }
                    else if (label == "Total")
                    {
                        label1.Text = "4,61,900";
                    }
                    else if (label == "Referred")
                    {
                        label1.Text = "490/- Per Credit";
                    }
                    else if (label == "Backlog")
                    {
                        label1.Text = "490/- Per Credit";
                    }
                    else if (label == "Improvement")
                    {
                        label1.Text = "490/- Per Credit";
                    }
                    else if (label == "Term Repeat")
                    {
                        label1.Text = "1750/- Per Credit";
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Input");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong choice or input.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxSemester.SelectedIndex = -1;
            comboBoxLevel.SelectedIndex = -1;
            comboBoxTerm.SelectedIndex = -1; 
        }
    }
}
