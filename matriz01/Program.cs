using System;

namespace matriz01
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] matriz;
            string[] s = Console.ReadLine().Split(' ');

            m = int.Parse(s[0]);
            n = int.Parse(s[1]);

            matriz = new int[m, n];

            for(int i = 0; i <m; i++)
            {
                s = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            for(int i = 0; i<m; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if(matriz[i,j] < 0)
                    {
                        Console.WriteLine(matriz[i,j]);
                    }
                }
            }

        }
    }
}
