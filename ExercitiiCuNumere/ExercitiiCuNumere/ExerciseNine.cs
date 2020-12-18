using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseNine
    {
        public static void GetResultNumber9()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine($"{i} este divizor a lui {n}");
                }
            }
        }
    }
}
