using System;

namespace matriz03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] a;

            n = int.Parse(Console.ReadLine());
            a = new int[n, n];

            for(int i =0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j =0; j<n; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }


            for(int i = 0; i<n; i++)
            {
                int maior = 0;
                for(int j = 0; j<n; j++)
                {
                    if(a[i,j] > maior)
                    {
                        maior = a[i, j]; 
                    }
                }
                Console.WriteLine(maior);
            }

            Console.ReadLine();

        }
    }
}
