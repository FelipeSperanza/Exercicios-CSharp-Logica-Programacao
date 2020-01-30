using System;

namespace menorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, menor;

            string[] vet = Console.ReadLine().Split(' ');

            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            num3 = int.Parse(vet[2]);

            if(num1 < num2 && num1 < num3)
            {
                menor = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }

            Console.WriteLine("MENOR = " + menor);

        }
    }
}
