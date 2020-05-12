using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern12
    {
        /*
         * Print :
         * 
                1 2 3 4 5 6
                2 3 4 5 6
                3 4 5 6
                4 5 6
                5 6
                6
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
            int count = 6;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= count; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine("");
            }
        }
    }
}