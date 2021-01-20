using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex3
    {
        public static void Result3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int max;
            int min;
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            min = max = A[0];
            for (int i = 1; i < n; i++)
            {
                if (A[i] < min)
                    min = A[i];
                else if (A[i] > max)
                    max = A[i];
            }
            Console.WriteLine($"min {min} max {max}");
        }
    }
}
