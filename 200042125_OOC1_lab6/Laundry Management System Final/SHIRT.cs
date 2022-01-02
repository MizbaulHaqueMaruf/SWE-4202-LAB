using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Management_System_Final
{
    public class SHIRT:ORDER
    {
        public int shirts_wash = 15;
        public int shirts_iron = 7;
        public double shirts_cost;
        public double shirtcalc(int orderID, int quantity, string shirtToDo)
        {

            this.orderID = orderID;
            this.quantity = quantity;
            this.ToDo = shirtToDo;
            if (shirtToDo == "Wash")
            {
                shirts_cost = quantity * shirts_wash;

            }
            else if (shirtToDo == "Iron")
            {
                shirts_cost = quantity * shirts_iron;
            }
            else
            {
                shirts_cost = quantity * (shirts_iron + shirts_wash);
            }

            return shirts_cost;
        }
        public string Shirt_List(SHIRT shirt)
        {
            return "Shirt " + "\t" + shirt.quantity.ToString() + "\t" + shirt.ToDo.ToString() + "\t" + shirts_cost.ToString();
        }
        public SHIRT()
        {

        }


       
    }
}
