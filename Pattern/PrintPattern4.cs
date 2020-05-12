using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern4
    {
        /*
         * Little change in the inner loop logic
            Print 1 :
                1
                2 2
                3 2 1
                4 3 2 1
                5 4 3 2 1
                6 5 4 3 2 1
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
                for (int j = i; j >= 1; j--)
                {
                    Console.Write($"{j} ");       
                }
                Console.WriteLine("");
            }
        }
    }
}