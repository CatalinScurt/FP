using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex8
    {
        public static void Result8()
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                aux = A[i];
                A[i] = A[i + 1];
                A[i + 1] = aux;
            }

            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }
    }
}
