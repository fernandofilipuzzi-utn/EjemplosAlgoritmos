using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona
    {
        public string nombre { get; set; }
        public int dni { get; set; }

        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public string Ver()
        {
            return nombre + "(" + dni + ")";
        }

    }
}
