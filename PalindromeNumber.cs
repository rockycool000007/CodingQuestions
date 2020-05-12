using System;

namespace CodingQuestions
{
    static class PalindromeNumber
    {
        static void Main()
        {
            Console.Write("Enter number to check if its a Palindrome : ");
            int input = Convert.ToInt32(Console.ReadLine());

            CheckIfPalindrome1(input);
            //CheckIfPalindromeRecursion(input);

            Console.Read();
        }

        private static void CheckIfPalindrome1(int input)
        {
            int bkp = input;
            int rem, rev = 0;

            while(input > 0)
            {
                rem = input % 10;

                rev = rev * 10 + rem;

                input = input / 10;
            }

            if(bkp.Equals(rev))
                Console.WriteLine($"{bkp} is a Palindrome");
            else
                Console.WriteLine($"{bkp} is not a Palindrome");
        }

        private static int CheckIfPalindromeRecursion(int input)
        {
            throw new NotImplementedException();
        }
    }
}