using System;
using System.Globalization;

namespace uri1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double resultado = 0;

            n = int.Parse(Console.ReadLine());

            for ( i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);

                if (b == 0)
                {
                    Console.WriteLine("Impossivel calcular");
                }
                else
                {
                    resultado = a / b;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                } 
            }                        
        }
    }
}
