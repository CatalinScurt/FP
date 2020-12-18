using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex8
    {
        public static void Result8()
        {
            Console.WriteLine("Al catelea termen din sirul lui Fibonacci doriti sa il aflati?");
            int n = int.Parse(Console.ReadLine());
            int first = 0, second = 1, last = 1 ;

            for (int i = 2; i < n; i++)
            {
                last = first + second;
                first = second;
                second = last;
            }
            if(n>=4)
            Console.WriteLine($"Al {n}-lea termen din sirul lui Fibonacci este {last}");
            if (n == 0) Console.WriteLine($"Primul termen din sirul lui Fibonacci este {first}");
            if (n == 1) Console.WriteLine($"Al doilea termen din sirul lui Fibonacci este {second}");
            if (n == 2) Console.WriteLine($"Al treilea termen din sirul lui Fibonacci este {last}");
        }
    }
}
