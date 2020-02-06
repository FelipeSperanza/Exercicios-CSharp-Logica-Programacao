using System;
using System.Globalization;

namespace vetor04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            n = int.Parse(Console.ReadLine());
            double[] vet = new double[n];
            string[] s = Console.ReadLine().Split(' ');

            //gravar dados
            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            //media
            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma = soma + vet[i];
            }

            double media = soma / n;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < n; i++)
            {
                if (vet[i] < media)
                {
                    Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }

        }
    }
}
