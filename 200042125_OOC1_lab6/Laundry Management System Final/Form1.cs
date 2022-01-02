using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry_Management_System_Final
{
    public partial class Form1 : Form
    {
        public LAUNDRY Laundry1 = new LAUNDRY();

        public double curr_account = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(textBox2.Text);
            string name = textBox3.Text;
            string address = textBox4.Text;
            USER user = new USER(UserID, name, address);
            Laundry1.users.Add(user);
            MessageBox.Show("The User has been added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(textBox5.Text);
            int pant_number = Convert.ToInt32(textBox7.Text);
            int shirt_number = Convert.ToInt32(textBox6.Text);
            int suits_number = Convert.ToInt32(textBox8.Text);
            int orderID = LAUNDRY.GenerateOrderID();
            bool flag = false;
            if (Laundry1.order_shirt(UserID, shirt_number, orderID, comboBox2.Text) && Laundry1.order_pant(UserID, pant_number, orderID, comboBox3.Text) && Laundry1.order_suit(UserID, suits_number, orderID, comboBox4.Text))
            {
                Laundry1.LaundryCalcTotal(UserID);
                foreach (USER user in Laundry1.users)
                {
                    if (user.UserID == UserID)
                    {
                        flag = true;
                        MessageBox.Show("Your order ID is " + orderID.ToString() + " " + "Please pay BDT " + Laundry1.LaundryCalcTotal(orderID).ToString());
                        break;
                    }
                }
            }
            if (!flag)
            {
                MessageBox.Show("Please create account first");
            }

            /*foreach(USER user in Laundry1.users)
            {
                if (user.UserID == UserID)
                {
                    Laundry1.shirt1.shirtcalc(orderID, shirt_number, comboBox2.Text, user);
                    Laundry1.shirts.Add(Laundry1.shirt1);

                    Laundry1.pant.pantcalc(orderID, pant_number, comboBox3.Text, user);
                    Laundry1.pants.Add(Laundry1.pant);

                    Laundry1.suit.suitcalc(orderID, suits_number, comboBox4.Text, user);
                    Laundry1.suits.Add(Laundry1.suit);


                    MessageBox.Show("Your order ID is " + orderID.ToString() + " " + "Please pay BDT " + Laundry1.LaundryCalcTotal(orderID).ToString());
                    break;


                }

                
                    MessageBox.Show("Please create account first");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int orderid = Convert.ToInt32(textBox1.Text);
            bool flag = false;
            foreach (USER user in Laundry1.users)
            {
                foreach (PANT pant in Laundry1.pants)
                {
                    if (pant.orderID == orderid)
                    {
                        flag = true;
                        Laundry1.OrderSituation(orderid, comboBox1.Text);
                        if (pant.Current_Stat == "Delivered")
                        {
                            curr_account = curr_account + Laundry1.total_cost;
                            label22.Text = curr_account.ToString();
                            MessageBox.Show("The order has been delivered");
                            break;
                        }
                        MessageBox.Show("Order Status has been updated");
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Invalid OrderID");
            }*/

            int orderid = Convert.ToInt32(textBox1.Text);

            foreach (PANT pant in Laundry1.pants)
            {
                if (pant.orderID == orderid)
                {
                    Laundry1.OrderSituation(orderid, comboBox1.Text);
                    if (pant.Current_Stat == "Delivered")
                    {
                        curr_account = curr_account + Laundry1.LaundryCalcTotal(orderid);
                        label22.Text = curr_account.ToString();
                        MessageBox.Show("The order has been delivered");
                        break;
                    }

                    else
                    {
                        MessageBox.Show("Order Status has been updated");
                        break;
                    }
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(textBox9.Text);
            bool flag = false;
            foreach (USER user in Laundry1.users)
            {
                listBox.Items.Clear();
                listBox.Items.Add("Dress" + "\t" + "Quantity" + "\t" + "To_Do" + "\t" + "Amount");
                foreach (SHIRT shirt in Laundry1.shirts)
                {
                    if (shirt.orderID == orderID)
                    {
                        /*flag = true;
                        label18.Text = pant.Current_Stat.ToString();
                        label19.Text = Laundry1.total_cost.ToString();
                        label20.Text = Laundry1.User.UserName.ToString();
                        label21.Text = Laundry1.User.Address.ToString();*/
                        listBox.Items.Add(shirt.Shirt_List(shirt));
                        break;
                    }
                }
                foreach (PANT pant in Laundry1.pants)
                {
                    if (pant.orderID == orderID)
                    {
                        flag = true;
                        label18.Text = pant.Current_Stat.ToString();
                        label19.Text = Laundry1.total_cost.ToString();
                        label20.Text = user.UserName.ToString();
                        label21.Text = user.Address.ToString();
                        listBox.Items.Add(pant.Pant_List(pant));
                        break;
                    }
                }
                
                foreach (SUIT suit in Laundry1.suits)
                {
                    if (suit.orderID == orderID)
                    {
                        listBox.Items.Add(suit.Suit_List(suit));
                        break;
                    }

                }
            }
            if (flag == false)
            {
                MessageBox.Show("Invalid Id");
            }
        }
    }
         
}
