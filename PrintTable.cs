using System;

namespace CodingQuestions
{
    public class PrintTable
    {
        static void Main()
        {
            Console.Write("Enter a number to print its table : ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintTableForANumber(n);

            Console.Write("Enter a range to print its table : ");
            int range = Convert.ToInt32(Console.ReadLine());
            PrintTablesForRange(range);

            Console.Read();
        }

        private static void PrintTableForANumber(int n)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
                i++;
            }
        }

        private static void PrintTablesForRange(int range)
        {
            for (int i = 2; i <= range; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
