/*
 * autor:fernando
 * fecha:202306052353
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Algoritmos;

namespace QuickSortEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region valores de prueba
            int[] lista = new[] { 5, 8, 7, 1, 9, 3, -2, 2, 11, 14, 13, 0, 6, 15, 12, 4,-1, 10};

            Console.WriteLine("Lista desordenada");
            for (int n= 0; n < lista.Length; n++)
            Console.Write("{0} ", lista[n]);
            Console.Write("\n");
            #endregion

            OrdenamientoRecursivoInt.QuickSort(lista, 0, lista.Length -1);

            #region imprimiendo resultados
            Console.WriteLine("Lista ordenada");
            for (int n= 0; n < lista.Length; n++)
            Console.Write("{0} ", lista[n]);
            Console.Write("\n");
            #endregion

            Console.ReadKey();
        }
    }
}
