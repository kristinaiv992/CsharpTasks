using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        /*Create a Dog class that has:
        Name, Age, Race, Color, Chip
        AddChip(method ) - accepts all nececery information and adds chip to this dog
        IdentifyDog( static method ) - accepts a dog object and shows info about the dog
        on screen if the dog has chip, otherwise it tells the user that the dog
        is an unknown dog.
        Create a nested class called Chip with:
        Id, Owner, Address, Constructor - sets owner and address, 
        generates a random number as I'd from 1000 to 9999
        ********
        Find all dogs older than 3 and add them to a list!
        ********
        Make a static class called shelter with:
        Dogs - queue
        Adopt( method) - accepts owner and address, adds chip to the next 
        dog for adoption and takes it out of the Dogs queue. Show a success message.*/
        static void Main(string[] args)
        {
            //1
            Dog Kiro = new Dog("Kiro", 6, "doberman", "black");
            //-----------we are calling the nested class------------// 
            Dog.Chip chipedDog = new Dog.Chip("Slavica Petrova", "Rugjer Boskovic");
            Kiro.AddChip(chipedDog);
            Dog.IdentifyDog(Kiro);
            //2
            Dog Stojko = new Dog("Stojan", 5, "hasky", "black");
            Dog.IdentifyDog(Stojko);
            //3
            Dog Kira = new Dog("Kira", 3, "german sheppard", "gray");
            Dog.Chip Chipuvana = new Dog.Chip("Dimitar Dimitris", "karposhovo Vostanie");
            Dog.IdentifyDog(Kira);
            Kira.AddChip(Chipuvana);

            var dogList = new List<Dog>();
            dogList.Add(Kiro);
            dogList.Add(Stojko);
            dogList.Add(Kira);

            var olderthanthree = dogList.Where(years => years.Age > 3);

            foreach (var item in olderthanthree)
            {
                Console.WriteLine($"The dog {item.Name},race {item.Race} " +
                    $"has more than 3 years more specifically it is " + item.Age);
            }
            Shelter.AddDogToShelter(Kira);
            Shelter.AddDogToShelter(Kiro);
            Shelter.Adopt("Mirko Pajic", "Sutjeska");
            Shelter.ShowAnimals();



        }
    }
}
