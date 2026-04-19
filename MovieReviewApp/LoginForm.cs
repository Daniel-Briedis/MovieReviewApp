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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User found = null;
            foreach (User u in Program.AllUsers)
            {
                if (u.Username.ToLower() == txtUser.Text.Trim().ToLower() && u.Password == txtPass.Text)
                {
                    found = u;
                    break;
                }
            }

            if (found == null)
            {
                MessageBox.Show("Invalid username or password.");
                return;
            }

            if (found.IsLocked)
            {
                MessageBox.Show("Your account is locked.");
                return;
            }

            Program.CurrentUser = found;
            new Main().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
