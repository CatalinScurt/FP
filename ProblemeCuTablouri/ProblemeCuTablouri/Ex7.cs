using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex7
    {
        public static void Result7()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            int j = n - 1;
            int aux;
            for (int i = 0; i <= j; i++)
            {
                aux = A[i];
                A[i] = A[j];
                A[j] = aux;
                j--;
            }
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }
    }
}
