using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex9
    {
        public static void Result9()
        {
            Console.WriteLine("k,n,vector");
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            int j = 0;
            int aux;
            for (j = 0; j < k; j++)
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
