using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry_Management_System_Final
{
    public class USER
    {
        public int UserID;
        public string UserName;
        public string Address;
        

        public USER(int ID, string Name, string address)
        {
            this.UserID = ID;
            this.UserName = Name;
            this.Address = address;
        }
        public USER()
        {

        }
    }
}
