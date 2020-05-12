using System;

namespace CodingQuestions
{
    public class FactorsOfNumber
    {
        static void Main()
        {
            Console.Write("Enter the number to find its factor : ");
            int num = Convert.ToInt32(Console.ReadLine());

            FindFactors1(num);
            FindFactors2(num);
            Console.WriteLine(FindFactorsWithRecursion(num));

            Console.Read();
        }

        private static string FindFactorsWithRecursion(int num, int factors = 1)
        {
            if (factors >= num)
                return null;

            if ((num % factors).Equals(0))
                return factors + ", " + FindFactorsWithRecursion(num, (factors + 1));
            else
                return null;
        }

        private static void FindFactors1(int num)
        {
            Console.Write("Method 1 : ");
            int i = 1;
            while (i <= num)
            {
                if ((num % i).Equals(0))
                    Console.Write($"{i}, ");

                i++;
            }

            Console.WriteLine("");
        }

        private static void FindFactors2(int num)
        {
            Console.Write("Method 2 : ");

            for (int i = 1; i <= num; i++)
            {
                if ((num % i).Equals(0))
                    Console.Write($"{i}, ");
            }

            Console.WriteLine("");
        }
    }
}