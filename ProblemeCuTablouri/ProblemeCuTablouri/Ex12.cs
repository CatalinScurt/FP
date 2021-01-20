using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex12
    {
        public static void Result12()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (a[j] < a[min_idx])
                        min_idx = j;
                int aux = a[min_idx];
                a[min_idx] = a[i];
                a[i] = aux;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{a[i]} ");
        }
    }
}
