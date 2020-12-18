using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseTen
    {
        public static void GetResultNumber10()
        {
             int n;
            bool prime = true;
            int contor = 2;

            n = int.Parse(Console.ReadLine());

            while (contor <= n / 2)
            {
                //daca are divizor
                if (n % contor == 0)
                    prime = false;
                contor++;
            }

            if (prime)
                Console.WriteLine($"Numarul {n} este prim");
            else
                Console.WriteLine($"Numarul {n} nu este prim");

        }
    }
}

