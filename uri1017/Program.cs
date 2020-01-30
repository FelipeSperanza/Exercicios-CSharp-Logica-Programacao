using System;
using System.Globalization;

namespace uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double litros, tempo, velocidade;

            tempo = double.Parse(Console.ReadLine());
            velocidade = double.Parse(Console.ReadLine());

            litros = ((tempo * velocidade) / 12);

            Console.WriteLine(litros.ToString("F3"), CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
