﻿using System;

namespace uri1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            n = int.Parse(Console.ReadLine());

            for ( i = 1; i <= n; i++)
            {
                if ( n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
