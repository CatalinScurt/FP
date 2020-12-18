using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex13
    {
        public static void Result13()
        {
            int a, b, n, contor, first;
            bool crescator = true;
            contor = 0;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            first = a;
            for (int i = 0; i < n-1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b)
                    contor++;
                if (contor == 1 && b > first)
                    crescator = false;
                if (contor > 1)
                    crescator = false;
                a = b;
            }
            if(!crescator)
                Console.WriteLine("Secventa nu este o secventa crescatoare rotita!");
            if (contor == 0) Console.WriteLine("Secventa este o secventa monoton crescatoare!");
            if (contor == 1 && crescator) Console.WriteLine("Secventa este o secventa crescatoare rotita!");
        }
    }
}
