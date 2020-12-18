using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex7
    {
        public static void Result7()
        {
            int a, b=0, n;
            int bigest = 0, lowest = 0;
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            a = int.Parse(Console.ReadLine());
            bigest = a;
            lowest = a;
            for (int i = 0; i<n-1; i++)
            {
                b = int.Parse(Console.ReadLine());
               if (bigest <= b)
                {
                    bigest = b;
                }
                if (lowest >= b)
                {
                    lowest = b;
                }
            }
            Console.WriteLine("Cel mai mare este: "+bigest);
            Console.WriteLine("cel mai mic este: "+ lowest);
        }
    }
}
