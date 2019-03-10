using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace od_cas
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCutter();
        }


        static void StringCutter()
        {

            Console.WriteLine("Please enter a sentence?");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence);
            Console.WriteLine("Please enter a number of letters you want to be cut");
            int no = int.Parse(Console.ReadLine());
            var Cutted = sentence.Substring(0, no);
            var Cutted2 = sentence.Substring(no);
            Console.WriteLine(Cutted); //displays the cut letters
            Console.WriteLine(Cutted2); //displays the rest 

        }
    }
}
