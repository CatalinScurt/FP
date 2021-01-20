using System;

namespace ProblemeCuTablouri
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
                    Console.WriteLine("Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. ");
                    Ex2.Result2();
                    break;
                case 3:
                    Console.WriteLine("Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). ");
                    Ex3.Result3();
                    break;
                case 4:
                    Console.WriteLine("Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
                    Ex4.Result4();
                    break;
                case 5:
                    Console.WriteLine("Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.");
                    Ex5.Result5();
                    break;
                case 6:
                    Console.WriteLine("Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. ");
                    Ex6.Result6();
                    break;
                case 7:
                    Console.WriteLine("Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
                    Ex7.Result7();
                    break;
                case 8:
                    Console.WriteLine("Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. ");
                    Ex8.Result8();
                    break;
                case 9:
                    Console.WriteLine("Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
                    Ex9.Result9();
                    break;
                case 10:
                    Console.WriteLine("Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. ");
                    Ex10.Result10();
                    break;
                case 11:
                    Console.WriteLine("Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). ");
                    Ex11.Result11();
                    break;
                case 12:
                    Console.WriteLine("Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. ");
                    Ex12.Result12();
                    break;
                case 13:
                    Console.WriteLine("Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. ");
                    Ex13.Result13();
                    break;
                case 14:
                    Console.WriteLine("Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). ");
                    Ex14.Result14();
                    break;
                case 15:
                    Console.WriteLine("Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ");
                    Ex15.Result15();
                    break;
                case 16:
                    Console.WriteLine("Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
                    Ex16.Result16();
                    break;
                case 17:
                    Console.WriteLine("Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   ");
                    Ex17.Result17();
                    break;
                case 18:
                    Console.WriteLine("Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. ");
                    Ex18.Result18();
                    break;
                case 19:
                    Console.WriteLine("Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). ");
                    Ex19.Result19();
                    break;
                case 20:
                    Console.WriteLine("Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. ");
                    Ex20.Result20();
                    break;
                case 21:
                    Console.WriteLine("Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). ");
                    Ex21.Result21();
                    break;
                case 22:
                    Console.WriteLine("Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. ");
                    Ex22.Result22();
                    break;
                case 23:
                    Console.WriteLine("Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. ");
                    Ex23.Result23();
                    break;
                case 24:
                    Console.WriteLine("Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).");
                    Ex24.Result24();
                    break;
                case 25:
                    Console.WriteLine("(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. ");
                    Ex25.Result25();
                    break;
            }
        }
    }
}
