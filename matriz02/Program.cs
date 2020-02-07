using System;

namespace matriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] a;
            
            

            n = int.Parse(Console.ReadLine());
            a = new int[n, n];
            

           for(int i = 0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[n];
           
           for(int i = 0; i<n; i++)
            {
                int soma = 0;
                for (int j = 0; j<n; j++)
                {
                    soma = soma + a[i, j];
                }
                vet[i] = soma;
                Console.WriteLine(vet[i]);
            }

            Console.ReadLine();

        }
    }
}
