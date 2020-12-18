using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex1
    {
        public static void Result1()
        {
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            int n = int.Parse(Console.ReadLine());
            int contor = 0, a;
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            for (int i = 0; i<n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 ==0)
                {
                    contor++;
                }
            }
            Console.WriteLine($"In secventa introdusa sunt {contor} numere pare.");
        }
    }
}
