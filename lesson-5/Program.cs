using System;


namespace lesson_5._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter x param: ");
            int xSide = Convert.ToInt32(Console.ReadLine());

            double s = xSide * xSide;
            int p = 4 * xSide;
            Console.WriteLine($"–––––––––––––––––––––––––\nThe area of the square is {s} sm.\n––––––––––\nThe perimeter of the square is {p} sm.");



        }
    }
    
}
