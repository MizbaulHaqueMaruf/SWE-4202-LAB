using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Enrollment
{
    public class COURSE
    {
        public string title;
        public string level;
        public double fee;

        /* public string std ;
         public string crs ;
         public string date;*/


        public COURSE(string title, string level, double fee)
        {
            this.title = title;
            this.level = level;
            this.fee = fee;
        }

        /*public COURSE(string std, string crs, string date)
        {
            this.std = std;
            this.crs = crs;
            this.date = date;
        }*/
       
        public COURSE()
        {

        }
    }
}
