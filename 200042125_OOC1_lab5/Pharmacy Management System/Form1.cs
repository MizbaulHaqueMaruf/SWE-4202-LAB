using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        List<MEDICINE> medicineList = new List<MEDICINE>();

        int total_value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addMedicineButton_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            string company = companyTxt.Text;
            int quantity = Convert.ToInt32(quantityTxt.Text);
            int price = Convert.ToInt32(priceTxt.Text);

            MEDICINE temp = new MEDICINE(name, company, quantity, price);


            medicineList.Add(temp);
            MessageBox.Show("Medicine Added Successfully");
        }

        public void addSalesButton_Click(object sender, EventArgs e)
        {
            string nameSell = nameSellTxt.Text;
            int quantitySell = Convert.ToInt32(quantitySellTxt.Text);

            bool med_exists = false;
            for (int i = 0; i < medicineList.Count; i++)
            {
                if (nameSell == medicineList[i].name)
                {
                    medicineList[i].sold(quantitySell);
                    total_value=total_value+medicineList[i].price * quantitySell;
                    med_exists = true;
                    MessageBox.Show("Medicine Sold Successfully.");


                }
            }
            if (!med_exists)
            {
                MessageBox.Show("Medicine Not Available.");
            }




        }

        private void showStatusButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i < medicineList.Count; i++)
            {

                listBox.Items.Add(medicineList[i].GetInfo()+Convert.ToString(total_value));
            }
        }
    }
}
