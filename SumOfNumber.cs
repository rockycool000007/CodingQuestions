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

        static int FindSumOfEnteredNumber(int num)
        {
            int sum = 0;

            while(num != 0)
            {
                int div = num % 10;
                num = num / 10;
                sum += div;
            }

            return sum;
        }
    }
}