using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }
        public string FavoriteFoodName { get; set; }
        public int Age { get; set; }

        public Dog(string name, int age)
        {
            Name = name;
            Type = PetType.Dog;
            Age = age;
        }




        public override void PrintPet()
        {
            Console.WriteLine();
        }
    }
}
