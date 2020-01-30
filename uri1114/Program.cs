using System;

namespace uri1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002, teste;

            teste = int.Parse(Console.ReadLine());

            while (teste != senha)
            {
                Console.WriteLine("Senha Invalida");

                teste = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");


        }
    }
}
