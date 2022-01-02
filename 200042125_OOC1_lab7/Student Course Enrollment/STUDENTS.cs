using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    public class STUDENTS:PARTICIPANTS
    {
        public STUDENTS(string name, string reg, string contact, string email, string type, string level)
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
            return fee;
        }

        public string StudInfo(STUDENTS std)
        {
            foreach (COURSE course in std.courseList)
            {
                return course.title +  "\t" + course.level + "\t" + "\t" + std.totalPay.ToString() + "\t" + "\t" + std.date;
            }
            return null;
        }
        public STUDENTS()
        {

        }
    }
}
