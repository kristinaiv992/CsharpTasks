using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
             
           /*Person Student1 = new Person(); */// nov 
            var students = new List<Person>();
            students.Add(new Person("kristina", "Ivanova", 99));
            students.Add(new Person("Hristo", "Batarcev", 89));
            students.Add(new Person("Aco", "Shopov", 59));
            students.Add(new Person("Dejanco", "Zlatev", 89));

            Console.WriteLine("Please enter a name?");
            var input = Console.ReadLine();
            bool found = false;
            foreach (var item in students)
            {
                if(item.FirstName == input)
                {
                    Console.WriteLine(item.PrintName());
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Input not found do you want to add him? Y/N");
                var input2 = Console.ReadKey().KeyChar;

                while (true)
                {
                    if (input2 == 'N' || input2 == 'n')
                    {
                        break;
                    }
                    else
                    {
                        
                        Console.WriteLine("Enter your surname");
                        var input3 = Console.ReadLine();
                        Console.WriteLine("Enter your age");
                        var input4 = int.Parse(Console.ReadLine());
                        students.Add(new Person(input, input3, input4));
                        Console.WriteLine($"The user is entered {students[students.Count - 1].PrintName()}");
                        break;
                    }
                }
            }
        }
    }
}
