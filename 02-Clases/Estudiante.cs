using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    class Estudiante
    {
        int id;

        public int EstudianteId
        {
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
            get
            {
                return this.id;
            }
        }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }

        public string obtenerNombreCompleto()
        {
            string nombreCompleto = this.nombre + " " + this.apellidoPaterno + " " + this.apellidoMaterno;

            return nombreCompleto;
        }

        public Estudiante()
        {
            Console.WriteLine("se creo un objeto estudiante");
            this.nombre = "";
            this.apellidoPaterno = "";
            this.apellidoMaterno = "";
        }
        public Estudiante(int id, string nombre, string apellidoPaterno, string apellidoMaterno)
        {
            Console.WriteLine("se creo un objeto estudiante");
            this.id = id;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;

        }

    }
}
