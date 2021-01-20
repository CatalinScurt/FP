using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex16
    {
        public static void Result16()
        {
            int n = int.Parse(Console.ReadLine());
            int cmmdc = 0;
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
                A[i] = int.Parse(Console.ReadLine());
            cmmdc = A[0];
            for (int i = 1; i < n; i++)
            {
                int copie = A[i];
                while (copie != cmmdc)
                {
                    if (copie > cmmdc)
                        copie -= cmmdc;
                    else if (copie < cmmdc)
                        cmmdc -= copie;
                }

            }
            Console.WriteLine(cmmdc);
        }
    }
}
