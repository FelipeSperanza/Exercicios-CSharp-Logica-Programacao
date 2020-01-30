using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uri1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, j, maior = 0, menor = 0, soma = 0;

            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (x > y)
                {
                    maior = x;
                    menor = y;
                }
                else
                {
                    maior = y;
                    menor = x;
                }

                for (j = menor + 1; j < maior; j++)
                {
                    if (j % 2 == 1)
                    {
                        soma = soma + j;
                    }

                }
                Console.WriteLine(soma);
                soma = 0;
            }
            Console.ReadLine();
        }
    }
}
