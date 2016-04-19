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
    public partial class _M_Search : Form
    {
        private _M_AccountInfo mAccInfo;

        public _M_AccountInfo MAccInfo
        {
            get { return mAccInfo; }
            set { mAccInfo = value; }
        }

        public _M_Search()
        {
            InitializeComponent();
        }

        private void _M_Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's2T5DataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.s2T5DataSet.Movie);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            _M_Search search = new _M_Search();
            search.Show();
            this.Hide();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            _M_BrowseMovies browse = new _M_BrowseMovies();
            browse.Show();
            this.Hide();
        }

        private void ViewCartButton_Click(object sender, EventArgs e)
        {
            _M_ViewCart cart = new _M_ViewCart();
            cart.Show();
            this.Hide();
        }

        private void ViewWishlistButton_Click(object sender, EventArgs e)
        {
            _M_ViewWishlists wishlist = new _M_ViewWishlists();
            wishlist.Show();
            this.Hide();
        }

        private void ViewAcctButton_Click(object sender, EventArgs e)
        {
            _M_AccountInfo account = new _M_AccountInfo();
            account.Show();
            this.Hide();
        }
    }
}
