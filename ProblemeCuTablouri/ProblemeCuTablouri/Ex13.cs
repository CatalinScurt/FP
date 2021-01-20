using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex13
    {
        public static void Result13()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int copy = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > copy)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = copy;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{a[i]} ");
        }
    }
}
