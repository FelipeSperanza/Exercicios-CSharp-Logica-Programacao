using System;

namespace vetor06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] nomes;
            int[] idades;

            n = int.Parse(Console.ReadLine());
            nomes = new string[n];
            idades = new int[n];
                      
            //gravar dados
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nomes[i] = s[0];
                idades[i] = int.Parse(s[1]);
            }

            int maisVelho = 0;
            string nome = "";
            for (int i = 0; i < n; i++)
            {
                if (idades[i] > maisVelho)
                {
                    maisVelho = idades[i];
                    nome = nomes[i];
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nome);

            Console.ReadLine();
        }
    }
}
