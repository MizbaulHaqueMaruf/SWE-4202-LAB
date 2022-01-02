using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Management_System_Final
{
    public class SUIT:ORDER
    {
        public int suits_wash = 25;
        public int suits_iron = 20;
        public double suits;
        public double suitcalc(int orderID, int quantity, string suit)
        {
            
            this.orderID = orderID;
            this.quantity = quantity;
            this.ToDo = suit;
            if (suit == "Wash")
            {
                suits = quantity * suits_wash;
            }
            else if (suit == "Iron")
            {
                suits = quantity * suits_iron;
            }
            else
            {
                suits = quantity * (suits_iron + suits_wash);
            }
            return suits;
        }
       
        public string Suit_List(SUIT suit)
        {
            return "Suit " + "\t" + suit.quantity.ToString() + "\t" + suit.ToDo.ToString() + "\t" + suits.ToString();
        }
        public SUIT()
        {

        }


    }
}
