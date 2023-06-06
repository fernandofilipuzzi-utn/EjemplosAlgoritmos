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
    public class BusquedaInt
    {
        //clave: valor buscado
        //v[]: vector de valores 
        //n: el tamaño del vector menos 1
        //retorno: la posición del valor buscado. Sino lo encontró devuelve -1

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="n"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        static public int BusquedaBinaria(int[] v, int n, int clave)
        {
            int inf = 0;//corregido!
            int sup = n, centro, pos = -1;
            while (inf <= sup && pos < 0)
            {
                centro = (inf + sup) / 2;
                if (v[centro] == clave)
                {
                    pos = centro;
                }
                else
                {
                    if (clave > v[centro])
                    {
                        inf = centro + 1;
                    }
                    else
                    {
                        sup = centro - 1;
                    }
                }
            }
            return pos;
        }
    }
}
