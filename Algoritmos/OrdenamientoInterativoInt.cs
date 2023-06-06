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
    public class OrdenamientoInterativoInt
    {
        /*interrogantes: que tanto crece la pila*/
        static public int cntMax = 0;

        static public void QuickSort(int[] a, int l, int r)
        {
            int[] stack = new int[a.Length];
            int cnt = 0;

            //push - salvo los argumentos del quick
            stack[cnt++] = l;
            stack[cnt++] = r;

            //
            while (cnt > 0)
            {
                #region pop - los datos de la cabecera 
                r = stack[--cnt];//pop=saca el último
                l = stack[--cnt];//pop=saca el primero
                #endregion

                #region este bloque lo que hace el quick tradicional 
                #region recalculando
                int p = a[l];
                int m = l + 1;
                int n = r;
                int aux = 0;
                #endregion

                while (m <= n)//hasta que se igualen
                {
                    while (m <= r && p >= a[m]) m++;
                    while (n > l && p <= a[n]) n--;

                    if (m < n)
                    {
                        aux = a[m];
                        a[m] = a[n];
                        a[n] = aux;
                    }
                }
                a[l] = a[n];
                a[n] = p;

                if (l <= n - 1)//agregado por fuera de rango!
                {
                    #region push los argumentos : que serían los extremos
                    //quickSort(a, l, n - 1);
                    stack[cnt++] = l;
                    stack[cnt++] = n - 1;
                    #endregion
                }
                if (n + 1 <= r) //agregado por fuera de rango!
                {
                    #region push los argumentos : que serían los extremos
                    //quickSort(a, n + 1, r);
                    stack[cnt++] = n + 1;
                    stack[cnt++] = r;
                    #endregion
                }
                #endregion

                //busco el máximo crecimiento del cnt
                if (cntMax < cnt) cntMax = cnt;
            }
        }
    }
}
