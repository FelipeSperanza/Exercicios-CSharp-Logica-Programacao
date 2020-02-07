using System;
using System.Globalization;

namespace matriz06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, linha, coluna;
            double[,] matriz;

            n = int.Parse(Console.ReadLine());

            matriz = new double[n, n];

            
            //gravar dados matriz
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    matriz[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            //somar positivos
            double soma = 0;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if(matriz[i,j] > 0)
                    {
                        soma = soma + matriz[i, j];
                    }
                }
            }

            Console.WriteLine(soma.ToString("F1",CultureInfo.InvariantCulture));


        }
    }
}
