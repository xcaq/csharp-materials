using System;
using System.Threading;

namespace homework_1
{
    class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Привет! Это опрос на знание терминов по информатике.");
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
            template("Что из представленного ниже не является яп?", "1 - html, css \r\n2 - cpp, ruby\r\n3 - python, rust", "1");
            template("Какие значения принимает int?", "1 - строковые \r\n2 - числовые\r\n3 - разные\r\n4 - всякие ", "2");
            template("Что такое табуляция?", "1 - пробел \r\n2 - ascii символ для выравнивания текста\r\n3 - язык программирования", "2");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Конец! Правильных ответов - {score}.");
            Console.ResetColor();
        }
        
        static void template(string questionText, string questionVariables, string correctAnswer)
        {
            Console.WriteLine("–––––––––––––––––––");
            Console.WriteLine(questionText);
            Console.WriteLine(questionVariables);
            Console.WriteLine("–––––––––––––––––––");
            Console.WriteLine("Ответ:");
            string answer = Console.ReadLine();
            if (correctAnswer == answer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Правильно!");
                ++score;
            }
            else
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Неправильно! Правильный ответ – {correctAnswer}.");
            }
            Thread.Sleep(3000);
            Console.Clear();
            Console.ResetColor();
        }
    }
}


