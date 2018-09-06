using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {

            var est = new Estudiante()
            {
                Id = 1,
                Nombre = "Yo",
                Apellido = "Nose",
                Nota = 2

            };

            Console.ReadKey();
        }
    }
    class Estudiante
    {
        public Estudiante()
        {
        }

        public Estudiante(int id, string nombre, string apellido, int nota)
        {
            Id = id;
            Nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            Apellido = apellido ?? throw new ArgumentNullException(nameof(apellido));
            Nota = nota;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Nota { get; set; }
        public string NombreApellido { get => Nombre + " " + Apellido; }



    }
}
