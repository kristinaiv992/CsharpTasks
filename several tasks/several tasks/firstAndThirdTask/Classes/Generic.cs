using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAndThirdTask.Classes
{
    public class Generic
    {
        //PrintAnimals - Method that prints any list with Animals 
        //( print method ) in the console ( Dog, Cat Bird and any Animal )
        public static void PrintAnimals<T>(List<T> ani) where T : Animals
        {
            foreach (T item in ani)
            {
                Console.WriteLine(item.Name);
                item.Print();
            }
        }
        
    }
}
