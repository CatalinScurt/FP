using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ExerciseSixteen
    {
        public static void GetResultNumber16()
        {
            int a, b, c, d, e, max1, max2, max3, max4;
            Console.WriteLine("Introduceti a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti d:");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti e:");
            e = int.Parse(Console.ReadLine());
            Console.WriteLine(a+" "+b+" "+c+" "+d+" "+e);
            if ((a>=b)&&(a>=c)&&(a>=d)&&(a>=e))
            {
                max1 = a;
                if ((b>=c)&&(b>=d)&&(b>=e))
                {
                    max2 = b;
                    if ((c>=d)&&(c>=e))
                    {
                        max3 = c;
                        if (d>= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((c >= b) && (c >= d) && (c >= e))
                {
                    max2 = c;
                    if ((b >= d) && (b >= e))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((d >= b) && (d >= c) && (d >= e))
                {
                    max2 = d;
                    if ((d >= b) && (d >= c))
                    {
                        max3 = d;
                        if (c >= b)
                        {
                            max4 = c;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {b}");
                        }
                        else
                        {
                            max4 = b;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {c}");
                        }
                    }
                }
                if ((e >= b) && (e >= d) && (e >= d))
                {
                    max2 = e;
                    if ((b >= c) && (b >= d))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
            }
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                max1 = b;
                if ((a >= c) && (a >= d) && (a >= e))
                {
                    max2 = a;
                    if ((c >= d) && (c >= e))
                    {
                        max3 = c;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((c >= b) && (c >= d) && (c >= e))
                {
                    max2 = c;
                    if ((b >= d) && (b >= e))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((d >= b) && (d >= c) && (d >= e))
                {
                    max2 = d;
                    if ((d >= b) && (d >= c))
                    {
                        max3 = d;
                        if (c >= b)
                        {
                            max4 = c;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {b}");
                        }
                        else
                        {
                            max4 = b;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {c}");
                        }
                    }
                }
                if ((e >= b) && (e >= d) && (e >= d))
                {
                    max2 = e;
                    if ((b >= c) && (b >= d))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
            }
            else if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                max1 = c;
                if ((a >= b) && (a >= d) && (a >= e))
                {
                    max2 = a;
                    if ((b >= d) && (c >= e))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((c >= b) && (c >= d) && (c >= e))
                {
                    max2 = c;
                    if ((b >= d) && (b >= e))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((d >= b) && (d >= c) && (d >= e))
                {
                    max2 = d;
                    if ((d >= b) && (d >= c))
                    {
                        max3 = d;
                        if (c >= b)
                        {
                            max4 = c;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {b}");
                        }
                        else
                        {
                            max4 = b;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {c}");
                        }
                    }
                }
                if ((e >= b) && (e >= d) && (e >= d))
                {
                    max2 = e;
                    if ((b >= c) && (b >= d))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
            }
            else if ((b >= a) && (b >= c) && (b >= d) && (b >= e))
            {
                max1 = b;
                if ((a >= c) && (a >= d) && (a >= e))
                {
                    max2 = a;
                    if ((c >= d) && (c >= e))
                    {
                        max3 = c;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((c >= b) && (c >= d) && (c >= e))
                {
                    max2 = c;
                    if ((b >= d) && (b >= e))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((d >= b) && (d >= c) && (d >= e))
                {
                    max2 = d;
                    if ((d >= b) && (d >= c))
                    {
                        max3 = d;
                        if (c >= b)
                        {
                            max4 = c;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {b}");
                        }
                        else
                        {
                            max4 = b;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {c}");
                        }
                    }
                }
                if ((e >= b) && (e >= d) && (e >= d))
                {
                    max2 = e;
                    if ((b >= c) && (b >= d))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
            }
            else if ((d >= a) && (d >= c) && (d >= b) && (d >= e))
            {
                max1 = d;
                if ((a >= c) && (a >= b) && (a >= e))
                {
                    max2 = a;
                    if ((c >= a) && (c >= e))
                    {
                        max3 = c;
                        if (b >= e)
                        {
                            max4 = c;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {c}");
                        }
                    }
                }
                if ((c >= b) && (c >= d) && (c >= e))
                {
                    max2 = c;
                    if ((b >= d) && (b >= e))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
                if ((d >= b) && (d >= c) && (d >= e))
                {
                    max2 = d;
                    if ((d >= b) && (d >= c))
                    {
                        max3 = d;
                        if (c >= b)
                        {
                            max4 = c;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {b}");
                        }
                        else
                        {
                            max4 = b;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {c}");
                        }
                    }
                }
                if ((e >= b) && (e >= d) && (e >= d))
                {
                    max2 = e;
                    if ((b >= c) && (b >= d))
                    {
                        max3 = b;
                        if (d >= e)
                        {
                            max4 = d;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {e}");
                        }
                        else
                        {
                            max4 = e;
                            Console.WriteLine($"{max1} {max2} {max3} {max4} {d}");
                        }
                    }
                }
            }
        }
    }
}
