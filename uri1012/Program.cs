using System;
using System.Globalization;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TRIANGULO = (A * C) / 2;
            CIRCULO = C * C * 3.14159;
            TRAPEZIO = ((A + B) * C) / 2;
            QUADRADO = B * B;
            RETANGULO = A * B;

            Console.WriteLine("TRIANGULO: " +TRIANGULO.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("CIRCULO: " +CIRCULO.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("TRAPEZIO: " +TRAPEZIO.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("QUADRADO: " +QUADRADO.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("RETANGULO: " +RETANGULO.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}
