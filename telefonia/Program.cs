using System;

namespace telefonia
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos, conta;

            minutos = int.Parse(Console.ReadLine());
            conta = 50;

            if (minutos > 100)
            {
                conta += conta + (minutos - 100) * 2;
            }

            Console.WriteLine("Valor a pagar: R$ " + conta);
            Console.ReadLine();
        }
    }
}
