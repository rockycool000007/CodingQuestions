using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern9
    {
        /*
         * Print :
         * 
                6 5 4 3 2 1
                6 5 4 3 2
                6 5 4 3
                6 5 4
                6 5
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
            for (int i = n; i >= 1; i--)
            {
                for (int j = n; j >= count; j--)
                {
                    Console.Write($"{j} ");       
                }
                count++;
                Console.WriteLine("");
            }
        }
    }
}