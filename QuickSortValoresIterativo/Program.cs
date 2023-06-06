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

namespace QuickSortValoresIterativo
{
    class Program
    {
        
        static Random azar = new Random();
 
        static void Main(string[] args)
        {
            #region inicialización y generación de valores
            int[] valores = new int[1000000];
            for (int n = 0; n < valores.Length; n++)
                valores[n] = azar.Next(0, 10000 * valores.Length);
            #endregion
         
            #region impresión valores generados
            Console.WriteLine("Valores no ordenados");
            for (int n = 0; n < valores.Length; n++)
                Console.WriteLine(string.Format(" {0:0000000000} ", valores[n]));
            Console.WriteLine("---------------------");
            OrdenamientoInterativoInt.cntMax = 0;
            #endregion

            //OrdenamientoInterativoInt.QuickSort(valores, 0, valores.Length - 1);
            OrdenamientoRecursivoInt.QuickSort(valores, 0, valores.Length - 1);
           
            #region impresión valores ordenados
            Console.WriteLine("Valores ordenados");
            for (int n = 0; n < valores.Length; n++)
                Console.WriteLine(string.Format(" {0:0000000000} ", valores[n]));
            Console.WriteLine("Fin");
            Console.WriteLine("---------------------");
            #endregion

            Console.WriteLine("Maximo crecimeinto de la pila:{0}", OrdenamientoInterativoInt.cntMax);

            Console.ReadKey();
        }
    }
}
