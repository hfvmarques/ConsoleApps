using System;
using System.Linq;

namespace SomenteImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

            var odd = numeros.Where(x => x % 2 == 0);
            var qnt = odd.Count();

            if (qnt == 0)
            {
                Console.WriteLine("Este array possui somente números ímpares.");
            }
            else
            {
                Console.WriteLine("Este array possui os seguintes números pares:");
                foreach (var p in odd)
                {
                    Console.Write(p+" ");
                }
            }
            Console.ReadLine();
        }
    }
}
