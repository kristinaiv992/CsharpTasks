using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public Chip chip { get; set; }

        public Dog(string name, int age, string race, string color)
        {
            Name = name;
            Age = age;
            Race = race;
            Color = color;          
        }

        public void AddChip(Chip chipos)
        {
            chip = chipos;
            Console.WriteLine($"The owner {chip.Owner} is added to the dog {Name} with age of {Age} and color {Color}");
        }
         public static void IdentifyDog(Dog dogos) //ako bara return type toa e void
        {
            if(dogos.chip != null)
            {
                Console.WriteLine($"{dogos.Name}'s owner is {dogos.chip.Owner} who lives on address {dogos.chip.Address}");
            }
            else Console.WriteLine($"The dog {dogos.Name} does not have an owner and his color is {dogos.Color} and a race {dogos.Race}");
        }

       public class Chip
        {
           
            public int Id { get; set; }
            public string Owner { get; set; }
            public string Address { get; set; }

            public Chip(string owner, string address)
            {
                Owner = owner;
                Address = address;
                Random rd = new Random();
                Id = rd.Next(1000, 9999);
                
            }
        }

    }
}
