using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDictionary dictionary = new CustomDictionary();

            // Agregar elementos al diccionario
            dictionary.Add("Juan", 25);
            dictionary.Add("María", 30);
            dictionary.Add("Juan1", 30);
            // ...

            // Obtener valores del diccionario
            int edadJuan = dictionary.Get("Juan");
            int edadMaría = dictionary.Get("María");

            Console.WriteLine($"La edad de Juan es {edadJuan}.");
            Console.WriteLine($"La edad de María es {edadMaría}.");

            Console.ReadKey();
        }
    }
}
