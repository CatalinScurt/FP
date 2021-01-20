using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex14
    {
        public static void Result14()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            int aux = 0;
            int j = n - 1;
            for (int i = 0; i <= j; i++)
            {
                if (A[i] == 0)
                {
                    while (A[j] == 0)
                    {
                        j--;
                    }
                    aux = A[i];
                    A[i] = A[j];
                    A[j] = aux;
                }
                j--;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }
    }
}
