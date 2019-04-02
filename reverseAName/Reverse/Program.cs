using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name?");
            var name = Console.ReadLine(); //kristina
            var reversed = ReverseAName(name);
           Console.WriteLine("Your name reversed is: " +  reversed);

        }
        public static string ReverseAName(string name)
        {
            var array = new Char[name.Length]; // char[7]
            for(var i=name.Length; i>0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
                var reversed = new string(array);
            return reversed;
        



        }


    }
}
