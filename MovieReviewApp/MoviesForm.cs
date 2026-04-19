using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void LoadMovies()
        {
            List<object> allMovies = new List<object>();

            foreach (User user in Program.AllUsers)
            {
                foreach (Movie movie in user.Movies)
                {
                    allMovies.Add(new
                    {
                        MovieId = movie.MovieId,
                        Title = movie.Title,
                        Year = movie.Year,
                        Genre = movie.Genre,
                        StarRating = movie.StarRating,
                        ReviewText = movie.ReviewText,
                        AddedBy = user.Username,
                        OwnerId = user.UserId
                    });
                }
            }

            dgvMovies.DataSource = null;
            dgvMovies.DataSource = allMovies;
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie first.");
                return;
            }

            dynamic selected = dgvMovies.CurrentRow.DataBoundItem;
            int movieId = selected.MovieId;
            int ownerId = selected.OwnerId;
            string title = selected.Title;

            ConfirmDeleteForm confirm = new ConfirmDeleteForm(title);
            if (confirm.ShowDialog() == DialogResult.Yes)
            {
                User owner = Program.AllUsers.Find(u => u.UserId == ownerId);
                if (owner != null)
                {
                    owner.Movies.RemoveAll(m => m.MovieId == movieId);
                }
                LoadMovies();
                MessageBox.Show("Movie deleted.");
            }
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow == null)
            {
                MessageBox.Show("Please select a movie first.");
                return;
            }

            dynamic selected = dgvMovies.CurrentRow.DataBoundItem;
            int movieId = selected.MovieId;
            int ownerId = selected.OwnerId;
            string title = selected.Title;

            DialogResult result = MessageBox.Show(
                "Delete the review for \"" + title + "\"? (The movie will stay)",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                User owner = Program.AllUsers.Find(u => u.UserId == ownerId);
                if (owner != null)
                {
                    Movie movie = owner.Movies.Find(m => m.MovieId == movieId);
                    if (movie != null)
                    {
                        movie.ReviewText = null;
                        movie.StarRating = 0;
                    }
                }
                LoadMovies();
                MessageBox.Show("Review deleted.");
            }
        }
    }
}
