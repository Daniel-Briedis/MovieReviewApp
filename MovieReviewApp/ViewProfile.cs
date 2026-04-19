using System;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class ViewProfile : Form
    {
        private User _user;

        public ViewProfile() : this(Program.CurrentUser) { }

        public ViewProfile(User user)
        {
            InitializeComponent();
            _user = user;
            LoadProfile();
        }

        private void LoadProfile()
        {
            txtUser.Text = _user.Username;
            txtCounter.Text = _user.Movies.Count.ToString();

            rtbReviewed.Clear();
            foreach (var movie in _user.Movies)
            {
                rtbReviewed.AppendText($"{movie.Title} ({movie.Year}) - {movie.Genre} ★{movie.StarRating}\n");
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            var edit = new EditProfile();
            edit.ShowDialog();
            LoadProfile();
        }

        private void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}