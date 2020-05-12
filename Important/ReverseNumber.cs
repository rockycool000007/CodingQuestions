using System;

namespace CodingQuestions.Important
{
    public class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Enter a number to reverse : ");
            int num = Convert.ToInt32(Console.ReadLine());

            ReverseWORecursion(num);
            Console.WriteLine("");
            Reverse(num);

            Console.Read();
        }

        // Without Recursion
        private static void ReverseWORecursion(int num)
        {
            while (num != 0)
            {
                Console.Write(num % 10);
                num = num / 10;
            }
        }

        // With Recursion => Ideal Solution
        private static void Reverse(int num)
        {
            if (num != 0)
            {
                Console.Write(num % 10);
                Reverse(num / 10);
            }
        }
    }
}