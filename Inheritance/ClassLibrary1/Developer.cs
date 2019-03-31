using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /*Exercise 2
    Create a Devepoer class that inherits from Human:
   Languages - List of strings
   GetLangauges(method) - prints all langauges in console*/
    public class Developer : Human
    {
        public List<string> Languages { get; set; }
        public Developer(List<string> Lang)
        {
            Languages = Lang;
        }
        public void GetLanguages()
        {
            foreach (var item in Languages)
            {
            Console.WriteLine($"The languages are {item}");

            }
        }

    }
}
