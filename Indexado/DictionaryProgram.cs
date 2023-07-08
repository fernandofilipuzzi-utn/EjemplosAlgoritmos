using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexado
{
    class DictionaryProgram
    {
        static void Main(string[] args)
        {
            // Datos de ejemplo
            List<string> datos = new List<string>
            {
                "Manzana",
                "Banana",
                "Cereza",
                "Damasco",
                "Durazno"
            };

            // Crear el índice
            Dictionary<string, int> indice = new Dictionary<string, int>();
            for (int i = 0; i < datos.Count; i++)
            {
                string elemento = datos[i];
                indice[elemento] = i;
            }

            // Realizar la búsqueda
            string valorBusqueda = "Cereza";
            if (indice.ContainsKey(valorBusqueda))
            {
                int ubicacion = indice[valorBusqueda];
                string elementoEncontrado = datos[ubicacion];
                Console.WriteLine($"Elemento encontrado: {elementoEncontrado}");
            }
            else
            {
                Console.WriteLine("Elemento no encontrado");
            }

            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
