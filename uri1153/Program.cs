using System;

namespace uri1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, fat = 1;

            n = int.Parse(Console.ReadLine());

            for ( i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
              
        }       
    }
}
