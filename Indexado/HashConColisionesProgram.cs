using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexado
{
    class HashConColisionesProgram
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

            // Crear una tabla hash personalizada utilizando una matriz
            int size = 20; // Tamaño de la matriz
            List<int>[] tablaHash = new List<int>[size];

            // Crear el índice
            for (int i = 0; i < datos.Count; i++)
            {
                string elemento = datos[i];
                int posicion = CalcularPosicionHash(elemento, size);

                // Verificar si la posición ya contiene una lista
                if (tablaHash[posicion] == null)
                {
                    // Crear una nueva lista en la posición
                    tablaHash[posicion] = new List<int>();
                }

                // Agregar la ubicación del elemento a la lista correspondiente
                tablaHash[posicion].Add(i);
            }

            //esta implementación básica de una tabla hash no aborda las colisiones de hash. 
            // Realizar la búsqueda
            string valorBusqueda = "Cereza";
            int posicionBusqueda = CalcularPosicionHash(valorBusqueda, size);

            if (tablaHash[posicionBusqueda] != null)
            {
                List<int> ubicaciones = tablaHash[posicionBusqueda];
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
