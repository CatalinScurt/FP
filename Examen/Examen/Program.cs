using System;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
               int n = int.Parse(Console.ReadLine());
            //   int t = int.Parse(Console.ReadLine());
            //   int[] v = new int[10] {1,2,3,4,5,6,7,8,9,10};
            //   Console.WriteLine(Punu(n));
            //  Pdoi(v, t);
            //   Ptrei();
            //    Pcinci();
            Console.WriteLine(Psapte(n));
        }
    /*    public static int Punu(int n)
        {
            int nr=0;
            int x = n;
            while (n>0)
            {
                n = n / 10;
                nr =nr * 10 + 9;
            }
            int complement = nr - x;
        return complement;
        }*/
      /*  public static void Pdoi(int[] v, int t)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (v[i] + v[j] == t)
                    {
                        Console.WriteLine(i + " si "+ j);
                    }
                }
            }
        }*/
     /* public static void Ptrei()
        {
            int a = int.Parse(Console.ReadLine());
            int max1=0, max2=0, max3 = 0;
            int b = a;
            while (b != 0)
            {
                b = int.Parse(Console.ReadLine());

                if (b>=a && b>max1)
                {
                    max1 = b;
                }
                if (a>b)
                {
                    max2 = b;
                }
                if (a>b)
                {
                    max3 = b;
                }
                a = b;
            }
            Console.WriteLine($"1: {max1}, 2: {max2}, 3: {max3}");
        }*/
    /* public static void Pcinci()
        {
            double diametruEcuator, razaEcuator, inaltimePisica, ecuatorSiPisica;
            double lungimeEcuator;
            inaltimePisica = int.Parse(Console.ReadLine());
            diametruEcuator = 12756000;
            lungimeEcuator = 2 * Math.PI * diametruEcuator / 2;
            ecuatorSiPisica = (12756000 + inaltimePisica/100)/2 * Math.PI * 2;
            if(ecuatorSiPisica <= lungimeEcuator+1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
        }*/
    public static int Psapte(int n)
        {
            int cifra, min = 0;
            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;
                if (cifra % 2 ==0 && min < cifra)
                {
                    min = cifra;
                }
            }
            if (min != 0)
            {
                return min;
            }
            else
                return -1;
        }
    }
}
