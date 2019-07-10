using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat : Pet
    {
        public bool isLazy { get; set; }
        public int LivesLeft { get; set; }

        public Cat( string name , int agesLeft)
        {
            Type = PetType.Cat;
            Name = name;
            LivesLeft = agesLeft;
            if(agesLeft<1 || agesLeft > 9)
            {
                Console.WriteLine("This is not a valid number");
                agesLeft = 1;
            }
        }



        public override void PrintPet()
        {
            Console.WriteLine($"The pet {Name} has years {Age} and has  {LivesLeft} years left");
        }
    }
}
