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
            var Date = new DateTime(2019,04,02);
            Console.WriteLine(Date);
            var DateTime = new DateTime(2019, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var tomorrow1 = DateTime.Today.AddDays(1);
            Console.WriteLine("Hour at the moment" + now.Hour);
            Console.WriteLine(" Minutes at the moment" + now.Minute);

            var tommorow = now.AddDays(1);
            var yesterday = today.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            //------Time Span-------------//
            var TimeSpan = new TimeSpan(1, 2, 3);
            var TimeSpan1 = new TimeSpan(1, 0, 0);
            var TimeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine("TimeSpan:" + TimeSpan + TimeSpan1 + TimeSpan2);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

        }
    }
}
