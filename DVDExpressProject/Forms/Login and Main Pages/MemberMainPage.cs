using DVDExpressProject.Forms.Member_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDExpressProject.Forms
{
    public partial class MemberMainPage : Form
    {
        public Member userAccount { get; set; }
        public MemberMainPage()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _M_Search search = new _M_Search();
            search.userAccount = this.userAccount;
            search.Show();
            this.Hide();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            _M_BrowseMovies browse = new _M_BrowseMovies();
            browse.userAccount = this.userAccount;
            browse.Show();
            this.Hide();
        }

        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            _M_ViewCart cart = new _M_ViewCart();
            cart.userAccount = this.userAccount;
            cart.Show();
            this.Hide();
        }

        private void ViewWishlistButton_Click(object sender, EventArgs e)
        {
            _M_ViewWishlists wishlist = new _M_ViewWishlists();
            wishlist.userAccount = this.userAccount;
            wishlist.Show();
            this.Hide();
        }

        private void ViewAcctButton_Click(object sender, EventArgs e)
        {
            _M_AccountInfo account = new _M_AccountInfo();
            account.userAccount = this.userAccount;
            account.Show();
            this.Hide();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to DVDExpress. Created by Connor, Bobby, Joseph, and James.");
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form is the main page members see when they login. From here they can go to any of the other various forms.");
        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userAccount.FirstName + ' ' + userAccount.LastName);
        }
    }
}
