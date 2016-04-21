using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDExpressProject.Forms.Member_Pages
{
    public partial class _M_ViewCart : Form
    {
        public Member userAccount { get; set; }
        private _M_AccountInfo mAccInfo;

        public _M_AccountInfo MAccInfo
        {
            get { return mAccInfo; }
            set { mAccInfo = value; }
        }
        public _M_ViewCart()
        {
            InitializeComponent();
        }

        private void _M_ViewCart_Load(object sender, EventArgs e)
        {

        }

        //Search
        private void button4_Click(object sender, EventArgs e)
        {
            _M_Search search = new _M_Search();
            search.userAccount = this.userAccount;
            search.Show();
            this.Hide();
        }

        //Browse
        private void button5_Click(object sender, EventArgs e)
        {
            _M_BrowseMovies browse = new _M_BrowseMovies();
            browse.userAccount = this.userAccount;
            browse.Show();
            this.Hide();
        }

        //Wishlist
        private void button2_Click(object sender, EventArgs e)
        {
            _M_ViewWishlists wishlist = new _M_ViewWishlists();
            wishlist.userAccount = this.userAccount;
            wishlist.Show();
            this.Hide();
        }

        //Wishlist
        private void button3_Click(object sender, EventArgs e)
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
            MessageBox.Show("This form allows the user to view and manager their cart.");
        }
    }
}
