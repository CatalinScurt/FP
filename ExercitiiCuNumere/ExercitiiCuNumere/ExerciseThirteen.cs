using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseThirteen
    {
        public static void GetResultNumber13()
        {
            int y1, y2;
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = y1; i < y2; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                {
                    Console.WriteLine(i + " este un an bisect");
                    contor++;
                }
            }
            Console.WriteLine($"Intre anii {y1} si {y2} sunt {contor} ani bisecti");
        }
    }
}
