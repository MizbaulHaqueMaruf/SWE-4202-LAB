using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    internal class Enrolled
    {
        public string std;
        public string crs;
        public string date;

        public Enrolled(string std, string crs, string date)
        {
            this.std = std;
            this.crs = crs;
            this.date = date;
        }
    }
}
