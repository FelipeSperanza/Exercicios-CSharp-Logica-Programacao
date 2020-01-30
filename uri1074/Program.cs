using System;

namespace uri1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, i;

            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                x    = int.Parse(Console.ReadLine());

                if ( x == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if ( x > 0 && x % 2 == 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (x > 0 && x % 2 == 1)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (x < 0 && x % 2 == 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        }
    }
}
