using System;

namespace ExercitiiCuSecvente
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduceti numarul exercitiului pe care doriti sa il vizualizati");
            int exerciseNumber = int.Parse(Console.ReadLine());
            switch (exerciseNumber)
            {
                case 1:
                    Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare.");
                    Ex1.Result1();
                    break;
                case 2:
                    Console.WriteLine("Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
                    Ex2.Result2();
                    break;
                case 3:
                    Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n. ");
                    Ex3.Result3();
                    break;
                case 4:
                    Console.WriteLine("Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. ");
                    Ex4.Result4();
                    break;
                case 5:
                    Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. ");
                    Ex5.Result5();
                    break;
                case 6:
                    Console.WriteLine("Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
                    Ex6.Result6();
                    break;
                case 7:
                    Console.WriteLine("Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
                    Ex7.Result7();
                    break;
                case 8:
                    Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
                    Ex8.Result8();
                    break;
                case 9:
                    Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
                    Ex9.Result9();
                    break;
                case 10:
                    Console.WriteLine("Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");
                    Ex10.Result10();
                    break;
                case 11:
                    Console.WriteLine("Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ");
                    Ex11.Result11();
                    break;
                case 12:
                    Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ");
                    Ex12.Result12();
                    break;
                case 13:
                    Console.WriteLine("O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
                    Ex13.Result13();
                    break;
                case 14:
                    Console.WriteLine("O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
                    Ex14.Result14();
                    break;
                case 15:
                    Console.WriteLine("O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
                    Ex15.Result15();
                    break;
                case 16:
                    Console.WriteLine("O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
                    Ex16.Result16();
                    break;
                case 17:
                    Console.WriteLine("Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. ");
                    Ex17.Result17();
                    break;
            }
        }
    }
}
