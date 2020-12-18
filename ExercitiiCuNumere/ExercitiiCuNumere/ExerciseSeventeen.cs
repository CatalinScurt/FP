using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseSeventeen
    {
        public static void GetResultNumber17()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int cmmdc = 0;
            int rest = 0;
            int p, cmmmc;
            rest = a % b;
            while (rest != 0)
            {
                a = b;
                b = rest;
                rest = a % b;
            }
            cmmdc = b;
            p = a * b;
            while (b != 0)
            {
                rest = a % b;
                a = b;
                b = rest;
            }
            cmmmc = p / a;
            Console.WriteLine($"CMMDC este {cmmdc} iar CMMMC este {cmmmc}");

        }
    }
}
