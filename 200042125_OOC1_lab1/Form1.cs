using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StudentID_Click(object sender, EventArgs e)
        {

        }

        private void GradeApp_Load(object sender, EventArgs e)
        {
            
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void StudentIDtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SemesterTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AttendedClassesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quiz1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quiz2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quiz3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quiz4TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculateGradeButton_Click(object sender, EventArgs e)
        {
            int attendance = Convert.ToInt32(AttendedClassesTextBox.Text);
            if (attendance < 0 && attendance > 28)
            {
                MessageBox.Show("Error Entry for Attendance  (0-28)");             
            }

                   
            string semester = SemesterTextbox.Text;
            string fullname = NameTextbox.Text;
            string StudentIDstr = StudentIDtextbox.Text;
            double attendance_Decimal = Convert.ToDouble(attendance);
            double attendanceRatio = (attendance_Decimal / 28.0) * 30.0;
            int quiz1 = Convert.ToInt32(Quiz1TextBox.Text);
            if (quiz1 < 0 && quiz1 > 15)
            {
                MessageBox.Show("Error Entry for Quiz 1 (0-15)");
            }
            int quiz2 = Convert.ToInt32(Quiz2TextBox.Text);
            if (quiz2 < 0 && quiz2 > 15)
            {
                MessageBox.Show("Error Entry for Quiz 2 (0-15)");
            }
            int quiz3 = Convert.ToInt32(Quiz3TextBox.Text);
            if (quiz3 < 0 && quiz3 > 15)
            {
                MessageBox.Show("Error Entry for Quiz 3 (0-15)");
            }
            int quiz4 = Convert.ToInt32(Quiz4TextBox.Text);
            if (quiz4 < 0 && quiz4 > 15)
            {
                MessageBox.Show("Error Entry for Quiz 4 (0-15)");
            }
            int[] arr = { quiz1, quiz2, quiz3, quiz4 };
            Array.Sort(arr);
            int sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int midMarks = Convert.ToInt32(MidTextBox.Text);
            if (midMarks < 0 && midMarks > 75)
            {
                MessageBox.Show("Error Entry Mid Marks (0-75)");
            }
            int finalMarks = Convert.ToInt32(FinalTextBox.Text);
            if (finalMarks < 0 && finalMarks > 150)
            {
                MessageBox.Show("Error Entry Mid Marks (0-150)");
            }
            double Total = attendanceRatio + Convert.ToDouble(quiz1) + Convert.ToDouble(quiz2) + Convert.ToDouble(quiz3) + Convert.ToDouble(quiz4) + Convert.ToDouble(midMarks) + Convert.ToDouble(finalMarks);

            double QuizSum = sum;
            double finalResult = (Total / 300.00) * 100.00;


            if (finalResult >= 80 && finalResult <= 100)
            {
                lblGrade.Text = "A+";
            }
            else if (finalResult >= 75 && finalResult < 80)
            {
                lblGrade.Text = "A";
            }
            if (finalResult >= 70 && finalResult < 75)
            {
                lblGrade.Text = "A-";
            }
            if (finalResult >= 65 && finalResult < 70)
            {
                lblGrade.Text = "B+";
            }
            if (finalResult >= 60 && finalResult < 65)
            {
                lblGrade.Text = "B";
            }
            if (finalResult >= 55 && finalResult < 60)
            {
                lblGrade.Text = "B-";
            }
            if (finalResult >= 50 && finalResult < 55)
            {
                lblGrade.Text = "C+";
            }
            if (finalResult >= 45 && finalResult < 50)
            {
                lblGrade.Text = "C";
            }
            if (finalResult >= 40 && finalResult < 45)
            {
                lblGrade.Text = "D";
            }
            if (finalResult < 40)
            {
                lblGrade.Text = "F";
            }


            lblAttendance.Text = Convert.ToString(Math.Round(attendanceRatio,2)) + " /30";
            lblMid.Text = Convert.ToString(Math.Round(Convert.ToDouble(midMarks),2)) + " /75";
            lblQuiz.Text = Convert.ToString(Math.Round(QuizSum,2)) + " /45";
            lblFinal.Text = Convert.ToString(Math.Round(Convert.ToDouble(finalMarks),2)) + " /150";
            lblTotal.Text = Convert.ToString(Math.Round(Total,2)) +" /300";
            lblStatement.Text = fullname+ " obtained " + Convert.ToString(Math.Round(finalResult, 2)) + "% marks.";



        }

        private void FinalObtained_Click(object sender, EventArgs e)
        {

        }
    }
}
