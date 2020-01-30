using System;

namespace uri1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
              
                Console.WriteLine(i + " " + i * i + " " + i * i * i);
                Console.WriteLine(i + " " + (i * i + 1) + " " + (i * i * i + 1));
            }
        }
    }
}
