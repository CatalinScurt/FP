using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseSix
    {
        private static string tipulTriunghiului;

        public static string GetResultNumber6()
        {
            Console.WriteLine("/tEnuntul problemei:");
            Console.WriteLine("Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            int a, b, c;
            Console.WriteLine("Introduceti prima latura a triunghiului");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua latura a triunghiului");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a treia latura a triunghiului");
            c = int.Parse(Console.ReadLine());

            if ((a + b > c) || (a + c > b) || (b + c >a))
            {
                if ((a == b) || (a == c) || (b == c))
                    tipulTriunghiului = "isoscel";
                else if ((a == b) && (b == c) && (c == a))
                   tipulTriunghiului = "echilateral";
                else if ((a*a == b*b + c*c) || (b*b == a*a + c*c) || (c*c == b*b + c*c))
                tipulTriunghiului = "dreptunghic";
                else
                  tipulTriunghiului = "oarecare";
            }
            string result = "Numerele " + a + " " + b + " " + c + "formeaza un triunghi " + tipulTriunghiului;
            return result;
        }
    }
}
