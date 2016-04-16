using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDExpressProject.Classes
{
    public class Movie
    {
        //members and properties
        //------------------------
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string MovieGenre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double RunTime { get; set; }
        public int AvgRating { get; set; }
        //methods
        //------------------------
    }
}