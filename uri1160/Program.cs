using System;
using System.Globalization;

namespace uri1160
{
    class Program
    {
        static void Main(string[] args)
        {

            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                int PA = int.Parse(vet[0]);
                int PB = int.Parse(vet[1]);
                double G1 = int.Parse(vet[2], CultureInfo.InvariantCulture);
                double G2 = int.Parse(vet[3], CultureInfo.InvariantCulture);

                if (PA > PB)
                {
                    int totalA = PA + (int)(PA * G1);
                }


            }

        }
    }
}
