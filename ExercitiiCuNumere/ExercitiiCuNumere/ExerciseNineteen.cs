using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseNineteen
    {
        public static void GetResultNumber19()
        {
            int n, rest, contor, first, second;
            rest = 0;
            contor= 0;
            first = 0;
            second = 0;
            n = int.Parse(Console.ReadLine());
            int nr = n;
            while (n>0)
            {
                rest = n % 10;
                if (nr == n)
                first = rest;
                if (rest != first && rest != second) contor++;
                if (rest != first) second = rest;
                n /= 10;             
            }
            if (contor > 1) Console.WriteLine("Numarul nu poate fi format prin combinarea a 2 cifre!");
            if (contor <= 1) Console.WriteLine("Numarul poate fi format doar din combinarea a 2 cifre!");
        }
    }
}
