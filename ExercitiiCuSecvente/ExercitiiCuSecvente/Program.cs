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
                    Ex1.Result1();
                    break;
                case 2:
                    Ex2.Result2();
                    break;
                case 3:
                    Ex3.Result3();
                    break;
                case 4:
                    Ex4.Result4();
                    break;
                case 5:
                    Ex5.Result5();
                    break;
                case 6:
                    Ex6.Result6();
                    break;
                case 7:
                    Ex7.Result7();
                    break;
                case 8:
                    Ex8.Result8();
                    break;
                case 9:
                    Ex9.Result9();
                    break;
                case 10:
                    Ex10.Result10();
                    break;
                case 11:
                    Ex11.Result11();
                    break;
                case 12:
                    Ex12.Result12();
                    break;
                case 13:
                    Ex13.Result13();
                    break;
                case 14:
                    Ex14.Result14();
                    break;
                case 15:
                    Ex15.Result15();
                    break;
                case 16:
                    Ex16.Result16();
                    break;
                case 17:
                    Ex17.Result17();
                    break;
            }
        }
    }
}
