using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex18
    {
        public static void Result18()
        {
            Console.WriteLine("Introduceti gradul polinomului");
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;
            Console.WriteLine("Introduceti punctul x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Coeficientii (n+1 coeficienti)");
            int[] coef = new int[n + 1];
            int suma = 0;
            for (int i = 0; i < n + 1; i++)
                coef[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                suma += coef[i] * (int)(Math.Pow(x, nCopy));
                if (i < n)
                {
                    Console.Write($"{coef[i]}*{x}^{nCopy} + ");
                }
                else
                {
                    Console.Write($"{coef[i]}*{x}^{nCopy} =");
                }
                nCopy--;
            }
            Console.Write(suma);
        }
        }
}
