using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EquTest();
        }

        static void EquTest()
        {
            Console.Write("Enter x param: ");
            int xparamx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter equation number: ");
            int equNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("––––––––––––––––––––––––|");
            switch (equNum) 
            {
                case 1:
                    bool result1 = 6 * xparamx - 10.2 == 4 * xparamx - 2.2;
                    if (result1 == false)
                    {
                        Console.WriteLine("Wrong expression.");
                    }
                    else
                    {
                        Console.WriteLine("Correct expression.");
                    }
                    break;
                case 2:
                    bool result2 = 15 - (3 * xparamx - 3) == 5 - 4 * xparamx;
                    if (result2 == false)
                    {
                        Console.WriteLine("Wrong expression.");
                    }
                    else
                    {
                        Console.WriteLine("Correct expression.");
                    }
                    break;
                case 3:
                    bool result3 = 2 * (xparamx - 0.5) + 1 == 9;
                    if (result3 == false)
                    {
                        Console.WriteLine("Wrong expression.");
                    }
                    else
                    {
                        Console.WriteLine("Correct expression.");
                    }
                    break;
                default:
                    Console.WriteLine("Error! Enter a expression number ( 1 - 3 ).");
                    break;
                }

        }
    }
}
