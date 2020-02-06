using System;
using System.Globalization;

namespace vetor08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double[] altura;
            char[] sexo;

            n = int.Parse(Console.ReadLine());
            altura = new double[n];
            sexo = new char[n];

            for(int i = 0; i<n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(s[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(s[1]);
            }

            double menorAltura = 999.0;
            double maiorAltura = 0.0;
            for(int i = 0; i<n; i++)
            {
                if(altura[i] > maiorAltura)
                {
                    maiorAltura = altura[i];
                }
                else if(altura[i] < menorAltura)
                {
                    menorAltura = altura[i];
                }
                
            }

            double homens = 0;
            double mulheres = 0;
            double soma = 0.0;
            double mediaMulheres = 0.0;
            
            
            for(int i = 0; i<n; i++)
            {
                if (sexo[i] == 'F')
                {
                    soma = soma + altura[i];
                    mulheres += 1;
                }
                else
                {
                    homens += 1;
                }
            }

            mediaMulheres = soma / mulheres;

            Console.WriteLine("Menor altura: " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura: " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres: " + mediaMulheres.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens: " + homens); ;


        }
    }
}
