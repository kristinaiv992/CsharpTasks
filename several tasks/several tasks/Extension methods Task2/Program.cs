using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1 and 2
            Console.WriteLine("Please enter a word:");
            var stri = Console.ReadLine();
            Console.WriteLine(stri.ExtensionGetFirstLetter());
            Console.WriteLine(stri.ExtensionGetLastLetter()); 
            //3
            Console.WriteLine("Please enter a number to tell you if the number is even or not:");
            var integer = int.Parse(Console.ReadLine());
            integer.ExtensionIsEven();
            //4
            List<int> integer = new List<int>() { 22, 33, 445, 55 };
            integer.GetIntegers(3);
            */
            var items = new List<int>() { 22, 44, 555, 345, 998 };
            var items2 = new List<string>() { "kiki", "kate", "goga", "deni" };
            items.PrintListOfItems();
            items2.PrintListOfItems();



        }
    }
}
