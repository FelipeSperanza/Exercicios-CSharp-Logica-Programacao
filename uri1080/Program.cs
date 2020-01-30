using System;

namespace uri1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, maior = 0;

            for (i = 0; i <5; i++)
            {
                n = int.Parse(Console.ReadLine());

                if ( n > maior)
                {
                    maior = n;
                } 
            }

            Console.WriteLine(maior);
            Console.WriteLine(i);
        }
    }
}
