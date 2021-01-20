using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex17
    {
        public static void Result17()
        {
            Console.WriteLine("Numarul in baza 10");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Baza");
            int b = int.Parse(Console.ReadLine());
            int rest;
            int[] v = new int[n];
            int i = 0;
            while (n != 0)
            {
                rest = n % b;
                n = n / b;
                v[i] = rest;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                if (v[j] < 10)
                    Console.Write(v[j]);
                else if (v[j] >= 10)
                    Console.Write((char)(v[j] + (int)'A' - 10));
            }
        }
    }
}
