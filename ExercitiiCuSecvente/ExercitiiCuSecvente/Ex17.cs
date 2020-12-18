using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex17
    {
        public static void Result17()
        {
            int a, b, n, maxim;
            int contor0 = 0, contor1 = 0, contor2 = 0;
            bool ok = true;
            maxim = 0;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            if (a == 0) contor0++;
            if (a == 1) ok = false;
            for (int i = 0; i < n-1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (b == 0) contor0++;
                if (b == 1) contor1++;
                if (a == b)
                 contor2++;
                if (a != b) contor2 = 0;
                if (contor2 > maxim) maxim = contor2;
                a = b;
            }
            if (n % 2 != 0) ok = false;
            if (contor1 != contor0) ok = false;
            if (ok) Console.WriteLine("Secventa corecta!");
            else Console.WriteLine("Secventa incorecta!");
            if (ok) Console.WriteLine($"Gradul maxim de incuibare este {maxim}");
        }
    }
}
