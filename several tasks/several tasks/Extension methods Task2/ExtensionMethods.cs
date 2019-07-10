using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods_Task2
{
    public static class ExtensionMethods
    {
        public static char ExtensionGetFirstLetter(this string str)
        {
            Console.WriteLine($"The first letter of your word {str} is:");
            //return str[0];
            return !String.IsNullOrWhiteSpace(str) ? Convert.ToChar(str.Substring(0, 1)) : ' ';
        }
        public static char ExtensionGetLastLetter(this string str)
        {
            Console.WriteLine($"The last letter of your word {str} is:");
            if (str == null)
                throw new ArgumentNullException("Invalid input");
            return str.Last();
            //return str[str.length-1];
        }
        public static void ExtensionIsEven(this int integer)
        {
            if (integer % 2 == 0)
            {
                Console.WriteLine("The number you entered is even number"); 
            }
            else Console.WriteLine("The number you entered is an odd number"); 
           
        }
        public static List<T> GetIntegers<T>(this List<T> values, int num)
        {
            var newlist = values.Take(num).ToList();
            foreach (T item in newlist)
            {
                Console.WriteLine(item);
            }
            return newlist;
        }

        public static void PrintListOfItems<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
