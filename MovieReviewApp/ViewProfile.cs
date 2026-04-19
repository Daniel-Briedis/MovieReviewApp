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

            lbMovies.Items.Clear();
            foreach (var movie in _user.Movies)
                lbMovies.Items.Add($"{movie.Title} ({movie.Year}) - {movie.Genre} ★{movie.StarRating}");

            btnRemove.Visible = (_user.UserId == Program.CurrentUser.UserId);
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
        private void lbMovies_DoubleClick(object sender, EventArgs e)
        {
            if (lbMovies.SelectedItem == null) return;

            string selected = lbMovies.SelectedItem.ToString();
            string title = selected.Split('(')[0].Trim();

            Movie movie = _user.Movies.Find(m => m.Title == title);
            if (movie != null)
            {
                new ViewReview(movie).ShowDialog();
            }
        }
        private void ViewProfile_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbMovies.SelectedItem == null)
            {
                MessageBox.Show("Select a movie to remove.");
                return;
            }

            string selected = lbMovies.SelectedItem.ToString();
            string title = selected.Split('(')[0].Trim();

            DialogResult confirm = MessageBox.Show($"Remove '{title}'?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Program.CurrentUser.Movies.RemoveAll(m => m.Title == title);
                LoadProfile();
            }
        }
    }
}