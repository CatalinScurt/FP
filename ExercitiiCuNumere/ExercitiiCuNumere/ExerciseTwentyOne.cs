using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuNumere
{
    class ExerciseTwentyOne
    {
        public static void GetResultNumber21()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 1024);
            Console.Write("Numarul este mai mare sau egal decat ");
            int numarIntrodus = int.Parse(Console.ReadLine());
            do
            {
                if (n > numarIntrodus)
                    Console.WriteLine("da");
                else
                    Console.WriteLine("nu");
                Console.Write("Numarul este mai mare sau egal decat ");
                int a = int.Parse(Console.ReadLine());
                numarIntrodus = a;
            }
            while (n != numarIntrodus);
            Console.WriteLine($"Ai ghicit! Numarul este {n}");
        }
    }
}
