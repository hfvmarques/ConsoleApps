using System;

namespace CollatzProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            long larger = 0, bigger = 0;

            for (int i = 1; i<=1000000;i++)
            {
                long counter = 1, aux = i;

                while (aux != 1)
                {
                    var even = aux % 2;

                    if (even == 0)
                    {
                        aux /= 2;
                        counter++;
                    }
                    else
                    {
                        aux = (aux * 3) + 1;
                        counter++;
                    }

                } 

                if (counter > larger)
                {
                    larger = counter;
                    bigger = i;
                }
            }

            Console.WriteLine("O maior array contém " + larger + " elementos.");
            Console.WriteLine("O número que gera o maior array é o " + bigger + ".");
            Console.ReadLine();
        }
    }
}
