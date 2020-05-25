using System;

namespace CodingQuestions.Recursion
{
    class PrintIndividualNumbers
    {
        static void Main()
        {
            int num = Convert.ToInt32(Console.ReadLine());

            PrintNumbers(num);

            Console.Read();
        }

        private static void PrintNumbers(int num)
        {
            if (num < 10)
            {
                Console.Write($"{num} ");
                return;
            }

            PrintNumbers(num / 10);
            Console.Write($"{num % 10} ");
        }
    }
}