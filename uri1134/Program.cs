using System;

namespace uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while ( tipo != 4)
            {
                if ( tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if ( tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(alcool);
            Console.WriteLine(gasolina);
            Console.WriteLine(diesel);

        }
    }
}
