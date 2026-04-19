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

            Movie d2 = new Movie();
            d2.MovieId = 2;
            d2.Title = "The Dark Knight";
            d2.Year = 2008;
            d2.Genre = "Action";
            d2.ReviewText = "Heath Ledger is unreal in this.";
            d2.StarRating = 5;
            daniel.Movies.Add(d2);

            Movie d3 = new Movie();
            d3.MovieId = 3;
            d3.Title = "Tenet";
            d3.Year = 2020;
            d3.Genre = "Sci-Fi";
            d3.ReviewText = "Had to watch it twice to get it.";
            d3.StarRating = 4;
            daniel.Movies.Add(d3);

            
            User abraham = new User();
            abraham.UserId = 3;
            abraham.Username = "Abraham";
            abraham.Password = "pass123";

            Movie a1 = new Movie();
            a1.MovieId = 4;
            a1.Title = "The Godfather";
            a1.Year = 1972;
            a1.Genre = "Crime";
            a1.ReviewText = "The best film ever made.";
            a1.StarRating = 5;
            abraham.Movies.Add(a1);

            Movie a2 = new Movie();
            a2.MovieId = 5;
            a2.Title = "Goodfellas";
            a2.Year = 1990;
            a2.Genre = "Crime";
            a2.ReviewText = "Scorsese at his peak.";
            a2.StarRating = 5;
            abraham.Movies.Add(a2);

           
            User sarah = new User();
            sarah.UserId = 4;
            sarah.Username = "Sarah";
            sarah.Password = "pass123";

            Movie s1 = new Movie();
            s1.MovieId = 6;
            s1.Title = "La La Land";
            s1.Year = 2016;
            s1.Genre = "Romance";
            s1.ReviewText = "Beautiful music and visuals.";
            s1.StarRating = 4;
            sarah.Movies.Add(s1);

            Movie s2 = new Movie();
            s2.MovieId = 7;
            s2.Title = "The Notebook";
            s2.Year = 2004;
            s2.Genre = "Romance";
            s2.ReviewText = "Cried the whole way through.";
            s2.StarRating = 5;
            sarah.Movies.Add(s2);

            Movie s3 = new Movie();
            s3.MovieId = 8;
            s3.Title = "Parasite";
            s3.Year = 2019;
            s3.Genre = "Thriller";
            s3.ReviewText = "Deserved every Oscar.";
            s3.StarRating = 5;
            sarah.Movies.Add(s3);

           
            User jake = new User();
            jake.UserId = 5;
            jake.Username = "Jake";
            jake.Password = "pass123";

            Movie j1 = new Movie();
            j1.MovieId = 9;
            j1.Title = "Heat";
            j1.Year = 1995;
            j1.Genre = "Crime";
            j1.ReviewText = "The diner scene is legendary.";
            j1.StarRating = 5;
            jake.Movies.Add(j1);

            Movie j2 = new Movie();
            j2.MovieId = 10;
            j2.Title = "Interstellar";
            j2.Year = 2014;
            j2.Genre = "Sci-Fi";
            j2.ReviewText = "The music alone carries it.";
            j2.StarRating = 5;
            jake.Movies.Add(j2);

            
            User megan = new User();
            megan.UserId = 6;
            megan.Username = "Megan";
            megan.Password = "pass123";
            megan.IsLocked = true;

            Movie me1 = new Movie();
            me1.MovieId = 11;
            me1.Title = "The Room";
            me1.Year = 2003;
            me1.Genre = "Drama";
            me1.ReviewText = "So bad it's good.";
            me1.StarRating = 1;
            megan.Movies.Add(me1);

           
            User tom = new User();
            tom.UserId = 7;
            tom.Username = "Tom";
            tom.Password = "pass123";

            Movie t1 = new Movie();
            t1.MovieId = 12;
            t1.Title = "Dune";
            t1.Year = 2021;
            t1.Genre = "Sci-Fi";
            tom.Movies.Add(t1);

            AllUsers.Add(admin);
            AllUsers.Add(daniel);
            AllUsers.Add(abraham);
            AllUsers.Add(sarah);
            AllUsers.Add(jake);
            AllUsers.Add(megan);
            AllUsers.Add(tom);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
