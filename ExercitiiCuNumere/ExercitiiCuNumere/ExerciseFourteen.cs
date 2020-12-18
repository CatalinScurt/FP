using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseFourteen
    {
        public static void GetResultNumber14()
        {
            int n, cifre;
            int palindrom = 0;
            n = int.Parse(Console.ReadLine());
            int Palindrom()
            {
                while (n > 0)
                {
                    cifre = n % 10;
                    n /= 10;
                    palindrom = palindrom * 10 + cifre;
                }
                Console.WriteLine(palindrom);
                return palindrom;
            }
            if(n == Palindrom())
                Console.WriteLine($"Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
        }
    }
}
