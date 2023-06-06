using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algoritmos;

namespace MergeSortValores
{
    class Program
    {
        static void Main(string[] args)
        {
            //valores de prueba
            int[] lista = new[] { 3, 8, 7, 1, 2, 3 };

            Console.WriteLine("Lista desordenada");
            for (int n = 0; n < lista.Length; n++)
                Console.Write("{0} ", lista[n]);
            Console.Write("\n");

            lista = OrdenamientoRecursivoInt.MergeSort(lista, 0, lista.Length - 1);

            Console.WriteLine("Lista ordenada");
            for (int n = 0; n < lista.Length; n++)
                Console.Write("{0} ", lista[n]);
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}
