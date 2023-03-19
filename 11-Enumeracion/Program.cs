using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Enummeracion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WeekDays dia1 = WeekDays.Monday;
            WeekDays dia2 = WeekDays.Friday;
            WeekDays dia3 = WeekDays.Tuesday;
            Console.WriteLine((int)dia1);
            Console.WriteLine((int)dia2);
            Console.WriteLine((int)dia3);
            Console.WriteLine(dia1);
            Console.WriteLine(dia2);
            Console.WriteLine(dia3);
            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine((int)WeekDays.Thursday);

            int day = (int)WeekDays.Friday;
            Console.WriteLine(day);

            WeekDays weekDay = (WeekDays)5;
            Console.WriteLine(day);

            Categories categoria1 = Categories.Autonotive;
            Categories categoria2 = Categories.Arts;
            Console.WriteLine((int)categoria1);

            Categories2 categoria3 = Categories2.Automotive;
            Categories2 categoria4 = Categories2.Fashion;
            Categories2 categoria5 = Categories2.WomanFashion;
            Console.WriteLine((int)categoria3);
            Console.WriteLine((int)categoria4);
            Console.WriteLine((int)categoria5);

            Console.ReadLine();

        }
        enum Categories2
        {
            Automotive = 6,
            Electronics = 1,
            Food = 5,
            Arts = 10,
            BeatyCare = 11,
            Fashion = 15,
            WomanFashion = 15
        }
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Categories
        {
            Electronics,
            Food,
            Autonotive = 6,
            Arts,
            BeatyCare,
            Fashion
        }
    }
}
