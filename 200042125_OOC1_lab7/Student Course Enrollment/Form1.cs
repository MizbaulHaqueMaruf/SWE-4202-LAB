using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Course_Enrollment
{
    public partial class Form1 : Form
    {
        List<STUDENTS> studentsList = new List<STUDENTS>();
        List<PROFESSIONALS> professionalsList = new List<PROFESSIONALS>();
        List<COURSE> courseList = new List<COURSE>();

        public Form1()
        {
            InitializeComponent();
        }

        private void participantAddButton_Click(object sender, EventArgs e)
        {
            string name = parNameTxt.Text;
            string reg = parRegTxt.Text;
            string contact = parContactText.Text;
            string email = parEmailTxt.Text;
            string type = comboBox1.Text;
            string level = comboBox2.Text;

            if (level == "Beginner")
            {
                if (type == "Student")
                {
                    STUDENTS temp = new STUDENTS(name, reg, contact, email, type, level);


                    studentsList.Add(temp);
                    MessageBox.Show("Participant Added Successfully");

                    comboBox4.Items.Add(reg);
                    comboBox6.Items.Add(reg);
                }

                else
                {
                    PROFESSIONALS temp = new PROFESSIONALS(name, reg, contact, email, type, level);


                    professionalsList.Add(temp);
                    MessageBox.Show("Participant Added Successfully");

                    comboBox4.Items.Add(reg);
                    comboBox6.Items.Add(reg);
                }
            }

            else if(level == "Intermediate")
            {
                if (type == "Student")
                {
                    STUDENTS temp = new STUDENTS(name, reg, contact, email, type, level);


                    studentsList.Add(temp);
                    MessageBox.Show("Participant Added Successfully");

                    comboBox4.Items.Add(reg);
                    comboBox6.Items.Add(reg);
                }

                else
                {
                    PROFESSIONALS temp = new PROFESSIONALS(name, reg, contact, email, type, level);


                    professionalsList.Add(temp);
                    MessageBox.Show("Participant Added Successfully");

                    comboBox4.Items.Add(reg);
                    comboBox6.Items.Add(reg);
                }
            }
            else
            {
                if (type == "Student")
                {
                    STUDENTS temp = new STUDENTS(name, reg, contact, email, type, level);


                    studentsList.Add(temp);
                    MessageBox.Show("Participant Added Successfully");

                    comboBox4.Items.Add(reg);
                    comboBox6.Items.Add(reg);
                }

                else
                {
                    PROFESSIONALS temp = new PROFESSIONALS(name, reg, contact, email, type, level);


                    professionalsList.Add(temp);
                    MessageBox.Show("Participant Added Successfully");

                    comboBox4.Items.Add(reg);
                    comboBox6.Items.Add(reg);
                }
            }
        }

        private void courseInfoAddButton_Click(object sender, EventArgs e)
        {
            string title = courseTitleTxt.Text;
            string level = comboBox3.Text;
            double fee = Convert.ToDouble(courseFeeTxt.Text);

            COURSE temp = new COURSE( title,  level,  fee);

            courseList.Add(temp);
            MessageBox.Show("Course Added Successfully");

            comboBox5.Items.Add(title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string reg = comboBox4.Text;
            string crs = comboBox5.Text;
            string date = dateTimePicker1.Text;

            double fee = 0;
            bool flag = false;
            foreach (STUDENTS student in studentsList)
            {
                if (student.reg == reg)
                {
                    foreach (COURSE course in courseList)
                    {
                        if (crs == course.title && student.level == course.level)
                        {
                            flag = true;
                            student.courseList.Add(course);
                            fee = student.FeesPayable(course.fee);
                            student.totalPay = fee;
                            student.date = date;
                        }
                    }
                }
            }

            if (!flag)
            {
                foreach (PROFESSIONALS pro in professionalsList)
                {
                    if (pro.reg == reg)
                    {
                        foreach (COURSE course in courseList)
                        {
                            if (crs == course.title && pro.level == course.level)
                            {
                                flag = true;
                                pro.courseList.Add(course);
                                fee = pro.FeesPayable(course.fee);
                                fee = fee + (fee * 10) / 100;
                                pro.totalPay = fee;
                                pro.date = date;
                            }
                        }
                    }
                }
            }

            if (flag)
            {
                label17.Text = "Course Fee TK " + fee.ToString() + "  has been deducted from your account";
                MessageBox.Show("Successfully Enrolled");
            }
            else
            {
                MessageBox.Show("Not applicable!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string regNo = comboBox6.Text;
            bool flag = false;
            listBox1.Items.Clear();
            listBox1.Items.Add("Course Title" + "\t" + " Course Level" + "\t" + "Student Paid" + "\t" + "Enrollment Date");
            foreach (STUDENTS student in studentsList)
            {
                if (student.reg == regNo)
                {
                    flag = true;
                    listBox1.Items.Add(student.StudInfo(student));
                }
            }

            if (!flag)
            {
                foreach (PROFESSIONALS pro in professionalsList)
                {
                    flag = true;
                    listBox1.Items.Add(pro.Proinfo(pro));
                }
            }
        }
    }
}