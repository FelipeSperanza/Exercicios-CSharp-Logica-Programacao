using System;
using System.Globalization;

namespace vetor04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] vet;

            n = int.Parse(Console.ReadLine());
            vet = new double[n];

            string[] s = Console.ReadLine().Split(' ');

            //gravar dados
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i]);
            }

            //media aritmética
            double media = 0;
            for (int i = 0; i < n; i++)
            {
                media = media + vet[i];
            }
            media = media / n;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i]);
                }
            }



        }
    }
}
