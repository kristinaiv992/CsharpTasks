using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Exercise 1
            Create a human class:
            FirstName - string, LastName - string, IsEmployed - bool, Age - int, Hobbies - List of strings
            Methods:
            GetDetails - returns string with first name, last name and age
            GetHobies - prints all Hobbies in console
            Create an empty and a setter constructor
            Create a list of 3 Human objects
            //----------------------------------//
            Exercise 2
            Create a Devepoer class that inherits from Human:
            Languages - List of strings
            GetLangauges(method) - prints all langauges in console */

            Human Kristina = new Human("Kristina", "Ilovik", 44, false, new List<string>() { ("swimming") });
            Human Joana = new Human("Joana", "Jolic", 94, true, new List<string>() { ("dancing") });
            Human Filips = new Human("Filip", "Lilik", 64, false, new List<string>() { ("skiing") });

            

            Kristina.Hobbies.Add("Skiing");
            Kristina.Hobbies.Add("Football playing");
            Kristina.Hobbies.Add("Dancing");
            Kristina.GetHobies();
            Console.WriteLine(Kristina.GetDetails()); //mora da ima console.writeLine bidejki nema return

            var Kristijan = new Developer(new List<string>() { "java" });
            Kristijan.Languages.Add("cSharp");
            Kristijan.GetLanguages();


            




        }
    }
}
