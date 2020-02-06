using System;
using System.Globalization;

namespace vetor05
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] vet = new int[N];

            //gravar os dados
            for(int i = 0; i<N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            //media pares
            double cont = 0.0;
            double media = 0.0;
            for(int i =0; i<N; i++)
            {
                
                if(vet[i] % 2 == 0)
                {
                    media = media + vet[i];
                    cont += 1;
                }
            }

            media = media / cont;

            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
