using System;
using System.Globalization;

namespace vetor01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            //gravar dados
            for(int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double maior = 0;
            double posicao = 0;

            for(int i = 0; i < N; i++)
            {
                if(vet[i] > maior)
                {
                    maior = vet[i];
                    posicao = i;

                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);



        }
    }
}
