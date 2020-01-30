using System;

namespace uri1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i;

            x = int.Parse(Console.ReadLine());

            for ( i = 0 ; i<=x ; i++)
            {
                if ( i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
