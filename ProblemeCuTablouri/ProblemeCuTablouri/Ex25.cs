using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex25
    {
        public static void Result25()
        {
            Console.WriteLine("n,vector1");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            for (int i = 0; i < n; i++)
                v1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("m,vector2");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            for (int i = 0; i < m; i++)
                v2[i] = int.Parse(Console.ReadLine());
            int[] v3 = new int[n + m];
            int l = 0, j = 0, k = 0;
            while (l < n && j < m)
            {
                if (v1[l] < v2[j])
                {
                    v3[k] = v1[l];
                    k++;
                    l++;
                }
                else
                {
                    v3[k] = v2[j];
                    k++;
                    j++;
                }
            }
            if (l < n)
            {
                for (int p = l; p < n; p++)
                {
                    v3[k] = v1[p];
                    k++;
                }
            }
            if (j < m)
            {
                for (int p = j; p < m; p++)
                {
                    v3[k] = v2[p];
                    k++;
                }
            }
            Console.WriteLine(k);
        }
    }
}
