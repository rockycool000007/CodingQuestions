using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern2
    {
        /*
            Print 1 :
                1
                1 2
                1 2 3
                1 2 3 4
                1 2 3 4 5
                1 2 3 4 5 6
         */
        static void Main()
        {
            Console.Write("Enter a number for printing times : ");
            int n = Convert.ToInt32(Console.ReadLine());

            PrintPattern(n);

            Console.Read();
        }

        private static void PrintPattern(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");       
                }
                Console.WriteLine("");
            }
        }
    }
}