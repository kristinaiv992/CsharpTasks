using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /*Create a user class that has:
        Username
        Role - Guest, Moderator, Poster
        Comments - list of strings
        PostComment(method ) - accepts a comment and adds it to the Comments list
        PrintUser( abstract method ) - prints all details of a user */
    public abstract class User
    {
        public string UserName { get; set; }
        public Role role { get; set; }
        public List<string> Comments { get; set; }
        public abstract void PrintUser();

        public virtual void PostComments( string comments)
        {
            var comento = new List<string>();
            comento.Add(comments);
        }

    }

    public enum Role
    {
        Guest,
        Moderator,
        Poster
    }
}
