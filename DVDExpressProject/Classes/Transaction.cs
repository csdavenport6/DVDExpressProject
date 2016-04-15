using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDExpressProject.Classes
{
    public class Transaction
    {
        //members and properties
        //------------------------
        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public int MovieID { get; set; }
        public int RewardID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public double Total { get; set; }
        //methods
        //------------------------
    }
}
