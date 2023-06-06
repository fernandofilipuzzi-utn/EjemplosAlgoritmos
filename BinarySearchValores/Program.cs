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

namespace BinarySearchValores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region valores de prueba
            int[] lista = new[] { 3, 8, 7, 1, 2, 0 };
           
            Console.WriteLine("Lista de prueba ordenada");
            for (int n = 0; n < lista.Length; n++)
                Console.Write("{0} ", lista[n]);
            Console.Write("\n");

            Console.WriteLine("-- Casos de prueba de búsqueda ----");
            int idx, clave;
            string resultado;
            #endregion

            OrdenamientoRecursivoInt.QuickSort(lista, 0, lista.Length - 1);

            clave = 2;
            idx = BusquedaInt.BusquedaBinaria(lista, lista.Length - 1, clave);
            #region resultado caso 1
            resultado = "Si";
            if (idx < 0) resultado = "No";
            Console.WriteLine($"Caso 1- Valor: {clave} {resultado} encontrado (posición: {idx})");
            #endregion

            clave = 6;
            idx = BusquedaInt.BusquedaBinaria(lista, lista.Length - 1, clave);
            #region resultado caso 2
            resultado = "Si";
            if (idx < 0) resultado = "No";
            Console.WriteLine($"Caso 1- Valor: {clave} {resultado} encontrado (posición: {idx})");
            #endregion

            Console.ReadKey();
        }
    }

}
