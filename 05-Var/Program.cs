using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
            Console.WriteLine("el tipo de dato de i es {0}", i.GetType());

            var str = "hello world!!";
            Console.WriteLine("tipo de dato de str es {0} ", str.GetType());

            var dbl = 200.50d;
            Console.WriteLine("tipo de dato de dbl es {0} ", dbl.GetType());

            var isValid = true;
            Console.WriteLine("tipo de dato de isValid es {0} ", isValid.GetType());

            var ano = new { id = 1, name = " Samantha", lastName = "Palma" };
            Console.WriteLine("tipo de dato de ano es {0} ", ano.GetType());

            var arr = new[] { 1, 18, 20, 38 };
            Console.WriteLine("tipo de dato de arr es {0} ", arr.GetType());

            var file = new FileInfo("Myfile");
            Console.WriteLine("tipo de dato de file es {0} ", file.GetType());

            //errores
            //var j;
            //j=100;

            // var h = 200, j=200, k=300;
            var h = 100;
            var k = 200;
            var j = 300;

            Console.WriteLine(h);
            Console.WriteLine(k);
            Console.WriteLine(j);


            //utilizando var en un ciclo for 
            for (var l = 0; l < 10; l++)
            {
                Console.WriteLine(l);
            }

            //utilizando var en una expresion linq
            IList<String> stringsList = new List<String>();
            stringsList.Add("C# Tutorials");
            stringsList.Add("VB.NET TUTORIALS");
            stringsList.Add("Leran C++");
            stringsList.Add("MVC Tutorials");
            stringsList.Add("Java");

            var result = from elemento in stringsList
                         where elemento.Contains("Tutorials")
                         select elemento;

            foreach (var elemento in result)
            {
                Console.WriteLine(elemento);
                Console.ReadLine();
            }


        }
        //No se pueden usar palabras reservadas var en parametros
        //public static void Display(var parametro) {
        //Console.WriteLine(parametro);
    }
}
