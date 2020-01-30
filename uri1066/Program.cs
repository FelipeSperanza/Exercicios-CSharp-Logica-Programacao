using System;

namespace uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, positivos, negativos, pares, impares;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            positivos = 0;
            negativos = 0;
            pares = 0;
            impares = 0;

            if (n1 > 0)
            {
                positivos += 1;
                if(n1 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }

            }
            else
            {
                negativos += 1;
                if (n1 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
            }
            if (n2 >= 0)
            {
                positivos += 1;
                if (n2 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }

            }
            else
            {
                negativos += 1;
                if (n2 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
            }
            if (n3 > 0)
            {
                positivos += 1;
                if (n3 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }

            }
            else
            {
                negativos += 1;
                if (n3 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
            }
            if (n4 > 0)
            {
                positivos += 1;
                if (n4 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }

            }
            else
            {
                negativos += 1;
                if (n4 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
            }
            if (n5 > 0)
            {
                positivos += 1;
                if (n5 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }

            }
            else
            {
                negativos += 1;
                if (n5 % 2 == 0)
                {
                    pares += 1;
                }
                else
                {
                    impares += 1;
                }
            }


            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");

        }
    }
}
