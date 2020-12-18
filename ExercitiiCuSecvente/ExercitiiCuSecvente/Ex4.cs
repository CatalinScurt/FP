using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex4
    {
        public static void Result4()
        {
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            int n = int.Parse(Console.ReadLine());
            int contor = 0, a, numar;
            Console.WriteLine("Introduceti numarul a carui pozitie doriti sa o aflati in secventa: ");
            numar = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a==numar)
                {
                    contor = i;
                }
            }
            if(contor>0)
            Console.WriteLine("Numarul se afla pe pozitia " + contor);
            if(contor==0)
            Console.WriteLine(-1);
        }
    }
}
