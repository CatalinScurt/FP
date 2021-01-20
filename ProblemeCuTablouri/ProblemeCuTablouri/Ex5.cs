using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex5
    {
        public static void Result5()
        {
            Console.WriteLine("n,e,k,vector");
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] A = new int[n + 1];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            for (int i = n - 1; i > k - 1; i--)
                A[i + 1] = A[i];
            n = n + 1;
            A[k] = e;
            for (int i = 0; i < n; i++)
                Console.WriteLine($"{A[i]} ");
        }
    }
}
