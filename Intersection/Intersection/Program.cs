using System;
using System.Linq;

namespace Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            var intersection = primeiroArray.Except(segundoArray);

            Console.WriteLine("Os números do primeiro array que não estão contidos no segundo são:");

            foreach (var i in intersection)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
}
