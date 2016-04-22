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
    public partial class _M_Search : Form
    {
        public Member userAccount { get; set; }
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
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Wishlist> Wishlists = db.GetTable<Wishlist>();
            Table<Movie> Movies = db.GetTable<Movie>();

            var matchWishlists =
                from wishlist in Wishlists
                where wishlist.MemberID == userAccount.MemberID
                select wishlist;

            List < string > userWishlists = new List<string>();

            foreach (Wishlist wishlist in matchWishlists)
            {
                userWishlists.Add(wishlist.Title);
            }
            WishlistBox.DataSource = userWishlists;
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
            MessageBox.Show("This form allows the user to search movies by name.");
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Movie> Movies = db.GetTable<Movie>();
            string searchText = SearchBox.Text;
            var query =
                from mov in Movies
                where mov.Title.Contains(searchText)
                select mov;


            DataTable SearchedMovies = new DataTable();
            SearchedMovies.Columns.Add("Movie ID");
            SearchedMovies.Columns.Add("Title");
            SearchedMovies.Columns.Add("Genre");
            SearchedMovies.Columns.Add("Run Time");
            SearchedMovies.Columns.Add("Rating");
            SearchedMovies.Columns.Add("Days for rent");
            foreach (var mov in query)
            {
                SearchedMovies.Rows.Add(mov.MovieID, mov.Title, mov.Genre, mov.RunTime, mov.Rating, mov.DaysForRent);
            }
            MovieList.DataSource = SearchedMovies;
        }

        private void AddToWishlist_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Wishlist> Wishlists = db.GetTable<Wishlist>();
            Table<Movie> Movies = db.GetTable<Movie>();

            var getCorrectWishlist =
                from wishlist in Wishlists
                where (wishlist.Title == WishlistBox.SelectedItem && wishlist.MemberID == userAccount.MemberID)
                select wishlist;
            
            var getCorrectMovie =
                from movie in Movies
                where movie.Title == MovieList.SelectedCells[0].Value.ToString()
                select movie;

            foreach(Wishlist wishlist in getCorrectWishlist)
            {
                foreach(Movie movie in getCorrectMovie)
                {
                    wishlist.MovieID = movie.MovieID;
                }
            }
            db.SubmitChanges();
            MessageBox.Show("Movie Added to Wishlist!");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Movie> Movies = db.GetTable<Movie>();
            Table<Transaction> Transactions = db.GetTable<Transaction>();

            var getTransactions =
                from transaction in Transactions
                where (transaction.AccountID == userAccount.AccountID && transaction.RentDate == null)
                select transaction;

            var getTID =
                from transaction in Transactions
                orderby transaction.TransactionID descending
                select transaction.TransactionID;

            int newTID = getTID.First() + 1;

            var getCorrectMovie =
                from movie in Movies
                where movie.Title == MovieList.SelectedCells[0].Value.ToString()
                select movie;

            Transaction newTransaction = new Transaction
            {
                TransactionID = 0,
                AccountID = userAccount.AccountID,
                MovieID = null,
                RewardID = null,
                RentDate = null,
                DueDate = null,
                Total = null
            };

            foreach (Transaction transaction in getTransactions)
            {
                newTransaction.TransactionID = transaction.TransactionID;
                if (!transaction.TransactionID.ToString().Any())
                {
                    newTransaction.TransactionID = newTID;
                }
                foreach(Movie movie in getCorrectMovie)
                {
                    newTransaction.MovieID = movie.MovieID;
                }
            }
            db.Transactions.InsertOnSubmit(newTransaction);
            db.SubmitChanges();
            MessageBox.Show("Movie Added to Cart!");

        }
    }
}
