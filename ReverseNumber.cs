using System;

namespace CodingQuestions
{
    public class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Enter the number to reverse : ");
            int num = Convert.ToInt32(Console.ReadLine());
            ReverseInputNumber1(num);
            ReverseInputNumber2(num);
            Recursion(num);
            Console.Read();
        }


        // Method 1 : Convert Number to String and do what we did in ReverseString.cs
        static void ReverseInputNumber1(int num)
        {
            string reverseNumber = string.Empty;

            for (int i = num.ToString().Length - 1; i >= 0; i--)
            {
                reverseNumber += num.ToString()[i];
            }

            Console.WriteLine($"Reverse of {num} is {reverseNumber}");
        }

        static void ReverseInputNumber2(int num)
        {
            int dividend = 0, remainder = 0;

            for (int i = 0; i < num.ToString().Length; i++)
            {
                dividend = i == 0 ? num : dividend;
                remainder = dividend % 10;
                dividend = dividend / 10;
                Console.Write(remainder);
            }

            Console.WriteLine("");
            // How to print it outside the loop using reverseNumber variable
            // Console.WriteLine($"Reverse of {num} is {reverseNumber}");
        }

        static int Recursion(int n)
        {
            if (n == 0)
                return 0;

            Console.Write(n % 10);
            return Recursion(n / 10);
        }
    }
}