using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexado
{
    class HashManejoColisionesProgram
    {
        static void Main()
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

            // Crear una tabla hash personalizada utilizando una matriz y encadenamiento
            int size = 20; // Tamaño de la matriz
            LinkedList<int>[] tablaHash = new LinkedList<int>[size];

            // Crear el índice
            for (int i = 0; i < datos.Count; i++)
            {
                string elemento = datos[i];
                int posicion = CalcularPosicionHash(elemento, size);

                // Verificar si la posición ya contiene una lista
                if (tablaHash[posicion] == null)
                {
                    // Crear una nueva lista en la posición
                    tablaHash[posicion] = new LinkedList<int>();
                }

                // Agregar la ubicación del elemento al final de la lista correspondiente
                tablaHash[posicion].AddLast(i);
            }

            // Realizar la búsqueda
            string valorBusqueda = "Cereza";
            int posicionBusqueda = CalcularPosicionHash(valorBusqueda, size);

            if (tablaHash[posicionBusqueda] != null)
            {
                LinkedList<int> ubicaciones = tablaHash[posicionBusqueda];
                foreach (int ubicacion in ubicaciones)
                {
                    string elementoEncontrado = datos[ubicacion];
                    Console.WriteLine($"Elemento encontrado en la ubicación {ubicacion}: {elementoEncontrado}");
                }
            }
            else
            {
                Console.WriteLine("Elemento no encontrado");
            }

            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }

        static int CalcularPosicionHash(string valor, int size)
        {
            int hash = valor.GetHashCode();
            return Math.Abs(hash) % size;
        }
    }
}
