using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string OwnerName { get; set; }
        public PetType Type { get; set; }

        public abstract void PrintPet(); //kje mu napravam override!


    }


    public enum PetType

    {
        Dog, 
        Cat
       

    }
}
