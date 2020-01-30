using System;

namespace uri1155
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, soma=0, total;

            n = 100;

            for (i = 1; i<= 100; i++)
            {
                soma = (i + 1) / ((i + 1) + 1);
            }

            Console.WriteLine(soma);
        }
    }
}
