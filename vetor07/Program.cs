using System;
using System.Globalization;

namespace vetor07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] nomes;
            double[] nota1;
            double[] nota2;

            n = int.Parse(Console.ReadLine());
            nomes = new string[n];
            nota1 = new double[n];
            nota2 = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            double[] media = new double[n];
            for(int i = 0; i<n; i++)
            {
                media[i] = (nota1[i] + nota2[i]) / 2.0;
            }

            for(int i = 0; i<n; i++)
            {
                if(media[i] >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }


            Console.ReadLine();

        }
    }
}
