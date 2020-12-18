using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseTwo
    {
        public static string GetResultNumber2()
        {
            Console.WriteLine("\t Enuntul problemei:");
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
            double x1;
            double x2;
            double a, b, c;
            Console.WriteLine("Introduceti a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c:");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Ecuatia este de forma:{0} * x^2 + {1} * x + {2} = 0", a, b, c);
            double delta = Math.Pow(b, 2) - (4 * a * c);
            if (delta == 0)
            {
                Console.WriteLine("Ecuatia are 2 solutii reale egale.");
                x1 = -b / 2 * a;
                string result = "x1 = x2 =" + x1;
                return result;
            }
            else
            {
                switch (delta > 0)
                {
                    case (true):
                        Console.WriteLine("Ecuatia are 2 solutii reale distincte.");
                        x1 = (-b - Math.Sqrt(delta) / 2 * a);
                        x2 = (-b + Math.Sqrt(delta) / 2 * a);
                        string result = "x1 = " + x1 +"; x2 = "+ x2;
                        return result;
                    case false:
                        Console.WriteLine("Ecuatia are 2 solutii complexe distincte.");
                        double real, imaginar1, imaginar2;
                        real = -b / 2 * a;
                        imaginar1 = -Math.Sqrt(-delta) / 2 * a;
                        imaginar2 = Math.Sqrt(-delta) / 2 * a;
                        string result2 = "x1 = " + real + " - " + imaginar1 + "i" + "; x2 = " + real + " + " + imaginar2 + "i";
                        return result2;
                }
            }
            
        }

    }
}
