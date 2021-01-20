using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex2
    {
        public static void Result2()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int k = int.Parse(Console.ReadLine());
            int ok = 0;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n && ok == 0; i++)
            {
                if (v[i] == k)
                {
                    ok = 1;
                    Console.WriteLine(i);
                }
            }
            if (ok == 0)
                Console.WriteLine("-1");
        }
    }
}
