using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern6
    {
        /*
         * Print :
         * 
                6
                5 5
                4 5 4
                3 3 3 3
                2 2 2 2 2
                1 1 1 1 1 1
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
            for (int i = n; i >= 1; i--)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write($"{i} ");       
                }
                Console.WriteLine("");
            }
        }
    }
}