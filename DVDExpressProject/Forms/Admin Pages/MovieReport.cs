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

namespace DVDExpressProject.Forms.Admin_Pages
{
    public partial class MovieReport : Form
    {
        public MovieReport()
        {
            InitializeComponent();
        }

        private void MovieList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MovieReport_Load(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Movie> Movies = db.GetTable<Movie>();

            var getAllMovies =
                from movie in Movies
                select movie;

            DataTable movieList = new DataTable();
            movieList.Columns.Add("Movie ID");
            movieList.Columns.Add("Title");
            movieList.Columns.Add("Genre");
            movieList.Columns.Add("Release Date");
            movieList.Columns.Add("Run Time");
            movieList.Columns.Add("Rating");
            movieList.Columns.Add("Days For Rent");

            foreach (Movie movie in getAllMovies)
            {
                movieList.Rows.Add(movie.MovieID, movie.Title, movie.Genre, movie.ReleaseDate, movie.RunTime, movie.Rating, movie.DaysForRent);
            }
            MovieList.DataSource = movieList;
        }

        //private void MovieList_CellContentClick(object sender, EventArgs e)
        //{
        //    DVDExpressDataContext db = new DVDExpressDataContext();
        //    Table<Movie> Movies = db.GetTable<Movie>();

        //    var getAllMovies =
        //        from movie in Movies
        //        select movie;

        //    DataTable movieList = new DataTable();
        //    movieList.Columns.Add("Movie ID");
        //    movieList.Columns.Add("Title");
        //    movieList.Columns.Add("Genre");
        //    movieList.Columns.Add("Release Date");
        //    movieList.Columns.Add("Run Time");
        //    movieList.Columns.Add("Rating");
        //    movieList.Columns.Add("Days For Rent");

        //    foreach (Movie movie in getAllMovies)
        //    {
        //        movieList.Rows.Add(movie.MovieID, movie.Title, movie.Genre, movie.ReleaseDate, movie.RunTime, movie.Rating, movie.DaysForRent);
        //    }
        //    MovieList.DataSource = movieList;
        //}

        
    }
}
