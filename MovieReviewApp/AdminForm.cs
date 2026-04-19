using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class AdminUsers : Form
    {
        public AdminUsers()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = new List<User>(Program.AllUsers);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            User selected = (User)dgvUsers.CurrentRow.DataBoundItem;

            DialogResult result = MessageBox.Show(
                "Lock " + selected.Username + "?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                selected.IsLocked = true;
                LoadUsers();
                MessageBox.Show("User locked.");
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            User selected = (User)dgvUsers.CurrentRow.DataBoundItem;
            selected.IsLocked = false;
            LoadUsers();
            MessageBox.Show("User unlocked.");
        }

        private void btnViewMovies_Click(object sender, EventArgs e)
        {
            MoviesForm moviesForm = new MoviesForm();
            moviesForm.Show();
        }
    }
}