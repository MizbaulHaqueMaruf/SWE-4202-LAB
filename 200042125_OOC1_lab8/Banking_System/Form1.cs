using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ACCOUNT acc = new ACCOUNT();
        CURRENT curr = new CURRENT();
        SAVINGS sav = new SAVINGS();
        LOAN loa = new LOAN();

        public static int cnt = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string accType = comboBox1.Text;
            double amount = Convert.ToDouble(textBox2.Text);
            string date = dateTimePicker1.Text;
            string temp = Convert.ToString(acc.IdGenerator());

            if(accType == "Current Acc.")
            {
                string accNum = temp + 300;
                if(amount >= 500)
                {
                    curr = new CURRENT(name,accNum,amount,date);
                    curr.currentList.Add(curr);
                    MessageBox.Show("Your CURRENT ACCOUNT has been created.Your Account No.: " + accNum);
                }
                else
                {
                    MessageBox.Show("Sorry! Account cannot be created!");
                }
            }

            else if(accType == "Savings Acc.")
            {
                string accNum = temp + 314;
                if (amount >= 50000)
                {
                    sav = new SAVINGS(name, accNum, amount, date);
                    sav.savingsList.Add(sav);
                    MessageBox.Show("Your SAVINGS ACCOUNT has been created.Your Account No.: " + accNum);
                }
                else
                {
                    MessageBox.Show("Sorry! Account cannot be created!");
                }

            }

            else
            {
                string accNum = temp + 400;
                amount = amount + (amount * 0.09);
                loa = new LOAN(name, accNum, amount, date);
                loa.loanList.Add(loa);
                MessageBox.Show("Your LOAN ACCOUNT has been created.Your Account No.: " + accNum);
                
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string type = comboBox2.Text;
            if (type == "Current Acc.")
            {
                foreach(CURRENT i in curr.currentList)
                {
                    try
                    {
                        if (i.accNum == textBox3.Text)
                        {
                            double deposited = Convert.ToDouble(textBox4.Text);
                            if (deposited < 0)
                            {
                                throw new System.Exception();
                            }

                            else
                            {
                                i.amount = i.amount + deposited;
                                i.historyList.Add("Deposited " + deposited + " on " + dateTimePicker2.Text);
                                MessageBox.Show("Deposited successfully.");
                                break;
                            }
                        }
                        
                    }
                    catch(System.Exception)
                    {
                        MessageBox.Show("Invalid Input!");
                    }
                }
            }

            else if (type == "Savings Acc.")
            {
                foreach (SAVINGS i in sav.savingsList)
                {
                    try
                    {
                        if (cnt > 5)
                        {
                            throw new System.Exception();
                        }

                        if (i.accNum == textBox3.Text)
                            {
                                cnt++;
                                double deposited = Convert.ToDouble(textBox4.Text);
                                if (deposited < 0)
                                {
                                    throw new System.Exception();
                                }

                                else
                                {
                                    i.amount = i.amount + deposited;
                                    i.historyList.Add("Deposited " + deposited + " on " + dateTimePicker2.Text);
                                    MessageBox.Show("Deposited successfully.");
                                    break;
                                }
                            }
                            
                                              
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("Invalid Input!");
                    }
                }
                

            }

            else
            {
                foreach (LOAN i in loa.loanList)
                {
                    try
                    {
                        if (i.accNum == textBox3.Text)
                        {
                            double deposited = Convert.ToDouble(textBox4.Text);
                            double remaining = i.amount - deposited;
                            if (deposited < 0 || remaining < 0)
                            {
                                throw new System.Exception();
                            }

                            else
                            {
                                i.amount = i.amount - deposited;
                                i.historyList.Add("Deposited " + deposited + " on " + dateTimePicker2.Text);
                                MessageBox.Show("Deposited successfully.");
                                break;
                            }
                        }
                        
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("Invalid Input!");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string type = comboBox3.Text;
            if (type == "Current Acc.")
            {
                foreach (CURRENT i in curr.currentList)
                {
                    try
                    {
                        if (i.accNum == textBox5.Text && Convert.ToDouble(textBox6.Text) <= 100000)
                        {
                            double deposited = Convert.ToDouble(textBox6.Text);
                            double remaining = i.amount - deposited;
                            if (deposited < 0 || remaining < 0)
                            {
                                throw new System.Exception();
                            }

                            else
                            {
                                i.amount = i.amount - deposited;
                                i.historyList.Add("Withdrawed " + deposited + " on " + dateTimePicker3.Text);
                                MessageBox.Show("Withdrawed successfully.");
                            }
                        }
                        
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("Invalid Input!");
                    }
                }
                
            }

            else if(type == "Savings Acc.")
            {
                foreach (SAVINGS i in sav.savingsList)
                {
                    try
                    {
                        if (i.accNum == textBox5.Text)
                        {
                            double deposited = Convert.ToDouble(textBox6.Text);
                            double remaining = i.amount - (deposited + 15);
                            if (deposited < 0 || remaining < 0)
                            {
                                throw new System.Exception();
                            }
                            else
                            {
                                i.amount = i.amount - deposited;
                                i.historyList.Add("Withdrawed " + deposited + " on " + dateTimePicker3.Text);
                                MessageBox.Show("Withdrawed successfully.");
                            }
                        }
                       
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("Invalid Input!");
                    }
                }
                
            }

            else
            {
                MessageBox.Show("Sorry! Loan account does not allow to withdraw.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string type = comboBox4.Text;
            listBox2.Items.Clear();
            listBox1.Items.Clear();

            if(type == "Current Acc.")
            {
                foreach(CURRENT i in curr.currentList)
                {
                    if(i.accNum == textBox7.Text)
                    {
                        foreach(string j in i.historyList)
                        {
                            listBox2.Items.Add(j);
                        }
                        listBox1.Items.Add(" Name: " + i.name + "\t" + " Account No.: " + i.accNum + "\t" + " Balance: " + i.amount);
                    }
                    
                }
                
            }

            else if(type == "Savings Acc.")
            {
                foreach (SAVINGS i in sav.savingsList)
                {
                    if (i.accNum == textBox7.Text)
                    {
                        foreach (string j in i.historyList)
                        {
                            listBox2.Items.Add(j);
                        }
                        listBox1.Items.Add(" Name: " + i.name + "\t" + " Account No.: " + i.accNum + "\t" + " Balance: " + i.amount);
                    }
                }
                
            }

            else
            {
                foreach (LOAN i in loa.loanList)
                {
                    if (i.accNum == textBox7.Text)
                    {
                        foreach (string j in i.historyList)
                        {
                            listBox2.Items.Add(j);
                        }
                        listBox1.Items.Add(" Name: " + i.name + "\t" + " Account No.: " + i.accNum + "\t" + " Balance: " + i.amount + " remaining");
                    }
                }
              
            }
        }
    }
}
//MessageBox.Show("Test!");
