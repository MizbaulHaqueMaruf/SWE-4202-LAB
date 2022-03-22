using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace labFinal
{
    public partial class Form1 : Form
    {
        STUDENT std = new STUDENT();
        public List<STUDENT> studentList = new List<STUDENT>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"C:\Users\Dell\Downloads\SWE4201Mark.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                List<string> listC = new List<string>();
                List<string> listD = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    listBox1.Items.Add(values[0]);
                    listBox2.Items.Add(values[1]);
                    listBox3.Items.Add(values[10]);
                    listBox4.Items.Add(values[11]);
                    STUDENT std = new STUDENT();
                    std.id = values[0];
                    std.name = values[1];
                    std.attendance = Convert.ToInt32(values[2]);
                    std.quiz1 = Convert.ToInt32(values[3]);
                    std.quiz2 = Convert.ToInt32(values[4]);
                    std.quiz3 = Convert.ToInt32(values[5]);
                    std.quiz4 = Convert.ToInt32(values[6]);
                    std.mid = Convert.ToInt32(values[7]);
                    std.final = Convert.ToInt32(values[8]);
                    std.viva = Convert.ToInt32(values[9]);
                  
                    studentList.Add(std);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            foreach (STUDENT i in studentList)
            {
                if (i.id == textBox1.Text)
                {
                    
                    textBox2.Text = Convert.ToString(i.attendance);
                    textBox3.Text = Convert.ToString(i.quiz1);
                    textBox4.Text = Convert.ToString(i.quiz2);
                    textBox5.Text = Convert.ToString(i.quiz3);
                    textBox6.Text = Convert.ToString(i.quiz4);

                    int sum = 0;
                    int[] arr = { i.quiz1, i.quiz2, i.quiz3, i.quiz4 };
                    Array.Sort(arr);
                    for (int j = 1; j < arr.Length; j++)
                    {
                        sum += arr[j];
                    }
                    textBox10.Text = Convert.ToString(sum);
                    textBox9.Text = Convert.ToString(i.mid);
                    textBox8.Text = Convert.ToString(i.final);
                     double Total = Convert.ToDouble(i.final + sum + i.attendance + i.mid +i.viva);
                    textBox7.Text = Convert.ToString(i.final + sum + i.attendance + i.mid + i.viva);
                    

                    double finalResult = (Total / 300.00) * 100.00;


                    if (finalResult >= 80 && finalResult <= 100)
                    {
                        textBox12.Text = "A+";
                    }
                    else if (finalResult >= 75 && finalResult < 80)
                    {
                        textBox12.Text = "A";
                    }
                    if (finalResult >= 70 && finalResult < 75)
                    {
                        textBox12.Text = "A-";
                    }
                    if (finalResult >= 65 && finalResult < 70)
                    {
                        textBox12.Text = "B+";
                    }
                    if (finalResult >= 60 && finalResult < 65)
                    {
                        textBox12.Text = "B";
                    }
                    if (finalResult >= 55 && finalResult < 60)
                    {
                        textBox12.Text = "B-";
                    }
                    if (finalResult >= 50 && finalResult < 55)
                    {
                        textBox12.Text = "C+";
                    }
                    if (finalResult >= 45 && finalResult < 50)
                    {
                        textBox12.Text = "C";
                    }
                    if (finalResult >= 40 && finalResult < 45)
                    {
                        textBox12.Text = "D";
                    }
                    if (finalResult < 40)
                    {
                        textBox12.Text = "F";
                    }
                    textBox13.Text = finalResult + "%";
                    

                    
                }

            }
            
        }
    }
}
