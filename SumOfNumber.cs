using System;

namespace CodingQuestions
{
    public class SumOfNumber
    {
        static void Main()
        {
            Console.Write("Enter a number to find sum of its digits : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum of {num} is {FindSumOfEnteredNumber(num)}");
            
            Console.Read();
        }

        static int FindSum(int num)
        {
            if (num == 0)
                return 0;

            return num % 10 + FindSum(num / 10);
        }

        static int FindSumOfEnteredNumber(int num)
        {
            int sum = 0;

            while(num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}