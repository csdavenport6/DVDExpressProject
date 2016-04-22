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
    public partial class UpdateMovie : Form
    {
        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Movie> Movies = db.GetTable<Movie>();

            int MovieID;
            int.TryParse(MovieIDBox.Text, out MovieID);

            var getMovie =
                from movie in Movies
                where movie.MovieID == MovieID
                select movie;

            foreach (Movie movie in getMovie)
            {
                if (TitleBox.Text.Any())
                    movie.Title = TitleBox.Text;
                if (GenreBox.Text.Any())
                    movie.Genre = GenreBox.Text;
                if (ReleaseDateBox.Text.Any())
                    movie.ReleaseDate = ReleaseDateBox.Value;
                if (RuntimeBox.Text.Any())
                    movie.RunTime = RuntimeBox.Text;
                if (RatingBox.Text.Any())
                    movie.Rating = RatingBox.Text;
            }

            db.SubmitChanges();
            MessageBox.Show("Movie Entry Updated!");
        }
    }
}
