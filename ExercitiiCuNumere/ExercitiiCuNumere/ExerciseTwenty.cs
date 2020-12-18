using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseTwenty
    {
        public static void GetResultNumber20()
        {
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numitorul: ");
            int jos = int.Parse(Console.ReadLine());
            double result;
            result = (double)n / (double)jos;
            Console.WriteLine(result);
             
        }
    }
}
