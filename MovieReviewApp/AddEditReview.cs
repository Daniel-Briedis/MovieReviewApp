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
    public partial class AddEditReview : Form
    {
        public AddEditReview()
        {
            InitializeComponent();
            LoadMovies();
        }
        private void LoadMovies()
        {
            cmbMovies.Items.Clear();

            foreach (var user in Program.AllUsers)
            {
                foreach (var movie in user.Movies)
                {
                    cmbMovies.Items.Add(movie.Title);
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedItem == null)
            {
                MessageBox.Show("Please select a movie.");
                return;
            }

            Movie movie = Program.CurrentUser.Movies.Find(m => m.Title == cmbMovies.SelectedItem.ToString());
            movie.ReviewText = txtReview.Text.Trim();
            movie.StarRating = (double)numRating.Value;

            MessageBox.Show("Review saved!");
            this.Close();
        }

        private void cmbMovies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedItem == null) return;

            Movie movie = Program.CurrentUser.Movies.Find(m => m.Title == cmbMovies.SelectedItem.ToString());

            txtReview.Text = movie.ReviewText;
            numRating.Value = movie.StarRating >= 1 ? (decimal)movie.StarRating : 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
