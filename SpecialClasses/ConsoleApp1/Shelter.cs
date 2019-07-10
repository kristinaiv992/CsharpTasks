using System;
using System.Collections.Generic;
using static ConsoleApp1.Dog;

namespace ConsoleApp1
{
    /*Make a static class called shelter with:
        Dogs - queue
        Adopt(method) - accepts owner and address, adds chip to the next
        dog for adoption and takes it out of the Dogs queue.Show a success message.*/
    public static class Shelter
    {
        public static Queue<Dog> Shelterac = new Queue<Dog>();
        
        public static void AddDogToShelter(Dog dog)
        {
            Console.WriteLine("The dog is added to the shelter!");
            Shelterac.Enqueue(dog);
        }


        public static Dog Adopt(string owner, string address)
        {
            Chip chipos = new Chip(owner, address);
            var adoptedDoggy = Shelterac.Dequeue();
            adoptedDoggy.AddChip(chipos);
            return adoptedDoggy;
        }

        public static void ShowAnimals()
        {
            Console.WriteLine($"In this moment the shelter has {Shelterac.Count} dogs.");
            foreach (var item in Shelterac)
            {
                Console.WriteLine($"The dog {item.Name} is a race {item.Race}!");
            }
        }

    }

}
