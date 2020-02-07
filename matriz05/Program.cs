using System;

namespace matriz05
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            string[] s = Console.ReadLine().Split(' ');

            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            int[,] A = new int[M,N];
            int[,] B = new int[M,N];
            int[,] C = new int[M,N];
            

            // MATRIZ A
            for(int i = 0; i<M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for(int j = 0; j<N; j++)
                {
                    A[i,j] = int.Parse(s[j]);
                }
            }

            // MATRIZ B
            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(s[j]);
                }
            }

            // MATRIZ C
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C[i, j] = A[i,j] + B[i,j];
                }
            }

            //MOSTRAR
           for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(C[i,j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
