using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            float rate = 10.2F;
            decimal amount = 100.50M;
            char code = 'A';
            bool isValid = true;
            String name = "pablo";




            Console.WriteLine(num);
            Console.WriteLine(rate);
            Console.WriteLine(amount);
            Console.WriteLine(code);
            Console.WriteLine(isValid);
            Console.WriteLine(name);
            Console.ReadLine();

            //errores que no se deben hacer 
            //int num1 = "aa";

            //declarar y asignar despues
            int num2;
            num2 = 100;
            Console.WriteLine(num2);

            //error asignacion no valida
            //int j - i;
            int num3 = 100;
            num3 = 100;
            Console.WriteLine(num3);

            //declarar e inicializar multiples variables

            int i, j = 10, k = 100;
            i = 1;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            //declarar e iniciar multiples variables en multiples lienas 
            int i1 = 1,
            j1 = 10,
            k1 = 100;
            Console.WriteLine(i1);
            Console.WriteLine(j1);
            Console.WriteLine(k1);

            //asignacion de variables
            int i3 = 100;
            int j3 = 100;

            //variables y expresiones
            int i4 = 100;
            int j4 = i4 + 20;

            j4 = 200;
            j4 = i4 + 20;

            i4 = 300;
            Console.WriteLine("j4 = {0},j4 = {1}", j4, i4);

            var i5 = 5;
            Console.WriteLine(i5);
        }
    }
}