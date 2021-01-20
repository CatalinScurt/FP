using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex6
    {
        public static void Result6()
        {
            Console.WriteLine("n,k,vector");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] A = new int[n + 1];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = k; i < n - 1; i++)
                A[i] = A[i + 1];
            n = n - 1;
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{A[i] }");
        }
    }
}
