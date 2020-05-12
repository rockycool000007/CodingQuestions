using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern5 
    {
        /*
         * Print :
         * 
                6
                6 5
                6 5 4
                6 5 4 3
                6 5 4 3 2
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
            for (int i = n; i >= 1; i--)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write($"{j} ");       
                }
                Console.WriteLine("");
            }
        }
    }
}