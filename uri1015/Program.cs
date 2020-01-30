using System;
using System.Globalization;
namespace uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            double x1, x2, y1, y2, distancia;

            string[] vet = Console.ReadLine().Split(' ');

            x1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            x2 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet[1], CultureInfo.InvariantCulture);


            distancia = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));


            Console.WriteLine(distancia.ToString("F4"), CultureInfo.InvariantCulture);

        }
    }
}
