using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;

            if (i.HasValue)
            {
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            }
            else
            {
                Console.WriteLine("Null");
            }
            Console.WriteLine(i.GetValueOrDefault());

            int? j = null;
            double? d = null;
            Estudiante estudiante = null;
            int? k = null;
            int? h = k ?? 0;
            Estudiante estudiante1 = new Estudiante();
            Console.WriteLine(estudiante1.GetIdEstudiante());


            int? a = null;
            int b = 10;


            if (a < b)
                Console.WriteLine("a < b");
            else if (i > 10)
                Console.WriteLine("a > b");
            else if (i == 10)
                Console.WriteLine("a == b");
            else
                Console.WriteLine("No se puede comparar");
            if (Nullable.Compare<int>(a, b) < 0)
                Console.WriteLine("a < b");
            else if (Nullable.Compare<int>(a, b) > 0)
                Console.WriteLine("a > b");
            else
                Console.WriteLine("a = b");


        }
    }
    }

