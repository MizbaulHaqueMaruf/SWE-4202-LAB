using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;

            checkWinner();
            
        }
        private void checkWinner()
        {
            bool winner = false;

            if((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
            {
                winner = true;
            }
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
            {
                winner = true;
            }
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
            {
                winner = true;
            }


            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
            {
                winner = true;
            }
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
            {
                winner = true;
            }


            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
            {
                winner = true;
            }
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
            {
                winner = true;
            }
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
            {
                winner = true;
            }

            if (winner)
            {
                disable();
                String win = "";
                if(turn)
                {
                    win = "O";
                }
                else
                {
                    win = "X";
                }
                MessageBox.Show(win + " WINS!");
            }
            else
            {
                if(turnCount == 9)
                {
                    MessageBox.Show("DRAW!");
                }
            }
        }

        private void disable()
        {
            foreach(Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { };
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = true;
                b.Text = "";
            }
        }

        private void rESETToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
