using System;

namespace uri1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, soma = 0, j;

            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                int inicio = x;

                for (j = 0; j < y; j++)
                {
                    if (inicio % 2 == 1)
                    {
                        soma = soma + inicio;
                        inicio = inicio + 1;
                    }
                    inicio = inicio + 1;
                }

                Console.WriteLine(soma);

            }
        }
    }
}
