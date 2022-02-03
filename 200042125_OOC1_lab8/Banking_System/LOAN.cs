using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class LOAN:ACCOUNT
    {
        public List<LOAN> loanList = new List<LOAN>();
        public LOAN(string name, string accNum, double amount, string date)
        {
            this.name = name;
            this.accNum = accNum;
            this.amount = amount;
            this.date = date;
        }

        public LOAN()
        {

        }
    }
}
