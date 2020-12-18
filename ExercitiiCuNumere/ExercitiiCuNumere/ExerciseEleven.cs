using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseEleven
    {
        public static void GetResultNumber11()
        {
            int n = int.Parse(Console.ReadLine());
            int cifre;
            while (n > 0)
            {
                cifre = n % 10;
                n = n / 10;
                Console.Write(cifre + " ");
            }
        }
    }
}
