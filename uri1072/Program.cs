using System;

namespace uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, fora = 0, dentro = 0;

            n = int.Parse(Console.ReadLine());

            for ( i = 0 ; i < n; i++)
            {
                n = int.Parse(Console.ReadLine());

                if ( n >=10 && n <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
