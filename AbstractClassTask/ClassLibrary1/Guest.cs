using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Guest : User
    {
        /* Create a Guest class that has:
         Id
         ReadComment(method ) - accepts string and writes in the console: The Guest with Id: Id read this comment: Comment
         If guest tries to post, it should show a message: Guests cannot post
         Has default Role of Guest */

        public int Id { get; set; }

        public void ReadComments(string commentar)
        {
            Console.WriteLine($"The Guest with Id: {Id} read this comment: {commentar}");
        }

        public override void PostComments(string comments)
        {
            Console.WriteLine("Guest cannot post a commnet");
        }

        public override void PrintUser()
        {
            Console.WriteLine($"{UserName} with ID {Id} and his role is {role}");
        }

       
    }
}
