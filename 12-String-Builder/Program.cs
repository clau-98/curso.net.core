using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder("hola mundo");
            StringBuilder stringBuilder3 = new StringBuilder(50);
            StringBuilder stringBuilder4 = new StringBuilder("hola mundo", 50);
            StringBuilder stringBuilder5 = new StringBuilder(" hola mundo", 0, 10, 50);

            for (int pos = 0; pos < stringBuilder.Length; pos++)
            {

                Console.WriteLine(stringBuilder[pos]);

            }

            string saludo = stringBuilder.ToString();


            StringBuilder stringBuilder6 = new StringBuilder();
            stringBuilder6.Append("hola");
            stringBuilder6.AppendLine("hola mundo");
            Console.WriteLine(stringBuilder6);


            StringBuilder sbACantidad = new StringBuilder("tu cantidad es: ");
            sbACantidad.AppendFormat("{0:C} ", 25);
            Console.WriteLine(stringBuilder6);


            StringBuilder stringBuilder7 = new StringBuilder("hola mundo");
            stringBuilder7.Insert(5, " C#");
            Console.WriteLine(stringBuilder7);

            StringBuilder stringBuilder8 = new StringBuilder("hola mundo hola mundo hola mundo hola mundo ", 50);
            stringBuilder8.Remove(6, 7);
            Console.WriteLine(stringBuilder8);



            StringBuilder stringBuilder9 = new StringBuilder("hola mundo");
            stringBuilder9.Replace("mundo", "loco");
            Console.WriteLine(stringBuilder9);


            Console.Read();
        }
    }
}