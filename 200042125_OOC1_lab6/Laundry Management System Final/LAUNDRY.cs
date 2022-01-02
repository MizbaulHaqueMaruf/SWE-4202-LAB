using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Management_System_Final
{
    public class LAUNDRY
    {
        public List<USER> users = new List<USER>();
        public List<PANT> pants = new List<PANT>();
        public List<SHIRT> shirts = new List<SHIRT>();
        public List<SUIT> suits = new List<SUIT>();

        public USER user = new USER();
        public SHIRT shirt1 = new SHIRT();
        public PANT pant = new PANT();
        public SUIT suit = new SUIT();
        
        

        public static int prev_order = 0;
       /* public double shirt_cost;
        public double pant_cost;
        public double suit_cost;*/
        public double total_cost;

        static public int GenerateOrderID()
        {
            return prev_order++;
        }
        public bool order_shirt(int UserID, int quantity, int orderID, string shirt_TO_DO)
        {
            bool flag = false;
            foreach (USER user in users)
            {
                if (user.UserID == UserID)
                {
                    shirt1.shirts_cost = shirt1.shirtcalc(orderID, quantity, shirt_TO_DO);
                    shirts.Add(shirt1);
                    flag = true;
                    break;
                }
            }
            return flag;

            
        }
        public bool order_pant(int UserID, int quantity, int orderID, string pant_TO_DO)
        {
            bool flag = false;
            foreach (USER user in users)
            {
                if (user.UserID == UserID)
                {
                    pant.pants = pant.pantcalc(orderID, quantity, pant_TO_DO);
                    pants.Add(pant);
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        
        public bool order_suit(int UserID, int quantity, int orderID, string suit_TO_DO)
        {
            bool flag = false;
            foreach (USER user in users)
            {
                if (user.UserID == UserID)
                {
                    suit.suits = suit.suitcalc(orderID, quantity, suit_TO_DO);
                    suits.Add(suit);
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public void OrderSituation(int orderid, string OrderStatus)
        {
            foreach (USER user in users)
            {
                /*foreach (SHIRT shirt in shirts)
                {
                    if (shirt.orderID == orderid)
                    {
                        shirt.Current_Stat = OrderStatus;
                        break;
                    }
                }*/
                foreach (PANT pant in pants)
                {
                    if (pant.orderID == orderid)
                    {
                        pant.Current_Stat = OrderStatus;
                        break;
                    }
                }
                
               /* foreach (SUIT suit in suits)
                {
                    if (suit.orderID == orderid)
                    {
                        suit.Current_Stat = OrderStatus;
                        break;
                    }
                }*/
            }
        }

        public double LaundryCalcTotal(int orderID)
        {
            foreach (PANT pantv in pants)
            {
                if (pantv.orderID == orderID)
                {
                    total_cost = shirt1.shirts_cost + pant.pants + suit.suits;
                    break;
                }

            }
            return total_cost;
        }
       
    }
}
