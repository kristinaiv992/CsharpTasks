using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog Pance = new Dog("Snoopy",5);
            Dog Kirco = new Dog("Flipy", 7);
            PetDb.dogs.Add(Pance);
            PetDb.dogs.Add(Kirco);
            Cat Cloi = new Cat("Cloi",3);
            PetDb.cats.Add(Cloi);

            Console.WriteLine(Pance.Age.ConvertDogYears());
            Pance.WhatPetIsThis();
            Cloi.PrintPet();




        }
    }
}
