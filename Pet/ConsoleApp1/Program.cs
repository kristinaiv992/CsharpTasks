using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Exercise
            Create 4 classes:
            Pet( abstract ) with Name, Type and Age
            Dog( from Pet ) with GoodBoi and FavoriteFood
            Cat( from Pet ) with IsLazy and LivesLeft
            Fish( from Pet ) with color, size
            Create Static Db class with ONE LIST OF PETS
            Create a generic service class that can work for any pet and can:
            Add pet to Db
            Remove pet from Db by input Name
            Find a pet by input Name
            Find all pets by input Age
            Find all pets by input Type */

            Dog Jekky = new Dog() { Name = "Jekky" };
            GenericServiceClass<Dog> Classss = new GenericServiceClass<Dog>();
            Classss.AddPet(Jekky);

            Console.WriteLine(Db.Pets[0].Name);


        }
    }
}
