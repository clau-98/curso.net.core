using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Anonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante0S = new Estudiante();
            var estudiante2 = new Estudiante();
            var estudiante3 = new { Id = 1, Nombre = "Ed", ApellidoPaterno = "Perez" };
            Console.WriteLine(estudiante3.Id);
            Console.WriteLine(estudiante3.Nombre);
            Console.WriteLine(estudiante3.ApellidoPaterno);
            

            var estudiante4 = new
            {
                Id = 1,
                Nombre = "Ed",
                ApellidoPaterno = "Perez",
                Direeccion = new { Id =1, city = "Londres", country = "UK" }
                
            };
                Console.WriteLine(estudiante4);

            var estudiantes = new[]{
                new { Id=1, Nombre="Ed", ApellidoPaterno="perez"},
                new { Id=1, Nombre="Ed", ApellidoPaterno="perez"},
                 new { Id=1, Nombre="Ed", ApellidoPaterno="perez"}
            };
            Console.WriteLine(estudiantes);
            IList<Estudiante> ListaEstudiantes = new List<Estudiante>() {
            new Estudiante() { EstudianteId = 1, Nombre = "John", Edad = 18 },
            new Estudiante() { EstudianteId = 2, Nombre = "Steve",  Edad = 21 },
            new Estudiante() { EstudianteId = 3, Nombre = "Bill",  Edad = 18 },
            new Estudiante() { EstudianteId = 4, Nombre = "Ram" , Edad = 20  },
            new Estudiante() { EstudianteId = 5, Nombre = "Ron" , Edad = 21 }
            };
            var consultaEstudiantes = from s in ListaEstudiantes
                           select new { Id =s.EstudianteId, Nombre =s.Nombre };

            foreach (var estudiante in consultaEstudiantes)
                Console.WriteLine("id:" + estudiante.Id+"Nombre"+estudiante.Nombre);
            Console.Read();
        }
    }
    class Estudiante
    {
       
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }

        public int Edad { get; set; }


    }
}
