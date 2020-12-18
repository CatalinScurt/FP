using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseEighteen
    {
        public static void GetResultNumber18()
        {
            Console.WriteLine("Introduceti numarul natural");
            int n = int.Parse(Console.ReadLine());
            int m, p;
            m = n;
            //pentru fiecare numar verificam daca este divizor
            for (int divizor = 2; divizor <= n / 2; divizor++)
            {
                //este divizor, calculam multiplicitatea
                if (m % divizor == 0)
                {
                    p = 0;
                    while (m % divizor == 0)
                    {
                        p++;
                        m /= divizor;
                    }
                    Console.Write("{0}^{1}*", divizor, p);
                }
                if (m == 1)
                    break;
            }
            Console.WriteLine("1");
            Console.ReadLine();
        }
    }
}
