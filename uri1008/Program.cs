using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, HOURS;
            double VALOR_HORA, SALARY;

            NUMBER = int.Parse(Console.ReadLine());
            HOURS = int.Parse(Console.ReadLine());
            VALOR_HORA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARY = HOURS * VALOR_HORA;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2"),CultureInfo.InvariantCulture);




        }
    }
}
