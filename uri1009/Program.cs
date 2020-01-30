using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario_fixo, tot_vendas, total;

            nome = Console.ReadLine();
            salario_fixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tot_vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = salario_fixo + (tot_vendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);


        }
    }
}
