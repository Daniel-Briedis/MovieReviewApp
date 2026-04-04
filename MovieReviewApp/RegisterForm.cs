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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            foreach (User u in Program.AllUsers)
            {
                if (u.Username.ToLower() == username.ToLower())
                {
                    MessageBox.Show("That username is already taken.");
                    return;
                }
            }

            User newUser = new User();
            newUser.UserId = Program.AllUsers.Count + 1;
            newUser.Username = username;
            newUser.Password = password;
            newUser.IsAdmin = false;
            newUser.IsLocked = false;

            Program.AllUsers.Add(newUser);
            MessageBox.Show("Account created! You can log in now.");
            new LoginForm().Show();
            this.Close();
        }
    }
}
