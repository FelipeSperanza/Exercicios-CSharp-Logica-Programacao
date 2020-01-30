using System;

namespace uri1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            double quadrado;

            n = int.Parse(Console.ReadLine());

            for ( i = 1; i <= n; i++)
            {
                if ( i % 2 == 0)
                {
                    quadrado = Math.Pow(i, 2);
                    Console.WriteLine(quadrado);
                }
            }



        }
    }
}
