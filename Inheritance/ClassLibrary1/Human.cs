using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsEmployed { get; set; }
        public List <string> Hobbies { get; set; }
        //setter constructor
        public Human(string name, string surname,int age, bool employed, List<string> hobby)
        {
            Name = name;
            LastName = surname;
            Age = age;
            IsEmployed = employed;
            Hobbies = hobby;
        }
        //empthy constructor
        public Human()
        {

        }
        public string GetDetails()
        {
            Console.WriteLine("Info for the user:");
            return $"{Name} {LastName} is {Age} years old";
        }
        /*Method:  GetHobies - prints all Hobbies in console */
        public void GetHobies()
        {
            foreach (var item in Hobbies)
            {
                Console.WriteLine("Hobbies: " + item);
            }
        }

    }
}
