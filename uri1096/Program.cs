using System;

namespace uri1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j = 5;

            for ( i = 0; i < j+6; i++)
            {
                Console.WriteLine("I = " + i + " J = " + j );

                j--;
            }
        }
    }
}
