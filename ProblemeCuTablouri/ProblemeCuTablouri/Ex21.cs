using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex21
    {
        public static void Result21()
        {
            Console.WriteLine("n,vector1");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            Citire(v1, n);
            Console.WriteLine("m,vector2");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            Citire(v2, m);
            int nr = 0;
            if (n > m)
            {
                for (int i = 0; i < m; i++)
                {
                    if (v1[i] > v2[i])
                    {
                        Console.WriteLine("V2 este primul");
                        break;
                    }
                    else if (v2[i] > v1[i])
                    {
                        Console.WriteLine("V1 este primul");
                        break;
                    }
                    else if (v1[i] == v2[i])
                    {
                        nr++;
                    }
                }
                if (nr == m)
                {
                    Console.WriteLine("V2 este primul");
                }
            }
            else
            {
                for (int i = 0; i < m; i++)
                {
                    if (v2[i] > v1[i])
                    {
                        Console.WriteLine("V1 este primul");
                        break;
                    }
                    else if (v1[i] > v2[i])
                    {
                        Console.WriteLine("V2 este primul");
                        break;
                    }
                    else if (v1[i] == v2[i])
                    {
                        nr++;
                    }
                }
                if (nr == n)
                {
                    if (n == m)
                        Console.WriteLine("sunt egale");
                    else
                        Console.WriteLine("V1 este primul");
                }
            }
        }
        public static void Rotire(int[] A, int n)
        {
            int aux;
            for (int i = 0; i < n - 1; i++)
            {
                aux = A[i];
                A[i] = A[i + 1];
                A[i + 1] = aux;
            }
        }
        public static void Citire(int[] A, int n)
        {

            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
        }
        public static void Afisare(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write($"{A[i]} ");
        }
        private static int CautareVector(int[] A, int[] B, int max, int min)
        {
            int nr = 0;
            for (int i = 0; i < max - min + 1; i++)
            {
                int j;
                for (j = 0; j < min && A[j + i] == B[j]; j++) { }
                if (j == min)
                    nr++;
            }
            return nr;
        }
    }
}
