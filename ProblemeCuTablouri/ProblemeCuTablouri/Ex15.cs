using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex15
    {
        public static void Result15()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] == A[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            A[k] = A[k + 1];
                        }
                        n--;
                        j--;
                    }
                }
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }
    }
}
