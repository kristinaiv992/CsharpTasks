using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAndThirdTask
{
   public class Dog : Animals
    {
        public string Race { get; set; }

        public override void Print()
        {
            Console.WriteLine($"The name of the Dog is {Name}, the age is {Age} and the color of the animal is {Color}");
        }

        public void Bark()
        {
            Console.WriteLine("bark Bark bark!");
        }
    }
}
