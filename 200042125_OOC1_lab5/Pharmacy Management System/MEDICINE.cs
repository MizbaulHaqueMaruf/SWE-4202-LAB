using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class MEDICINE
    {
        public string name;
        public string company;
        public int quantity;
        public int price;

        public MEDICINE(string name, string company, int quantity, int price)
        {
            this.name = name;
            this.company = company;
            this.quantity = quantity;
            this.price = price;
        }

     
        /*public int total(int quantitySell)
        {
            return price * quantitySell;
        }*/

        public string GetInfo()
        {
            return name + "\t\t" + company + "\t\t" + Convert.ToString(quantity) +"\t\t";
        }

        public void sold(int quantitySell)
        {
            quantity = quantity - quantitySell;
        }

        

    }
}
