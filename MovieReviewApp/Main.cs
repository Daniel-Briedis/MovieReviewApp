using System;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadOtherUsers();
        }

        private void LoadOtherUsers()
        {
            lbOtherPf.Items.Clear();
            foreach (var user in Program.AllUsers)
            {
                if (user.UserId != Program.CurrentUser.UserId)
                    lbOtherPf.Items.Add(user.Username);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.CurrentUser = null;
            var login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void btnProfle_Click(object sender, EventArgs e)
        {
            var profile = new ViewProfile();
            profile.ShowDialog();
        }

        private void btnEditPf_Click(object sender, EventArgs e)
        {
            var edit = new EditProfile();
            edit.ShowDialog();
        }

        private void lbOtherPf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbOtherPf.SelectedItem == null) return;

            string selectedUsername = lbOtherPf.SelectedItem.ToString();
            User target = Program.AllUsers.Find(u => u.Username == selectedUsername);

            if (target != null)
            {
                var profile = new ViewProfile(target);
                profile.ShowDialog();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddMovie().ShowDialog();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            new AddEditReview().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new MoviesForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminUsers().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MoviesForm().ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Program.CurrentUser = null;
            new LoginForm().ShowDialog();
            this.Close();
        }
    }
}