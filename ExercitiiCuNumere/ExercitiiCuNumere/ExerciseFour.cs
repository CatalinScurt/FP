using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseFour
    {
        public static string GetResultNumber4()
        {
            Console.WriteLine("\tEnuntul problemei:");
            Console.WriteLine("Detreminati daca un an y este an bisect.");
            int n;
            string lapYear;
            Console.WriteLine("Introduceti anul pe care doriti sa-l verificati.");
            n = int.Parse(Console.ReadLine());
            if ((n % 4 == 0 && n % 100 != 0) || n % 400 == 0)
            {
                lapYear = "Acesta este un an bisect";
            }
            else
                lapYear = "Acesta nu este un an bisect";
            return lapYear;
        }
    }
}
