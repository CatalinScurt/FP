using System;
using System.Dynamic;

namespace ConsoleApp1
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
                    double result1 = ExerciseOne.GetResultNumber1();
                    Console.WriteLine(result1);
                    break;
                case 2:
                    string result2 = ExerciseTwo.GetResultNumber2();
                    Console.WriteLine(result2);
                    break;
                case 3:
                    string result3 = ExerciseThree.GetResultNumber3();
                    Console.WriteLine(result3);
                    break;
                case 4:
                    string result4 = ExerciseFour.GetResultNumber4();
                    Console.WriteLine(result4);
                    break;
                case 5:
                    int result5 = ExerciseFive.GetResultNumber5();
                    Console.WriteLine(result5);
                    break;
                case 6:
                    string result6 = ExerciseSix.GetResultNumber6();
                    Console.WriteLine(result6);
                    break;
                case 7:
                    ExerciseSeven.GetResultNumber7();
                    break;
                case 8:
                    ExerciseEight.GetResultNumber8();
                    break;
                case 9:
                    ExerciseNine.GetResultNumber9();
                    break;
                case 10:
                    ExerciseTen.GetResultNumber10();
                    break;
                case 11:
                    ExerciseEleven.GetResultNumber11();
                    break;
                case 12:
                    ExerciseTwelve.GetResultNumber12();
                    break;
                case 13:
                    ExerciseThirteen.GetResultNumber13();
                    break;
                case 14:
                    ExerciseFourteen.GetResultNumber14();
                    break;
                case 15:
                    ExerciseFiveteen.GetResultNumber15();
                    break;
                case 16:
                    ExerciseSixteen.GetResultNumber16();
                    break;
                case 17:
                    ExerciseSeventeen.GetResultNumber17();
                    break;
                case 18:
                    ExerciseEighteen.GetResultNumber18();
                    break;
                case 19:
                    ExerciseNineteen.GetResultNumber19();
                    break;
                case 20:
                    ExerciseTwenty.GetResultNumber20();
                    break;
                case 21:
                    ExerciseTwentyOne.GetResultNumber21();
                    break;

            }
        }
    }
}
