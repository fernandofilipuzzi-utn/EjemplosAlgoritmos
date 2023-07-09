using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MergeValoresIterativo
{
    class Program
    {
        static int[] MergeSortIterativo(int[] lista, int inicio, int fin)
        {
            
            int grupos = (fin - inicio + 2) / 2; //agrupados en izquierdas y derechas
            int @long = 1;//long izq y der

            while (grupos>=1)//mientras queden grupos
            {
                int g = 0;
                int comienzo = 0;
                while (g<grupos)
                {
                    //0 2  4  6 =  [0 1 2 3]+2*long
                    //0    4    =  [0 1]+2*long
                    //0         =  [0]
                    comienzo = g*2*@long;

                    int[] izq = copiar(lista, comienzo, @long);
                    int[] der = copiar(lista, comienzo+ @long, @long);
                    
                    int [] resultado = Merge(izq,der);
                    copiar(resultado, 0, 2*@long, lista, comienzoA:comienzo);

                    g++;
                }

                grupos /= 2;//cada vez que avanzo, me queda la mitad del grupo anterior
                @long *= 2;//cada vez que avanzo, la longitud crece el doble
            }
            
            return lista;
        }

        static int[] copiar(int [] lista, int comienzo, int cant)
        {
            int[] resultado = new int[cant];
            for (int n = 0; n < cant && comienzo + n<lista.Length; n++)
                resultado[n] = lista[comienzo + n];
            return resultado;
        }
        static int[] copiar(int[] desde, int comienzoDesde, int cantDesde, int[] a, int comienzoA)
        {
            for (int n = 0; n < cantDesde && n + comienzoA< a.Length; n++)
            {
                a[n+comienzoA] = desde[n+comienzoDesde];
            }
            return a;
        }

        static public int[] Merge(int[] izq, int[] der)
        {
            int[] resultado = null;
            resultado = new int[izq.Length + der.Length];

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
            return resultado;
        }

        static void Main(string[] args)
        {
            //valores de prueba
            //tiene un error para longitud par
            int[] lista = new[] { 3, 7, 9, 8, 10, 11, 2 , 7};

            Console.WriteLine("Lista desordenada");
            for (int n = 0; n < lista.Length; n++)
                Console.Write("{0} ", lista[n]);
            Console.Write("\n");

            lista = MergeSortIterativo(lista, 0, lista.Length - 1);

            Console.WriteLine("Lista ordenada");
            for (int n = 0; n < lista.Length; n++)
                Console.Write("{0} ", lista[n]);
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}
