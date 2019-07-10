using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise:
            /*Create a user class that has:
            Username
            Role - Guest, Moderator, Poster
            Comments - list of strings
            PostComment(method ) - accepts a comment and adds it to the Comments list
            PrintUser( abstract method ) - prints all details of a user
            Note : You can't create a user object

            Create a class Poster that has:
            Points
            IsPosterOfTheWeek
            CheckStats(method ) - prints a message how many points and comments this user has
            Has default Role of Poster

            Create a Guest class that has:
            Id
            ReadComment(method ) - accepts string and writes in the console: The Guest with Id: Id read this comment: Comment
            If guest tries to post, it should show a message: Guests cannot post
            Has default Role of Guest
            Create Moderator class that has:

            Users - list of users
            BanUser(Method ) - accepts a user and a string REASON and writes in the console: The user Username is banned for REASON
            Has default Role of Moderator */

            //List<User> Users = new List<User>();
            var Users = new List<User>();
            var comento = new List<string>();
        Guest Kristina = new Guest();
            Kristina.UserName = "kika9909";
            Kristina.Id = 3;
            Kristina.PostComments("lelele");
            Kristina.ReadComments("helloy guys anyone knows JavaScript?");
            //-------------------------------------------------
            Guest Martina = new Guest();
            Martina.UserName = "miliii9909";
            Martina.Id = 31;
            Martina.PostComments("lelele");
            Martina.ReadComments("helloy guys anyone knows CSS && c#?");
            //------------------------------------------------
            Moderator Stevo = new Moderator();
            Stevo.UserName = "Svevislav";
            List<string> Comments = new List<string>();
            Stevo.PostComments("Don't be rude!");
            Stevo.PostComments("Guys please be careful while you communicate between!");
            Stevo.BanUser("kika9909", "being clumsy");
            //-------------------------------------------------
            Poster Venko = new Poster(22, false);
            Venko.UserName = "Vencislav";
            Venko.CheckStats();
            Poster Marko = new Poster(10, true);
            Marko.UserName = "Marko";
            Marko.CheckStats();
            Marko.PrintUser();

            foreach (var item in Users)
            {
                Console.WriteLine(item);
            }





        }
    }
}
