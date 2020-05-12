using System;

namespace CodingQuestions
{
    public class FactorsOfNumberSum
    {
        static void Main()
        {
            Console.Write("Enter the number to find its factor : ");
            int num = Convert.ToInt32(Console.ReadLine());

            FindFactors1(num);
            FindFactors2(num);
            Console.WriteLine($"Recursion : Sum of the factors of number {num} is {FindFactorsWithRecursion(num)}");

            Console.Read();
        }

        private static int FindFactorsWithRecursion(int num, int factors = 1)
        {
            if (factors > num)
                return 0;

            if ((num % factors).Equals(0))
                return factors + FindFactorsWithRecursion(num, (factors + 1));
            else
                return FindFactorsWithRecursion(num, (factors + 1));
        }

        private static void FindFactors1(int num)
        {
            Console.Write("Method 1 : ");
            int i = 1;
            int sum = 0;
            while (i <= num)
            {
                if ((num % i).Equals(0))
                    sum += i;

                i++;
            }
            Console.Write($"Sum of the factors of number {num} is {sum}");
            Console.WriteLine("");
        }

        private static void FindFactors2(int num)
        {
            Console.Write("Method 2 : ");
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if ((num % i).Equals(0))
                    sum += i;
            }

            Console.Write($"Sum of the factors of number {num} is {sum}");
            Console.WriteLine("");
        }
    }
}