using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex15
    {
        public static void Result15()
        {
            int a, b, n, contor;
            contor = 0;
            bool bitonica = true;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            for(int i = 0; i<n-1; i++)
            {
                b = int.Parse(Console.ReadLine());
                if (a > b)
                    contor++;
                if (contor >= 1 && b > a)
                    bitonica = false;
                a = b;
            }
            if (!bitonica) Console.WriteLine("Secventa nu este o secventa bitonica");
            if (bitonica) Console.WriteLine("Secventa este o secventa bitonica");
  
        }
    }
}
