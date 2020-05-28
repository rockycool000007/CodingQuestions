using System;

namespace CodingQuestions.Important
{
    public class CountLengthOfNumber
    {
        static void Main()
        {
            Console.Write("Enter number to find its length : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The length of the number is : {FindLengthOfNumberWORecursion(num)}");
            Console.WriteLine($"The length of the number is : {FindLengthOfNumber(num)}");
            Console.Read();
        }

        // Without Recursion
        private static int FindLengthOfNumberWORecursion(int num)
        {
            int len = 0;

            while(num != 0)
            {
                len++;
                num /= 10;
            }

            return len;
        }

        // With Recursion => Ideal Solution
        private static int FindLengthOfNumber(int num)
        {
            int len = 0;
            if (num > 0)
            {
                len++;
                return len + FindLengthOfNumber(num / 10);
            }
            
            return len;
        }
    }
}