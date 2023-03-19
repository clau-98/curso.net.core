using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante
            {
                EstudianteId = 0,
                nombre = "Claudia",
                apellidoPaterno = "Zamora",
                apellidoMaterno = "Meneses"
            };
            string resultadonombreCompleto = estudiante1.obtenerNombreCompleto();


            Estudiante estudiante2 = new Estudiante();
            estudiante2.EstudianteId = 0;
            estudiante2.nombre = "Dulce";
            estudiante2.apellidoPaterno = "Zamora";
            estudiante2.apellidoMaterno = "Meneses";
            string resultadonombreCompleto2 = estudiante2.obtenerNombreCompleto();


            Estudiante estudiante3 = new Estudiante(3, "Madison", "Zamora", "Meneses");
            string resultadonombreCompleto3 = estudiante3.obtenerNombreCompleto();

            string apellidoMaterno = estudiante1.apellidoMaterno;

            int idEstudiante = estudiante1.EstudianteId;

            Aritmetica aritmetica1 = new Aritmetica();
            int resultadoSuma = aritmetica1.Suma(10, 30);
            aritmetica1.Saludo();

            Console.ReadLine();
        }
    }
}
