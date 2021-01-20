using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex19
    {
        public static void Result19()
        {
            Console.WriteLine("lungime vector in care se cauta");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("vector in care se cauta");
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("lungime vector care se cauta");
            int m = int.Parse(Console.ReadLine());
            int[] B = new int[m];
            Console.WriteLine("vector care se cauta");
            for (int i = 0; i < m; i++)
                B[i] = int.Parse(Console.ReadLine());
            int nr = 0;
            for (int i = 0; i < n - m + 1; i++)
            {
                int j;
                for (j = 0; j < m && A[j + i] == B[j]; j++) { }
                if (j == m)
                    nr++;
            }
            Console.WriteLine(nr);
        }
    }
}
