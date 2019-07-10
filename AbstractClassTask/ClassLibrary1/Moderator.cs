using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Moderator : User
    {
        public List<User> Users { get; set; }

        public Moderator()
        {
            List<User> Users = new List<User>();
            role = Role.Moderator;
        }

        public void BanUser(string Username, string reason)
        {
            Console.WriteLine($"The user {Username} is banned for {reason}" ); 
        }

        public override void PrintUser()
        {
            Console.WriteLine($"{UserName}'s role is {role}");
        }
    }
}
