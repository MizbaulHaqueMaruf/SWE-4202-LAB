using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    public class PARTICIPANTS
    {
        public string name;
        public string reg;
        public string contact;
        public string email;
        public string type;
        public string level;
        public string date;
        public double totalPay;

        public List<COURSE> courseList = new List<COURSE>();
        public virtual double FeesPayable(double fee)
        {
            double total = (fee + 0.1 * fee);
            return total;
        }


        /*public PARTICIPANTS(string name, int reg, string contact, string email, string type, string level)
        {
            this.name = name;
            this.reg = reg;
            this.contact = contact;
            this.email = email;
            this.type = type;
            this.level = level;
        }

        public string GetInfo()
        {
            return name + "\t" + contact + "\t" + Convert.ToString(reg) + "\t"  + type + "\t" + level;
        }*/


    }
}
