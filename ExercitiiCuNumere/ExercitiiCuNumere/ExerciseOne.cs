using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{

    public class ExerciseOne
    {
        public static double GetResultNumber1()
        {
            Console.WriteLine("\t Enuntul problemei:");
            Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.");
            int a, b;

           Console.WriteLine("Introduceti a:");
           a = int.Parse(Console.ReadLine());
           Console.WriteLine("Introduceti b:");
           b = int.Parse(Console.ReadLine());
     
            double x;
            x = (double)-b / (double)a;
            return x;
        }
    }
}

