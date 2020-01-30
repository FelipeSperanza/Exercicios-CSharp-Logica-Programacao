using System;
using System.Globalization;

namespace uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont = 0, soma = 0;
            double media;

            idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (idade > 0)
            {
                soma = soma + idade;
                cont = cont + 1;

                idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            media = soma / cont;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture)); ;
        }
    }
}
