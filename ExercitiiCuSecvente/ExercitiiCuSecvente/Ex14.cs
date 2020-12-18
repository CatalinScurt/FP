using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex14
    {
        public static void Result14()
        {
            int a, b, n, first;
            int contor1 = 0, contor2 = 0;
            bool monoton = true;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            first = a;
            for (int i = 0; i < n-1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a < b) contor1++;
                if (a > b) contor2++;
                if (contor1 == 1 && b < first) contor1 = 2;
                if (contor2 == 1 && b > first) contor2 = 2;
                a = b;
            }
            if (contor1 == 0 || contor2 == 0) Console.WriteLine("Secventa este o secventa monotona!");
            else if (contor1 == 1 || contor2 == 1)Console.WriteLine("Secventa este o secventa monotona rotita!");
            else Console.WriteLine("Secventa nu este o secventa monotona rotita!");
        }
    }
}
