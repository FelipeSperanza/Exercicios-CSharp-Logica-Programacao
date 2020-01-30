using System;

namespace uri1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, maior, menor, soma=0;

            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if ( x > y)
                {
                    maior = x;
                    menor = y;
                }
                else
                {
                    maior = y;
                    menor = x;
                }

                menor = menor + 1;

                for(i = menor; i < maior; menor++)
                {
                    if(menor % 2 == 1)
                    {
                        soma = soma + i;
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }

                Console.WriteLine(soma);


            }

        }
    }
}
