using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseEight
    {
        public static void GetResultNumber8()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a = {a} si b = {b} ");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swapping: a = {a} si b = {b} ");
        }
    }
}
