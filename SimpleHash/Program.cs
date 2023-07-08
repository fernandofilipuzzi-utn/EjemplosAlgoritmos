using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHash
{
    public class SimpleHashAlgorithm
    {
        public static int CalculateHash(string input)
        {
            int hash = 0;

            for (int i = 0; i < input.Length; i++)
            {
                hash += (int)input[i]; // Suma el valor ASCII de cada carácter
            }

            return hash % 100; // Realiza una operación de módulo para obtener un valor entre 0 y 99
        }
    }

    class Program
    {
        static void Imprimir(string data)
        {
            int hashValue = SimpleHashAlgorithm.CalculateHash(data);

            Console.WriteLine($"Data: {data}");
            Console.WriteLine($"Hash Value: {hashValue}");
        }
        static void Main(string[] args)
        {
            string data = "Hello, World!";
            Imprimir(data);

            char[] a = data.ToCharArray();
            Array.Reverse(a);

            Imprimir(new string(a));

            Console.ReadKey();
        }
    }
}
