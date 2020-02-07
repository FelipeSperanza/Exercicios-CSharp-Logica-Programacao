using System;

namespace matriz04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] matriz;

            n = int.Parse(Console.ReadLine());

            matriz = new int[n, n];

            for(int i = 0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }


            int soma = 0;
            for(int i = 0; i<n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    if(j > i)
                    {
                        soma = soma + matriz[i, j];
                    }
                }
            }

            Console.WriteLine(soma);

        }
    }
}
