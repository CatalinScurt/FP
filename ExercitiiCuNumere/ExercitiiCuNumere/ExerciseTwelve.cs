using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseTwelve
    {
        public static void GetResultNumber12()
        {
            int a, b, n;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = a; i <= b; i++)
            {
                if(i % n ==0)
                {
                    Console.WriteLine($"Numarul {i} este divizibil cu {n}");
                    contor++;
                }
            }
            Console.WriteLine($"In intervalul[{a},{b}] sunt {contor} numere divizibile cu {2}");
        }
    }
}
