using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseFiveteen
    {
        public static void GetResultNumber15()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int max1, max2;
            if ((a >= b) && (a >= c))
            {
                max1 = a;
                if (b >= c)
                {
                    max2 = b;
                    Console.WriteLine($"{max1} {max2} {c}");
                }
                else
                {
                    max2 = c;
                    Console.WriteLine($"{max1} {max2} {b}");
                }
            }
            else if (b >= a && b >= c)
            {
                max1 = b;
                if (a >= c)
                {
                    max2 = a;
                    Console.WriteLine($"{max1} {max2} {c}");
                }
                else
                {
                    max2 = c;
                    Console.WriteLine($"{max1} {max2} {a}");
                }
            }
            else
            {
                max1 = c;
                if(b>=a)
                {
                    max2 = b;
                    Console.WriteLine($"{max1} {max2} {a}");
                }
                else
                {
                    max2 = a;
                    Console.WriteLine($"{max1} {max2} {b}");
                }
            }

        }
    }
}
