using System;

namespace CodingQuestions.Pattern
{
    public class PrintPattern1
    {
        /*
            Print 1 :
                *
                * *
                * * *
                * * * *
                * * * * *
                * * * * * * 
            
            Print 2 :
                1
                2 2
                3 3 3
                4 4 4 4
                5 5 5 5 5
                6 6 6 6 6 6
         */
        static void Main()
        {
            Console.Write("Enter a number for printing times : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a character for printing : ");
            string patternToPrint = Console.ReadLine();

            PrintPattern(n, patternToPrint);

            Console.Read();
        }

        private static void PrintPattern(int n, string characterToPrint = null)
        {
            int i = 1;
            while (i <= n)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (!String.IsNullOrEmpty(characterToPrint))
                        Console.Write(characterToPrint);
                    else
                        Console.Write($"{i} ");
                }
                i++;
                Console.WriteLine("");
            }
        }
    }
}