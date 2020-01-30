using System;

namespace uri1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, x=0, y=0, z=0;

            n = int.Parse(Console.ReadLine());

            for (i= 0; i < n; i++)
            {
                z = x + y;
                Console.WriteLine(z);
                y = x;
                x = z;
            }


        }
    }
}
