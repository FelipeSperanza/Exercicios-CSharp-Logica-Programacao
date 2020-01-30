using System;
using System.Globalization;

namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, novoSalario, reajuste, porcentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if ( salario >= 0 && salario <= 400)
            {
                novoSalario = salario + (salario * 0.15);
                reajuste = salario * 0.15;
                porcentual = 15;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em porcentual: " + porcentual + " %");
            }
            else if ( salario >=400.01 && salario <= 800.00)
            {
                novoSalario = salario + (salario * 0.12);
                reajuste = salario * 0.12;
                porcentual = 12;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em porcentual: " + porcentual + " %");
            }
            else if (salario >= 800.01 && salario <= 1200)
            {
                novoSalario = salario + (salario * 0.10);
                reajuste = salario * 0.10;
                porcentual = 10;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em porcentual: " + porcentual + " %");
            }
            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                novoSalario = salario + (salario * 0.07);
                reajuste = salario * 0.07;
                porcentual = 12;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em porcentual: " + porcentual + " %");
            }
            else
            {
                novoSalario = salario + (salario * 0.04);
                reajuste = salario * 0.04;
                porcentual = 12;

                Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em porcentual: " + porcentual + " %");
            }


        }
    }
}
