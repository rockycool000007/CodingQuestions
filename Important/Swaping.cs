using System;

namespace CodingQuestions.Important
{
    public class Swaping
    {
        static void Main()
        {
            Console.Write("Enter first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a = {a}, b = {b} before swapping");

            SwapTheNumbers(a, b);
            SwapTheNumbersWOTempVariable(a, b);

            Console.ReadLine();
        }

        // Using a temporary variable
        private static void SwapTheNumbers(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a = {a}, b = {b} after swapping using method 1");
        }

        // Without using a temporary variable => Ideal solution
        private static void SwapTheNumbersWOTempVariable(int a, int b)
        {
            a = a + b;      // 100 + 20 (120)
            b = a - b;      // 100      (120 - 20)
            a = a - b;      // 20       (120 - 20)

            Console.WriteLine($"a = {a}, b = {b} after swapping using method 2");
        }
    }
}