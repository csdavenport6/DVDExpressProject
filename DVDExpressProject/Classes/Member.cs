using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDExpressProject.DataLayer;

namespace DVDExpressProject.Classes
{   //derive from account class
    public class Member
    {
        //members and properties
        //------------------------

        public int MemID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int ZIP { get; set; }
        public string Phone { get; set; }
        public string MemStatus { get; set; }
        public int CreditCardNo { get; set; }
        public double Balance { get; set; }



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
