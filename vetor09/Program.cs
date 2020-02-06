using System;
using System.Globalization;

namespace vetor09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] produto;
            double[] precoCompra;
            double[] precoVenda;

            n = int.Parse(Console.ReadLine());

            produto = new string[n];
            precoCompra = new double[n];
            precoVenda = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                produto[i] = s[0];
                precoCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            int abaixo = 0;
            int entre = 0;
            int acima = 0;


            for (int i = 0; i < n; i++)
            {
                if ((precoVenda[i] / precoCompra[i]) - 1 <= 10)
                {
                    abaixo += 1;
                }
                else if ((precoVenda[i] / precoCompra[i]) - 1 >= 10 && (precoVenda[i] / precoCompra[i]) - 1 <= 20)
                {
                    entre += 1;
                }
                else
                {
                    acima += 1;
                }

            }

            //valor total compra
            double totCompra = 0.0;
            for (int i = 0; i < n; i++)
            {
                totCompra = totCompra + precoCompra[i];
            }

            //valor total venda
            double totVenda = 0.0;
            for (int i = 0; i < n; i++)
            {
                totVenda = totVenda + precoVenda[i];
            }

            //lucro total
            double lucro = 0;
            lucro = totVenda - totCompra;

            Console.WriteLine("Lucro abaixo de 10% " + abaixo);
            Console.WriteLine("Lucro entre 10% e 20% " + entre);
            Console.WriteLine("Lucro acima de 20% " + acima);
            Console.WriteLine("Valor total de compra: " + totCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
using System;
using System.Globalization;

namespace vetor09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] produto;
            double[] precoCompra;
            double[] precoVenda;

            n = int.Parse(Console.ReadLine());

            produto = new string[n];
            precoCompra = new double[n];
            precoVenda = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                produto[i] = s[0];
                precoCompra[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            int abaixo = 0;
            int entre = 0;
            int acima = 0;


            for (int i = 0; i < n; i++)
            {
                if ((precoVenda[i] / precoCompra[i]) - 1 <= 10)
                {
                    abaixo += 1;
                }
                else if ((precoVenda[i] / precoCompra[i]) - 1 >= 10 && (precoVenda[i] / precoCompra[i]) - 1 <= 20)
                {
                    entre += 1;
                }
                else
                {
                    acima += 1;
                }

            }

            //valor total compra
            double totCompra = 0.0;
            for (int i = 0; i < n; i++)
            {
                totCompra = totCompra + precoCompra[i];
            }

            //valor total venda
            double totVenda = 0.0;
            for (int i = 0; i < n; i++)
            {
                totVenda = totVenda + precoVenda[i];
            }

            //lucro total
            double lucro = 0;
            lucro = totVenda - totCompra;

            Console.WriteLine("Lucro abaixo de 10% " + abaixo);
            Console.WriteLine("Lucro entre 10% e 20% " + entre);
            Console.WriteLine("Lucro acima de 20% " + acima);
            Console.WriteLine("Valor total de compra: " + totCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucro.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
