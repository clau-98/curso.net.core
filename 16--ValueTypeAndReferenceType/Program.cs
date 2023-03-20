using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16__ValueTypeAndReferenceType
{
    internal class Program
    {
        static void ChangeValue(int x)
        {

            x = 200;
            Console.WriteLine(x);
        }


        //VALUE TYPES
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);

            //REFERENCE TYPE

            Estudiante estudiante = new Estudiante();
            estudiante.Id = 1;
            estudiante.Nombre = "Juan";

            Console.WriteLine($"Id:{estudiante.Id}, Nombre:{estudiante.Nombre}");

            ChangeValue2(estudiante);
            Console.WriteLine($"Id:{estudiante.Id}, Nombre:{estudiante.Nombre}");

        }

        static void ChangeValue2(Estudiante estudiante) {
            estudiante.Id = 2;
            estudiante.Nombre = "Maria";
            Console.WriteLine($"Id:{estudiante.Id}, Nombre:{estudiante.Nombre}");
        }
        


    }

    class Estudiante
    {

        public int Id { get; set; }

        public string Nombre { get; set; }
    }
}
