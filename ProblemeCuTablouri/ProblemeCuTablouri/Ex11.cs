using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex11
    {
        public static void Result11()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = 0;
            a[0] = 1;
            a[1] = 1;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (a[i] == 0)
                {
                    for (int j = 2; j < n / i; j++)
                        a[i * j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
                if (a[i] == 0)
                    Console.WriteLine(i + " ");
        }

        public static object CautareBinara(int[] A, int k, int left, int right)
        {
            if (left > right)
                return -1;
            else
            {
                int mid = (left + right) / 2;
                if (k == A[mid])
                    return mid++;
                else
                {
                    if (A[mid] == k)
                        return mid;
                    if (k < A[mid])
                        return CautareBinara(A, k, left, mid - 1);
                    else
                        return CautareBinara(A, k, mid + 1, right);
                }
            }
        }
    }
}
