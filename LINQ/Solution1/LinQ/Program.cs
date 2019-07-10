using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Sculptor),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
            };

            var Dogsy = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, Race.Collie),
                new Dog("Buddy", "Brown", 1, Race.Doberman),
                new Dog("Max", "Olive", 1, Race.Plott),
                new Dog("Archie", "Black", 2, Race.Mutt),
                new Dog("Oscar", "White", 1, Race.Mudi),
                new Dog("Toby", "Maroon", 3, Race.Bulldog),
                new Dog("Ollie", "Silver", 4, Race.Dalmatian),
                new Dog("Bailey", "White", 4, Race.Pointer),
                new Dog("Frankie", "Gray", 2, Race.Pug),
                new Dog("Jack", "Black", 5, Race.Dalmatian),
                new Dog("Chanel", "Black", 1, Race.Pug),
                new Dog("Henry", "White", 7, Race.Plott),
                new Dog("Bo", "Maroon", 1, Race.Boxer),
                new Dog("Scout", "Olive", 2, Race.Boxer),
                new Dog("Ellie", "Brown", 6, Race.Doberman),
                new Dog("Hank", "Silver", 2, Race.Collie),
                new Dog("Shadow", "Silver", 3, Race.Mudi),
                new Dog("Diesel", "Brown", 1, Race.Bulldog),
                new Dog("Abby", "Black", 1, Race.Dalmatian),
                new Dog("Trixie", "White", 8, Race.Pointer),
            };
            /*
            PART 1
             1.Structure the solution(create class library and move classes and enums accordingly)

            PART 2
             1. Take person Cristofer and add Jack, Ellie and Hank as his dogs.
             2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.
             3. Add Trixie, Archie and Max as dogs from Erin
             4. Give Abby and Shadow to Amelia          

            PART 3 - LINQ
             1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
             2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
             3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
             4. Find and print all Freddy`s dogs names older than 1 year
             5. Find and print Nathen`s first dog
             6. Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

            PART 4 - Be Creative, PLAY with LINQ */

            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            Console.WriteLine("1.Take person Cristofer and add Jack, Ellie and Hank as his dogs:");
            var findCristofer = people.Where(x => x.Name == "Cristofer").FirstOrDefault();
            var findJack = Dogsy.Where(y => y.Name == "Jack").FirstOrDefault();
            var findEllie = Dogsy.Where(y => y.Name == "Ellie").FirstOrDefault();
            var findHank = Dogsy.Where(y => y.Name == "Hank").FirstOrDefault();

            findCristofer.Dogs = new List<Dog>(); //ova e ako ja nemav listata vo kontruktorot vo Person!
            findCristofer.Dogs.Add(findJack);
            findCristofer.Dogs.Add(findEllie);
            findCristofer.Dogs.Add(findHank);

            foreach (var item in findCristofer.Dogs)
            {
                Console.WriteLine(item.Name);
            }
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            Console.WriteLine("2.Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs");
            var findFreddyMercurry = people.Where(x => x.Name == "Freddy").FirstOrDefault();
            //var findFreddyMercurry = from man in people
            //                         where man.Name == "Freddy"
            //                         select man;
            findFreddyMercurry.Dogs = new List<Dog>();
            var findOscar = Dogsy.Where(d => d.Name == "Oscar").FirstOrDefault();
            var findToby = Dogsy.Where(d => d.Name == "Toby").FirstOrDefault();
            var findChanel = Dogsy.Where(y => y.Name == "Chanel").FirstOrDefault();
            findFreddyMercurry.Dogs.Add(findOscar);

            foreach (var item in findFreddyMercurry.Dogs)
            {
                Console.WriteLine(item.Name);
            }
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            Console.WriteLine(" 3. Add Trixie, Archie and Max as dogs from Erin");

            var findErin = people.Where(x => x.Name == "Erin").FirstOrDefault();
            var findTrixie = Dogsy.Where(y => y.Name == "Trixie").FirstOrDefault();
            var findArchie = Dogsy.Where(y => y.Name == "Archie").FirstOrDefault();
            var findMax = Dogsy.Where(y => y.Name == "Max").FirstOrDefault();

            findErin.Dogs = new List<Dog>();
            findErin.Dogs.Add(findTrixie);
            findErin.Dogs.Add(findArchie);
            findErin.Dogs.Add(findMax);
            foreach (var item in findErin.Dogs)
            {
                Console.WriteLine(item.Name);
            }
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            Console.WriteLine("4. Give Abby and Shadow to Amelia ");
            var findAmelia = people.Where(x => x.Name == "Amelia").FirstOrDefault();
            var findAbby = Dogsy.Where(d => d.Name == "Abby").FirstOrDefault();
            var findShadow = Dogsy.Where(d => d.Name == "Shadow").FirstOrDefault();

            findAmelia.Dogs = new List<Dog>();
            findAmelia.Dogs.Add(findAbby);
            findAmelia.Dogs.Add(findShadow);

            foreach (var item in findAmelia.Dogs)
            {
                Console.WriteLine(item.Name);
            }
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            Console.WriteLine(" 1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER");
            var FirstLetter = people.Where(x => x.Name.StartsWith("R"))
                              .OrderByDescending(p => p.Age).ToList();
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            Console.WriteLine("2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER");

            var PrintBrownDogsByAge = Dogsy.Where(d => d.Color == "Brown")
                                    .OrderByDescending(a => a.Age > 3).Reverse().ToList();
            foreach (var item in PrintBrownDogsByAge)
            {
                if (PrintBrownDogsByAge.Count == 1)
                {
                    Console.WriteLine($"There is one brown dog that is older than 3 and his name is {item.Name}");
                }
                else
                {
                    Console.WriteLine($"Dog older than three and is brown is called {item.Name}");
                }
            }
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            //Console.WriteLine(" 3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER");
            //var PeopleWithMoreThanTwodogs = people.Where(x => x.Dogs.Count > 2)
            //                                .OrderByDescending(p => p.Name)
            //                                .ToList();

            //foreach (var item in PeopleWithMoreThanTwodogs)
            //{

            //    Console.WriteLine($"{item.Name} has more than three dog");
            //}
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            Console.WriteLine("4. Find and print all Freddy`s dogs names older than 1 year");
            var FreddyDogs = findFreddyMercurry.Dogs.Where(x => x.Age > 1).ToList();
            foreach (var item in FreddyDogs)
            {
                Console.WriteLine(item.Name);
            }
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            Console.WriteLine("Find and print Nathen`s first dog");
            Console.WriteLine("None");

            Console.WriteLine("6.All white dogs names from Cristofer, Freddy, Erin and Amelia," +
                " ordered by Name - ASCENDING ORDER:");
            //-------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------//
            var WhiteDogs = new List<Dog>();
            var FreddyWhiteDogs = findFreddyMercurry.Dogs.Where(x => x.Color == "White").ToList();
            var CrickyWhiteDogs = findCristofer.Dogs.Where(x => x.Color == "White").ToList();
            var ErinWhiteDogs = findErin.Dogs.Where(x => x.Color == "White").ToList();
            var AmeliaWhiteDogs = findAmelia.Dogs.Where(x => x.Color == "White").ToList();

            foreach (var item in FreddyWhiteDogs)
            {
                if(FreddyWhiteDogs.Count != 0)
                {
                    WhiteDogs.Add(item);
                }
                Console.WriteLine(item.Name);
            }

            foreach (var item in CrickyWhiteDogs)
            {
                if (CrickyWhiteDogs.Count != 0)
                {
                    WhiteDogs.Add(item);
                }
                Console.WriteLine(item.Name);
            }
            //---and so on



        }
    }
}
