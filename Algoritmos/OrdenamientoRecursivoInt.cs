/*
 * autor:fernando
 * fecha:202306052353
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class OrdenamientoRecursivoInt
    {
        static public void QuickSort(int[] a, int inicio, int fin)
        {
            OrdenamientoInterativoInt.cntMax++;

            #region partición
            int p = a[inicio];
            int m = inicio + 1;
            int n = fin;
            int aux;

            while (m <= n)//hasta que se crucen
            {
                while (m <= fin && p >= a[m]) m++;
                while (n > inicio && p <= a[n]) n--;

                if (m < n)
                {
                    aux = a[m];
                    a[m] = a[n];
                    a[n] = aux;
                }
            }
            a[inicio] = a[n];
            a[n] = p;
            #endregion

            if (inicio < n-1 )
                QuickSort(a, inicio, n - 1);
            if (n+1  < fin)
                QuickSort(a, n + 1, fin);
        }

        static public int[] MergeSort(int[] lista, int inicio, int fin)
        {
            int[] resultado = null;
            if (inicio < fin)
            {
                int centro = (inicio + fin) / 2;
                int[] izq = MergeSort(lista, inicio, centro);
                int[] der = MergeSort(lista, centro + 1, fin);

                //merge            
                //resultado = new int[inicio+fin+1];
                resultado = new int[izq.Length + der.Length];//corregido!

                int n = 0, i = 0, d = 0;
                while (i < izq.Length || d < der.Length)
                {
                    if (d >= der.Length)
                    {
                        resultado[n] = izq[i];
                        i++;
                    }
                    else if (i >= izq.Length)
                    {
                        resultado[n] = der[d];
                        d++;
                    }
                    else if (izq[i] < der[d])
                    {
                        resultado[n] = izq[i];
                        i++;
                    }
                    else
                    {
                        resultado[n] = der[d];
                        d++;
                    }
                    n++;
                }
            }
            else
            {
                resultado = new int[1];
                resultado[0] = lista[inicio];
            }

            return resultado;
        }
    }
}
