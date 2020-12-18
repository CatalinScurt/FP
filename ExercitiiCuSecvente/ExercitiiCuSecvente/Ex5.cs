using System;
using System.Collections.Generic;
using System.Text;

namespace ExercitiiCuSecvente
{
    class Ex5
    {
        public static void Result5()
        {
            Console.WriteLine("Introduceti numarul de elemente ale secventei:");
            int n = int.Parse(Console.ReadLine());
            int contor = 0, a;
            Console.WriteLine("Introduceti elementele secventei, dupa fiecare element introdus apasati tasta [ENTER].");
            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a == i)
                {
                    contor++;
                }
            }
            if (contor == 1)
            {
                Console.WriteLine("In secventa introdusa exista un numar egal cu pozitia sa in secventa!");

            }
            else if (contor > 1)
            {
                Console.WriteLine($"In secventa introdusa sunt {contor} numere egale cu pozitia lor in secventa!");

            }
            else
            {
                Console.WriteLine("In aceasta secventa nu sunt numere egale cu pozitia lor in secventa");

            }
        }
        
    }
}
