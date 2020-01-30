using System;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valor;

            string[] vet = Console.ReadLine().Split(' ');

            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if ( codigo == 1)
            {
                valor = quantidade * 4.00;
            }
            else if( codigo == 2)
            {
                valor = quantidade * 4.50;
            }
            else if ( codigo == 3)
            {
                valor = quantidade * 5.00;
            }
            else if ( codigo == 4)
            {
                valor = quantidade * 2.00;
            }
            else
            {
                valor = quantidade * 1.50;
            }

            Console.WriteLine("Total: R$ " + valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
