using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
       /* Create a class Poster that has:
        Points
        IsPosterOfTheWeek
        CheckStats(method ) - prints a message how many points and comments this user has
        Has default Role of Poster */
    public class Poster : User
    {
        public int Points { get; set; }
        public bool IsPosterOfTheWeek { get; set; }

        public Poster(int points, bool posterOfweek)
        {
            Points = points;
            IsPosterOfTheWeek = posterOfweek;
            role = Role.Poster;
        }

        public void CheckStats()
        {
            if (IsPosterOfTheWeek)
            {
                Console.WriteLine("This user is poster of the week");
            }
            Console.WriteLine($"The user {UserName} has {Points} points ");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"{UserName} has {Points} points and his role is {role}");
        }



    }
}
