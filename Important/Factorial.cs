using System;

namespace CodingQuestions.Important
{
    public class Factorial
    {
        static void Main()
        {
            Console.Write($"Enter number to find its factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Factorial of {num} using Method 1 is : {FindFactorial(num)}");
            Console.WriteLine($"Factorial of {num} using Method 2 is : {FindFactorialWORecursion(num)}");

            Console.ReadLine();
        }

        // Without Recursion
        private static int FindFactorialWORecursion(int num)
        {
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }

        // With Recursion => Ideal solution
        private static int FindFactorial(int num)
        {
            if (num == 0)
                return 1;

            return num * FindFactorial(num - 1);
        }
    }
}