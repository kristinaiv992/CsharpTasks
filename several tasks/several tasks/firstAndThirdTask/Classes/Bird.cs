using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAndThirdTask.Classes
{
    public class Bird : Animals
    {
        public bool isWild { get; set; }

        public override void Print()
        {
            Console.WriteLine($"The name is{Name}, the age is {Age} and the color of the animal is {Color}");
        }

        public void FlySouth()
        {
            if (isWild)
            {
                Console.WriteLine($"The bird {Name} is flying to the South");
            }
            else
            {
                Console.WriteLine("This bird is a domesticated bird");
            }
        }
    }
}
