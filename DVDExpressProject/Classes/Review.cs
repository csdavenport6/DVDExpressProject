using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDExpressProject.Classes
{
    public class Review
    {
        //members and properties
        //------------------------
        public int ReviewID { get; set; }
        public int AccountID { get; set; }
        public int MovieID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        //methods
        //------------------------
    }
}
