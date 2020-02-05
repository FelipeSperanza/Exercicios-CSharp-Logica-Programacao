using System;

namespace vetor03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] a;
            int[] b;
            int[] c;

            n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            string[] ss = Console.ReadLine().Split(' ');
            a = new int[n];
            b = new int[n];
            c = new int[n];




            //gravar dados vetor a
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }

            //gravar dados vetor b
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(ss[i]);
            }

            //soma vetores
            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] + b[i];
            }

            //mostrar vetor
            for (int i = 0; i < n; i++)
            {
                Console.Write(c[i] + " ");
            }

            Console.ReadLine();

        }
    }
}
