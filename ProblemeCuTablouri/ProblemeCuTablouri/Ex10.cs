using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex10
    {
        public static void Result10()
        {
            Console.WriteLine("k,n,vector");
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(CautareBinara(A, k, 0, n - 1));
        }
    }
}
