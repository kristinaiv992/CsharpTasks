using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAndThirdTask
{
    public class Cat : Animals
    {
        public bool IsLazy { get; set; }
        public override void Print()
        {
            Console.WriteLine($"The name of the Cat is {Name}, the age is {Age} and the color of the animal is {Color}");
        }
        public void Meaow()
        {
            Console.WriteLine(" It is a cat: meaow meaow meeeaow");
        }
    }
}
