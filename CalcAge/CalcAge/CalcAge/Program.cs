using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------Calculate your BirthDay--------------------//

            DateTime birthday = Convert.ToDateTime("04/10/1992");
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(birthday);

            int age = today.Year - birthday.Year;
            Console.WriteLine(today.AddYears(-age));
            if (birthday > today.AddYears(-age))
                age--;
            Console.WriteLine(age);
            Console.ReadLine();

            //--------------------------------------------------------------------//

            Console.WriteLine("Enter your birthdate (in format yyyy-mm-dd)");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());

            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;

            var b = ((birthdate.Year * 100 + birthdate.Month) * 100 + birthdate.Day);

            Console.Write((a - b) / 10000);


            //--------------------------------------------------------------------//
        }
    }
}
