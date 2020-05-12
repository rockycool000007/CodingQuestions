using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern10
    {
        /*
         * Print :
         * 
                1 1 1 1 1 1
                2 2 2 2 2
                3 3 3 3
                4 4 4
                5 5
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
            int count = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= count; j--)
                {
                    Console.Write($"{i} ");       
                }
                count++;
                Console.WriteLine("");
            }
        }
    }
}