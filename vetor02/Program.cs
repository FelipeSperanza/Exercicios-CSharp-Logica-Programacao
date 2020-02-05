using System;

namespace vetor02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            

            N = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');

            int[] par = new int[N];

            //gravar dados
            for(int i = 0; i<N; i++)
            {
                par[i] = int.Parse(s[i]);
            }

            //ler dados

            int pares = 0;
            for (int i = 0; i < N; i++)
            {
                if(par[i] % 2 == 0)
                {
                    Console.Write(par[i] + " ");                    
                    pares += 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine(pares);

            

        }
    }
}
