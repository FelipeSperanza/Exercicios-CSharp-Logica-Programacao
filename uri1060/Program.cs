using System;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6, cont;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());
            n6 = int.Parse(Console.ReadLine());

            cont = 0;

            if (n1 > 0)
            {
                cont += 1;
            }
            if (n2 > 0)
            {
                cont += 1;
            }
            if (n3 > 0)
            {
                cont += 1;
            }
            if (n4 > 0)
            {
                cont += 1;
            }
            if (n5 > 0)
            {
                cont += 1;
            }
            if (n6 > 0)
            {
                cont += 1;
            }

            Console.WriteLine(cont + " valores positivos");
        }
    }
}
