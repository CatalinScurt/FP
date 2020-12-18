using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex12
    {
        public static void Result12()
        {
            int a, b, n, grup;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            grup = 0;
            for (int i = 0; i < n-1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (b == 0) grup++;
                if (a == 0 && b == 0) grup--;
                a = b;
            }
            Console.WriteLine($"Sunt {grup} grupuri!");
        }
    }
}
