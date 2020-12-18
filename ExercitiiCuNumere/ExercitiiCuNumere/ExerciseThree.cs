using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseThree
    {
        public static string GetResultNumber3()
        {
            Console.WriteLine("\t Enuntul problemei:");
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            int n, k;
            Console.WriteLine("Introduceti n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k:");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
               string result = "Numarul " + n + " se divide cu " + k;
                return result;
            }
            else
            {
                string result2 = "Numarul " + n + " nu se divide cu " + k;
                return result2;
            }
        }
    }
}
