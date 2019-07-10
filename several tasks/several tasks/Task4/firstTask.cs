using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class firstTask
    {
        //1. Create a delegate that accepts two strings and returns void (CompareDel)//
        //2. Create a delegate that accepts two strings and returns bool (CompareBoolDelegate)//
        public delegate void CompareDel(string stri1, string stri2);
        public delegate bool ComparerBoolDelegate(string stri1, string stri2);

        public static void StringMessage(string str1, string str2, CompareDel comparedel)
        {
             comparedel(str1, str2);
        }
        public static void StringMessages(string str1, string str2, ComparerBoolDelegate comparerDelegate)
        {
            comparerDelegate(str1, str2);
        }
        public static void Comparer(string stri1, string stri2)
        {
            if (stri1 == stri2)
            {
                Console.WriteLine($"The strings {stri1} and {stri2} are equal");
            }
            Console.WriteLine($"The strings {stri1} and {stri2} are not equal");
        }
        public static bool Compare(string stri1, string stri2)
        {
            if (stri1 == stri2)
            {
                Console.WriteLine("They are equail");
                return true;
            }
                Console.WriteLine("They are not equal");
                return false;
            }

        public static void StringMagic(string str1, string str2)
        //method to compare 2 strings length
        {
                int numberOfLetters = str1.Count();
                int numberOfLetters2 = str2.Count();
                if(str1.Length == str2.Length)
            {
                Console.WriteLine($"The inserted words {str1} and {str2} are with the same length!");
                Console.WriteLine($"They both have {numberOfLetters} letters!");
            } else 
            Console.WriteLine($"The inserted words are NOT with the same length!" +
                $" the word {str1} has {numberOfLetters} letters and the word {str2} has {numberOfLetters2} letters");
        }

        //method to compare if the 2 strings start on the same character
        public static void StringMagicStart(string str1, string str2)
        {
            if (str1[0] == str2[0])
            {
                Console.WriteLine($"The inserted words {str1} and {str2} have the same first letter!");
            }
            else
            {
                Console.WriteLine($"The inserted words {str1} and {str2} have different first letter!");
            }
        }
        //method to compare if the 2 strings end on the same character
        public static void StringMagicSEnd(string str1, string str2)
        {
            if (str1[str1.Length-1] == str2[str2.Length-1])
            {
                Console.WriteLine($"The inserted words {str1} and {str2} have the same last letter!");
            }
            else
            {
                Console.WriteLine($"The inserted words {str1} and {str2} have different last letter!");
            }
        }











    }
}
