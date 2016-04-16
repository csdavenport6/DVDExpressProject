using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDExpressProject.Classes
{   //derive from account class
    public class Member : Account
    {
        //members and properties
        //------------------------
        public string MemStatus { get; set; }
        public int CreditCardNo { get; set; }
        public double Balance { get; set; }
        public string FirstName { get; set; }
        public string LastNames { get; set; }
        public DateTime DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int ZIP { get; set; }
        public string Phone { get; set; }




        //methods
        //------------------------
        public void SelectWishlist(int wishlistID) //this might be consolodated with UpdateWishlist() method
        {


        }
        public void RemoveWishlist()
        {


        }
        public void UpdateWishlist()
        {

        }
        public void AddReview()
        {

        }
    }



}
