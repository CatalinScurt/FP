using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseSeven
    {

        public static void GetResultNumber7()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int aux;
            Console.WriteLine($"Before: a = {a} si b = {b}");
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"After: a = {a} si b = {b}");

        }
    }
}

