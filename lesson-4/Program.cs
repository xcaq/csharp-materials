using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] mass = {-10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int test = 0;
            for (int i = 0; i >= -10 && i <= 10; i++)
            {
                if (i >= -10 && i <= 10)
                {
                    Console.WriteLine((mass[i] / 2) - 1);
                    Console.WriteLine("-- " + test++);
                }
            }
            
            
        }
    }
}
