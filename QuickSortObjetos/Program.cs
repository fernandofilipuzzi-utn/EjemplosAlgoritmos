using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        #region método de ordenamiento

        static public void QuickSort(Persona[] lista, int inicio, int fin)
        {
            //partición
            Persona p = lista[inicio];
            int m = inicio + 1;
            int n = fin;
            Persona aux;

            while (m <= n)//hasta que se crucen
            {
                while (m <= fin && p.dni >= lista[m].dni) m++;
                while (n > inicio && p.dni <= lista[n].dni) n--;

                if (m < n)
                {
                    aux = lista[m];
                    lista[m] = lista[n];
                    lista[n] = aux;
                }
            }
            lista[inicio] = lista[n];
            lista[n] = p;
            //fin partición

            if (inicio <= n - 1)
                QuickSort(lista, inicio, n - 1);
            if (n + 1 <= fin)
                QuickSort(lista, n + 1, fin);
        }

        #endregion


        static void Main(string[] args)
        {
            //valores de prueba
            Persona[] lista = new Persona[]{
             new Persona(20100001, "juan"),
             new Persona(20100003, "martin"),
             new Persona(10100001, "susana")
            };

            Console.WriteLine("Lista desordenada");
            for (int n = 0; n < lista.Length; n++)
                Console.WriteLine("{0} ", lista[n].Ver());
            Console.Write("\n");

            QuickSort(lista, 0, lista.Length - 1);

            Console.WriteLine("Lista ordenada");
            for (int n = 0; n < lista.Length; n++)
                Console.WriteLine("{0} ", lista[n].Ver());
            Console.Write("\n");

            Console.ReadKey();
        }

    }
}
