using System;

namespace ExamenRestanta
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Introduceti numarul pe care doriti sa-l verificati:");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
          // Console.WriteLine(Exercitiu1(n));
          // Console.WriteLine(Exercitiul2(n));
          //  Exercitiul3(n);
            int[,] a = CreateMatrix(n, m);
            PrintMatrix1(a);
            Console.WriteLine(" ");
            PrintMatrix2(a,m,n);

        }

        /*   public static bool Exercitiu1(int n)
           {
               bool prime = true;
               int contor = 2;
               while (contor <= n / 2)
               {
                   //se verifica daca n are divizori, daca are => false
                   if (n % contor == 0)    
                       prime = false;
                   contor++;
               }

               if (prime)
                   return true;
               else
                   return false;}*/

        /*  public static (int, int) Exercitiul2(int n)
          {
              int a, b, cifra, x, y;
              a = 0;
              b = 0;
              x = 0;
              y = 0;
              while (n>0)
              {
                        //se divide numarul n in cifre
                  cifra = n % 10;
                  n = n / 10;
                        //se formeaza x cu cifrele pare (in ordinea aparitiilor)
                  if (cifra % 2 == 0)
                      x = x*10 + cifra;
                        //se formeaza y cu cifrele impare (in ordinea aparitiilor)
                  if(cifra % 2 != 0)
                      y = y*10 + cifra;
              }
                        //se inverseaza ordinea cifrelor lui x pentru a coincide cu aparitiile in n
              while (x>0)
              {
                  cifra = x % 10;
                  x = x / 10;
                  a = a * 10 + cifra;
              }
                       //se inverseaza ordinea cifrelor lui y pentru a coincide cu aparitiile in n
              while (y>0)
              {
                  cifra = y % 10;
                  y = y / 10;
                  b = b * 10 + cifra;
              }
                        // se formeaza tupletul a,b care va fi afisat mai sus prin intermediul functiei Exercitiul2()
              Tuple<int, int> result = new Tuple<int, int>(a, b);
              return (a, b);
          }*/
        /*  private static int Exercitiul3(int n)
          {
              int a, contor;
              contor = 0;
                    //se citesc n numere naturale
              while(contor<=n)
              {
                  contor++;
                  a = int.Parse(Console.ReadLine());
              }
              return 0;
          }
        */
        private static int[,] CreateMatrix(int linii, int coloane)
        {
            int[,] mat = new int[linii, coloane];
                    
            Random rnd = new Random();

                    //se formeaza matricea mat cu elemente random de la 0 la 20 apoi va fi returnata
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = rnd.Next(0, 20);


            return mat;

        }
        private static void PrintMatrix1(int[,] mat)
        {
                        //se afiseaza matricea in forma sa normala
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
            private static void PrintMatrix2(int[,] mat, int m, int n)
        {
            int nrElem = n * m;
            int currElem = 0;

            int t = (n > m) ? n : m;

                    //se afiseaza matricea prin parcurgerea in spirala
            for (int k = 0; k < t / 2 && currElem < nrElem; k++)
            {
                if (currElem < nrElem)
                {
                    for (int j = k; j < m - k; j++)
                    {
                        currElem++;
                        Console.Write(mat[k, j] + " ");
                    }
                }

                if (currElem < nrElem)
                {
                    for (int i = 1 + k; i < n - k; i++)
                    {
                        currElem++;
                        Console.Write(mat[i, m - 1 - k] + " ");
                    }
                }

                if (currElem < nrElem)
                {
                    for (int j = m - 2 - k; j >= k; j--)
                    {
                        currElem++;
                        Console.Write(mat[n - 1 - k, j] + " ");
                    }
                }

                if (currElem < nrElem)
                {
                    for (int i = n - 2 - k; i >= 1 + k; i--)
                    {
                        currElem++;
                        Console.Write(mat[i, k] + " ");
                    }
                }
            }
        }
    } 
}
