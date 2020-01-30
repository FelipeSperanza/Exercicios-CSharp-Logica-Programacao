using System;
using System.Globalization;

namespace uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, num1, cod2, num2;
            double valor1, valor2, total;


            cod1 = int.Parse(Console.ReadLine());
            num1 = int.Parse(Console.ReadLine());
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cod2 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = ((num1 * valor1) + (num2 * valor2));

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
