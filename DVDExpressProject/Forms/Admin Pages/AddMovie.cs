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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Movie> Movies = db.GetTable<Movie>();

            var getMovieID =
                from movie in Movies
                orderby movie.MovieID descending
                select movie.MovieID;

            int newMovieID = getMovieID.First() +1;

            Movie newMovie = new Movie
            {
                MovieID = newMovieID,
                Title = TitleBox.Text,
                Genre = GenreBox.Text,
                ReleaseDate = ReleaseDateBox.Value,
                RunTime = RuntimeBox.Text,
                Rating = RatingBox.Text,
                DaysForRent = 14
            };
            db.Movies.InsertOnSubmit(newMovie);
            db.SubmitChanges();
            MessageBox.Show("New Movie Added!");
        }
    }
}
