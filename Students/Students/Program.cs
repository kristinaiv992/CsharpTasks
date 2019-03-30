using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>();
            {

                studentList.Add("Kristina");
                studentList.Add("Katerina");
                studentList.Add("Marko");
                studentList.Add("Milena");
                studentList.Add("Sanja");
                studentList.Add("Venko");
            }
            Console.WriteLine("Please enter a name?");
            var found = Console.ReadLine();
           bool exist = false;
            foreach (var item in studentList)
            {
                if(item.ToLower() == found.ToLower())
                {
                    Console.WriteLine($"The name you entered {found.ToLower()} is found");
                    exist = true;
                }
            }

            if (!exist)
            {
                Console.WriteLine("The user does not exists!");
            }

        }
    }
}
