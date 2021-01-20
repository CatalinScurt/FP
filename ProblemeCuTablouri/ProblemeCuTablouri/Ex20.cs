using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemeCuTablouri
{
    class Ex20
    {
        public static void Result20()
        {
            static int Read()
            {
                bool isValid;
                int n = 0;
                do
                {
                    try
                    {
                        n = int.Parse(Console.ReadLine());
                        isValid = true;
                    }
                    catch (Exception)
                    {
                        isValid = false;
                        Console.WriteLine("Invalid.");
                    }
                } while (!isValid);
                return n;
            }
            static void ReadArray(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"a[{i}] = ");
                    a[i] = Read();
                }
            }
            static void ViewArray(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                    Console.Write($"{a[i]} ");
                Console.WriteLine();
            }
           
            static void Main(string[] args)
            {
                Console.Write("Lungimea primului vector: ");
                int n = Read();
                int[] a = new int[n];
                ReadArray(a);
                ViewArray(a);

                Console.Write("Lungimea celui de al doilea vector: ");
                int m = Read();
                int[] b = new int[m];
                ReadArray(b);
                ViewArray(b);
            }
        }
    }
}
