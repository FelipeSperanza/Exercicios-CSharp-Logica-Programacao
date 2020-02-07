using System;
using System.Globalization;

namespace matriz06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, linha, coluna;
            double[,] matriz;

            n = int.Parse(Console.ReadLine());

            matriz = new double[n, n];

            
            //gravar dados matriz
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for(int j = 0; j<n; j++)
                {
                    matriz[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            linha = int.Parse(Console.ReadLine());
            coluna = int.Parse(Console.ReadLine());

            //somar positivos
            double soma = 0;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if(matriz[i,j] > 0)
                    {
                        soma = soma + matriz[i, j];
                    }
                }
            }

            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            //imprimir linha
            Console.Write("LINHA ESCOLIDA ");
            for(int i = linha; i<=linha; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }

            //imprimir coluna
            Console.Write("COLUNA ESCOLIDA ");
            for (int i = 0; i<n; i++)
            {
                for(int j = coluna; j <= coluna; j++)
                {
                    Console.Write(matriz[i,j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
            }
            Console.WriteLine();

            //Diagonal principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for(int i = 0; i < n; i++)
            {
                for(int j =0; j<n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i,j].ToString("F1", CultureInfo.InvariantCulture) + " ");;
                    }
                }
            }

            Console.WriteLine();

            Console.Write("MATRIZ INVERTIDA: ");
            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    if(matriz[i,j] < 0.0)
                    {
                        matriz[i,j] = Math.Pow(matriz[i, j], 2);
                    }
                    Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                
                Console.WriteLine();
            }


            Console.WriteLine();
        }
    }
}
