using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDExpressProject.Forms.Member_Pages
{
    public partial class _M_ViewWishlists : Form
    {
        public Member userAccount { get; set; }
        private _M_AccountInfo mAccInfo;

        public _M_AccountInfo MAccInfo
        {
            get { return mAccInfo; }
            set { mAccInfo = value; }
        }
        public _M_ViewWishlists()
        {
            InitializeComponent();
        }

        private void _M_ViewWishlists_Load(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Wishlist> Wishlists = db.GetTable<Wishlist>();
            Table<Movie> MoviesInWishlist = db.GetTable<Movie>();

            var matchWishlists =
                from wishlist in Wishlists
                where wishlist.MemberID == userAccount.MemberID
                select wishlist;

            List<string> userWishlists = new List<string>();

            foreach (Wishlist wishlist in matchWishlists)
            {
                userWishlists.Add(wishlist.Title);
            }
            WishlistBox.DataSource = userWishlists;
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

        //Cart
        private void button1_Click(object sender, EventArgs e)
        {
            _M_ViewCart cart = new _M_ViewCart();
            cart.userAccount = this.userAccount;
            cart.Show();
            this.Hide();
        }

        //account
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
            MessageBox.Show("This form allows the user to view and manage their wishlists.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WishlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Wishlist> Wishlists = db.GetTable<Wishlist>();
            Table<Movie> Movies = db.GetTable<Movie>();

            var getCorrectWishlist =
                from wishlist in Wishlists
                where wishlist.Title == WishlistBox.SelectedItem
                select wishlist;

            DataTable MoviesInWishlist = new DataTable();
            MoviesInWishlist.Columns.Add("Title");
            MoviesInWishlist.Columns.Add("Genre");
            MoviesInWishlist.Columns.Add("Run Time");
            MoviesInWishlist.Columns.Add("Rating");

            foreach (Wishlist wishlist in getCorrectWishlist)
            {
                var getCorrectMovies =
                    from movie in Movies
                    where movie.MovieID == wishlist.MovieID
                    select movie;
                foreach (Movie movie in getCorrectMovies)
                {
                    MoviesInWishlist.Rows.Add(movie.Title, movie.Genre, movie.RunTime, movie.Rating);
                }                    
            }
            WishlistView.DataSource = MoviesInWishlist;
        }

        private void AddWishlist_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Wishlist> Wishlists = db.GetTable<Wishlist>();

            var getNextWishlistID =
                from wishlist in Wishlists
                orderby wishlist.WishlistID descending
                select wishlist.WishlistID;

            int newWishlistID = getNextWishlistID.First() + 1;

            if (!NewWishlistName.Text.Any())
            {
                MessageBox.Show("Error: Please enter a name for your new wishlist.");
                return;
            }

            Wishlist newWishlist = new Wishlist
            {
                WishlistID = newWishlistID,
                MovieID = null,
                Title = NewWishlistName.Text,
                MemberID = userAccount.MemberID
            };
            db.Wishlists.InsertOnSubmit(newWishlist);
            db.SubmitChanges();
            MessageBox.Show("New Wishlist Created!");
        }
    }
}
