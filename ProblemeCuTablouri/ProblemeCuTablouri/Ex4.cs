using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex4
    {
        public static void Result4()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int[] F = new int[100000];
            for (int i = 0; i < F.Length; i++)
                F[i] = 1;
            int max;
            int min;
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            min = max = A[0];
            for (int i = 1; i < n; i++)
            {

                if (A[i] < min)
                {
                    min = A[i];
                }
                else if (A[i] == min)
                    F[min]++;
                else if (A[i] > max)
                {
                    max = A[i];
                }
                else if (A[i] == max)
                    F[max]++;


            }
            Console.WriteLine($"minim {min} apare de {F[min]} ori");
            Console.WriteLine($"max {max} apare de {F[max]} ori");
        }
    }
}
