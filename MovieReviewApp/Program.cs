using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewApp
{
    internal static class Program
    {
        public static List<User> AllUsers = new List<User>();
        public static User CurrentUser = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User admin = new User();
            admin.UserId = 1;
            admin.Username = "Admin";
            admin.Password = "admin123";
            admin.IsAdmin = true;

            User daniel = new User();
            daniel.UserId = 2;
            daniel.Username = "Daniel";
            daniel.Password = "pass123";

            Movie m1 = new Movie();
            m1.MovieId = 1;
            m1.Title = "Inception";
            m1.Year = 2010;
            m1.Genre = "Sci-Fi";
            m1.ReviewText = "Mind blowing.";
            m1.StarRating = 5;

            daniel.Movies.Add(m1);

            AllUsers.Add(admin);
            AllUsers.Add(daniel);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
