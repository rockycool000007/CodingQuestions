using System;

namespace CodingQuestions.Important
{
    public class SumOfANumber
    {
        static void Main()
        {
            Console.Write("Enter a number to find sum of its digits : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(FindSumWORecursion(num));
            Console.WriteLine(FindSum(num));

            Console.ReadLine();
        }

        // Without recursion
        private static int FindSumWORecursion(int num)
        {
            int sum = 0;
            while(num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }

        // With Recursion => Ideal solution
        private static int FindSum(int num)
        {
            if (num == 0)
                return 0;

            return (num % 10) + FindSum(num / 10);
        }
    }
}