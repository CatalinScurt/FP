using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex3
    {
        public static void Result3()
        {
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int produs = 1;
            for (int i = 1; i < n + 1; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma primilor {n} termeni este {suma}");
            Console.WriteLine($"Produsul primilor {n} termeni este {produs}");
        }
    }
}
