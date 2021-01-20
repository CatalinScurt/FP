using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex1
    {
        public static void Result1()
        {
            Console.WriteLine("Introduceti numarul de elemente ale vectorului");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int s = 0;
            Console.WriteLine("Introduceti elementele din vector:");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                s += v[i];
            }
            Console.WriteLine(s);
        }
    }
}
