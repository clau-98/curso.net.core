using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Cadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch = "S";
            string word = "String";
            string text = "This is a string.";

            string str1 = "Hello"; // uses string keyword
            String str2 = "Hello"; // uses System.String class

            //----------------------------------------------------------------------------------------

            char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            string str3 = new string(chars);
            string str4 = new string(chars);

            foreach (char varElementoArreglo in str3)
            {
                Console.WriteLine(varElementoArreglo);
            }

            //----------------------------------------------------------------------------------------

            string text2 = "This is a \"string\" in C#.";
            string str = "xyzdef\\rabc";

            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}

