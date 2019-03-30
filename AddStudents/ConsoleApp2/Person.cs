using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            FirstName = name;
            LastName = surname;
            Age = age;
        }


        public Person()
        {

        }

        public string PrintName ()
        {
            return $"{FirstName} {LastName} {Age} years old is found";
            }
        public void PrintName2()
        {
            Console.WriteLine($" {FirstName} {LastName} is not found");
        }
    }
}
