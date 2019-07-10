using System.Collections.Generic;

namespace LinQ
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Job JobTitle { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string name, string surname, int age, Job personJob/*, List<Dog> doggy*/)
        {
            Name = name;
            Surname = surname;
            Age = age;
            JobTitle = personJob;
            //Dogs = doggy;
        }

    }
}