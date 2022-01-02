using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Management_System_Final
{
    public class PANT:ORDER
    {
        public int pants_wash = 10;
        public int pants_iron = 5;
        public double pants;
        public double pantcalc(int orderID, int quantity, string pant)
        {
           
            this.orderID = orderID;
            this.quantity = quantity;
            this.ToDo = pant;
            if (pant == "Wash")
            {
                pants = quantity * pants_wash;
            }
            else if (pant == "Iron")
            {
                pants = quantity * pants_iron;
            }
            else
            {
                pants = quantity * (pants_iron + pants_wash);
            }

            return pants;
        }
        
        public string Pant_List(PANT pant)
        {
            return "Pant " + "\t" + pant.quantity.ToString() + "\t" + pant.ToDo.ToString() + "\t" + pants.ToString();
        }

        public PANT()
        {

        }

        
    }
}
