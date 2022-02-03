using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class ACCOUNT
    {
        public List<string> historyList = new List<string>();

        public string name;
        public string accNum;
        public double amount;
        public string date;
        public static int initialAccNo = 1;

        public int IdGenerator()
        {
            return initialAccNo++;
        }
    }

   
}
