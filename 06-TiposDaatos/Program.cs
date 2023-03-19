using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TiposDaatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numero = 100;
            Console.WriteLine("el valor de la variable numero {0}", numero);

            sbyte numero2 = 127;
            Console.WriteLine("el valor de la variable numero {0}", numero2);

            uint numero3 = 1000u;
            Console.WriteLine("el valor de la variable numero {0}", numero3);

            long numero4 = 1000l;
            Console.WriteLine("el valor de la variable numero {0}", numero4);

            DateTime fecha = new DateTime(1000, 12, 23);
            Console.WriteLine("el valor de la variable fehca {0}", fecha);

            object mIObject = new object();

            //inicializacion de variables
            bool i = default;
            Console.WriteLine("el valor de la variable i {0}", i);

            //conversion implicita 
            int j = 345;
            float f = j;
            Console.WriteLine("el valor de la variable f {0}", f);

            //conversion explicita
            int h = 100;
            uint u = (uint)h;
            Console.WriteLine("el valor de la variable u {0}", u);


            Console.ReadLine();
        }
    }
}

