using System;

namespace CodingQuestions
{
    public class SwapNumbers
    {
        static void Main()
        {
            Console.Write("Enter the first number to Swap : ");
            int a = Convert.ToInt32( Console.ReadLine());

            Console.Write("Enter the second number to Swap : ");
            int b = Convert.ToInt32(Console.ReadLine());

            SwapTwoNumbers(a, b);
            
            Console.Read();
        }

        private static void SwapTwoNumbers(int a, int b)
        {
            Console.WriteLine($"First Number : {a}, Second Number : {b}");

            a += b;     // 8 + 20 => 28
            b = a - b;  // 28 - 8 => 20
            a -= b;     // 28 - 20 => 8

            Console.WriteLine($"First Number : {a}, Second Number : {b} after swapping");
        }
    }
}