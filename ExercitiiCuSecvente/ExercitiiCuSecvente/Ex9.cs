using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex9
    {
        public static void Result9()
        {
            int a, b, n;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            bool ascending = true;
            bool descending = true;
            for (int i = 0; i < n; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (b <= a)
                {
                    ascending = false;
                }
                if (b>=a)
                {
                    descending = false;
                }
                a = b;
            }
            if (ascending)
                Console.WriteLine("Secventa este monotona crescatoare!");
            else if (descending)
                Console.WriteLine("Secventa este monotona descrascatoare!");
            else
                Console.WriteLine("Secventa nu este monotona!!");

        }
    }
}
