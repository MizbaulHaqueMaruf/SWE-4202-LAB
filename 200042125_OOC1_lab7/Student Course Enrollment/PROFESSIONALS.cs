using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    public class PROFESSIONALS:PARTICIPANTS
    {
        public PROFESSIONALS(string name, string reg, string contact, string email, string type, string level)
        {
            this.name = name;
            this.reg = reg;
            this.contact = contact;
            this.email = email;
            this.type = type;
            this.level = level;
        }

        public override double FeesPayable(double fee)
        {
            double total = (fee + 0.1 * fee);
            return total;
        }

        public string Proinfo(PROFESSIONALS pro)
        {
            foreach (COURSE course in pro.courseList)
            {
                return course.title + "\t" + course.level + "\t" + "\t" + pro.totalPay.ToString() + "\t" + "\t" + pro.date;
            }
            return null;
        }
        public PROFESSIONALS()
        {

        }
    }
}
