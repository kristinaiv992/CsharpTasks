using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class PetHelper
    {
       public static int ConvertDogYears(this int age)
        {
            return age / 7;
        }

        public static void WhatPetIsThis(this Pet pet)
        {
            Console.WriteLine($"The {pet.Name} is {pet.Type}");
        }
    }
}
