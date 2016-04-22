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
    public partial class DeleteMovie : Form
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Movie> Movies = db.GetTable<Movie>();

            int MovieID;
            int.TryParse(MovieIDBox.Text, out MovieID);

            var getMovieDelete =
                from movie in Movies
                where movie.MovieID == MovieID
                select movie;

            foreach(Movie movie in getMovieDelete)
            {
                db.Movies.DeleteOnSubmit(movie);
            }

            db.SubmitChanges();
            MessageBox.Show("Movie Deleted.");
            MovieIDBox.Clear();
        }
    }
}
