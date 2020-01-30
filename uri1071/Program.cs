using System;

namespace uri1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, i, soma=0, maior, menor;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

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

            for ( i = menor + 1 ; i < maior; i++)
            {
                if ( i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);

        }
    }
}
