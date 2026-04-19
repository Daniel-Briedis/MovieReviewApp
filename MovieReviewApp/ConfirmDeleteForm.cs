using System;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class ConfirmDeleteForm : Form
    {
        public ConfirmDeleteForm(string movieTitle)
        {
            InitializeComponent();
            lblMessage.Text = "Are you sure you want to delete \"" + movieTitle + "\"?";
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}