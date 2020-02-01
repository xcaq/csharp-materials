using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] mass = {2, 6, 10, -5, 6, -44, -1, 0, -5, 10, 11, 3, 7, 3, 500};
            int result = 0;
            int sum = 0;
            for (int i = 0; i < 10 && i > -6; i++)
            {
                sum+=mass[i];
                result++;
            }
            Console.WriteLine($"Total sum of numbers – '{sum}'.\nNumber of integers in range – '{result}'.");

        }
    }
}
