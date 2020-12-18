using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex6
    {
        public static void Result6()
        {
            int a, b, n;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            bool ascending = true;
            for (int i = 0; i < n; i++)
            {
                b= int.Parse(Console.ReadLine());
                if (b<=a)
                {
                    ascending = false;
                }
                a = b;
            }
            if (!ascending)
                Console.WriteLine("Secventa nu este in ordine crescatoare!");
            if (ascending)
                Console.WriteLine("Secventa este in ordine crescatoare!");
        }
    }
}
