using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern3
    {
        /*
            Print 1 :
                1
                2 3
                4 5 6
                7 8 9 10
                11 12 13 14 15
                15 16 17 18 19 20
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
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    num++;
                    Console.Write($"{num} ");       
                }
                Console.WriteLine("");
            }
        }
    }
}