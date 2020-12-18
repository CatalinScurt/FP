using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex2
    {
        public static void Result2()
        {
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            int n = int.Parse(Console.ReadLine());
            int contor1 = 0;
            int contor2 = 0;
            int contor3 = 0;
            int a;
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    contor1++;
                }
                if (a > 0)
                {
                    contor2++;
                }
                if (a == 0)
                {
                    contor3++;
                }
            }
            Console.WriteLine($"In secventa introdusa sunt {contor1} numere negative, {contor2} numere pozitive si {contor3} numere egale cu zero");
        }
    }
}

