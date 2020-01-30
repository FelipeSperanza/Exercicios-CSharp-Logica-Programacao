using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, fim, horas;

            string[] vet = Console.ReadLine().Split(' ');

            inicio = int.Parse(vet[0]);
            fim = int.Parse(vet[1]);

            if (inicio > fim)
            {
                horas = (24 - inicio) + fim;
            }
            else if (inicio == fim)
            {
                horas = 24;
            }
            else
            {
                horas = fim - inicio;
            }

            Console.WriteLine("O JOGO DUROU " + horas + " HORA(S)");
        }
    }
}
