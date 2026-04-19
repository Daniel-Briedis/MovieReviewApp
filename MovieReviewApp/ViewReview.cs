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
    public partial class ViewReview : Form
    {
        private Movie _movie;
        public ViewReview(Movie movie)
        {
            InitializeComponent();
            _movie = movie;
            LoadMovie();
        }
        private void LoadMovie()
        {
            lblTitle.Text = _movie.Title;
            lblYear.Text = _movie.Year.ToString();
            lblGenre.Text = _movie.Genre;
            lblRating.Text = "★" + _movie.StarRating.ToString();
            txtReview.Text = string.IsNullOrEmpty(_movie.ReviewText) ? "No review written yet." : _movie.ReviewText;
        }
        private void ViewReview_Load(object sender, EventArgs e)
        {

        }
    }
}
