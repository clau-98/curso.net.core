using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();

            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2015, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            DateTime dt5 = new DateTime(636370000000000000);
            Console.WriteLine(dt5);

            Console.WriteLine(DateTime.MaxValue.Ticks);
            Console.WriteLine(DateTime.MinValue.Ticks);


            var str = "5/12/2020";
            DateTime dt6;

            var isValidDate = DateTime.TryParse(str, out dt6);
            if (isValidDate)
                Console.WriteLine(dt6);
            else
                Console.WriteLine($"{str} is not a valid date string");


            Console.ReadLine();
            }
    }
}
