using System;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
            LoadCurrentValues();
        }

        private void LoadCurrentValues()
        {
            txtUsername.Text = Program.CurrentUser.Username;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();

            if (string.IsNullOrEmpty(newUsername))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool taken = Program.AllUsers.Exists(u =>
                u.Username == newUsername && u.UserId != Program.CurrentUser.UserId);

            if (taken)
            {
                MessageBox.Show("That username is already taken.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Program.CurrentUser.Username = newUsername;

            MessageBox.Show("Profile updated!", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // ignore
        }
    }
}