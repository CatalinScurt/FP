using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex10
    {
        public static void Result10()
        {
            int a, b, n, contor, numerotare;
            contor = 1;
            numerotare = 0;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if(a == b)
                    contor++;
                if (contor > numerotare)
                    numerotare = contor;
                if (a != b)
                    contor = 1;
                a = b;
            }
            Console.WriteLine($"Numarul apare de{numerotare} ori");
        }
    }
}
