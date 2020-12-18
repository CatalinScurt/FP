using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseFive  
    {
        public static int GetResultNumber5()
        {
            Console.WriteLine("\tEnuntul problemei:");
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            int n, k, c, cifraCautata;
            Console.WriteLine("Introduceti numarul numarul din care doriti sa extrageti o anumita cifra");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("A catea cifra a numarului {0} doriti sa o extrageti?", n);
            k = int.Parse(Console.ReadLine());
            c = (int)(n % (Math.Pow(10, k)));
            cifraCautata = (int)(c / Math.Pow(10, k - 1));

            return cifraCautata;
        }
    }
}
