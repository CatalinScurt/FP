using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex16
    {
        public static void Result16()
        {
            int a, b, n, contor, contor2;
            contor = 0;
            contor2 = 0;
            bool bitonica = true;
            bool rotita = true;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            int first = a;
            for (int i = 0; i < n-1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b)
                    contor++;
                if (contor >= 1 && b > a)
                    bitonica = false;
                if (a < b) contor2++;
                if (contor2 >= 1 && b < a && b<first)
                    rotita = false;
                a = b;
            }
            if (!bitonica) Console.WriteLine("Secventa nu este o secventa bitonica");
            if (bitonica) Console.WriteLine("Secventa este o secventa bitonica");
            if (!rotita) Console.WriteLine("NU este Secventa bitonica rotita");
            if (rotita) Console.WriteLine("Este Secventa bitonica rotita");

        }
    }
}
