using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
            LoadGenres();
        }
        private void LoadGenres()
        {
            cmbGenre.Items.AddRange(new string[]
            {
                "Action", "Comedy", "Drama", "Horror", "Sci-Fi",
                "Romance", "Thriller", "Animation", "Documentary", "Fantasy"
            });
            cmbGenre.SelectedIndex = 0;
        }
        private void AddMovie_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string genre = cmbGenre.SelectedItem.ToString();
            int year;

            if (string.IsNullOrEmpty(title) || !int.TryParse(txtYear.Text.Trim(), out year))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Validation Error");
                return;
            }

            Movie newMovie = new Movie();
            newMovie.MovieId = Program.CurrentUser.Movies.Count + 1;
            newMovie.Title = title;
            newMovie.Year = year;
            newMovie.Genre = genre;

            Program.CurrentUser.Movies.Add(newMovie);
            MessageBox.Show("Movie added!");
            this.Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
