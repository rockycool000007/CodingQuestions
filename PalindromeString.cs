using System;

namespace CodingQuestions
{
    static class PalindromeString
    {
        static void Main()
        {
            Console.Write("Enter string to check if its a Palindrome : ");
            string input = Console.ReadLine();

            Console.WriteLine(CheckIfPalindrome(input));
            /* Both the string are using (n /2) and lowIndex < highIndex since the number of loop iterations be less */
            Console.WriteLine(CheckIfPalindrome1(input));
            Console.WriteLine(CheckIfPalindrome2(input));

            Console.Read();
        }

        private static bool CheckIfPalindrome(string input)
        {
            int start = 0;
            int end = input.Length - 1;
            for (int i = 0; start < end; i++)
            {
                if (input[start] != input[end]) return false;
                start++;
                end--;
            }

            return true;
        }

        private static bool CheckIfPalindrome1(string input)
        {
            int n = input.Length;
            int j = 0;      // lowest index
            int k = n - 1;  // highest index

            while (j < k)
            {
                if (!input[j].Equals(input[k]))
                {
                    return false;
                }

                j++;
                k--;
            }

            return true;
        }

        private static bool CheckIfPalindrome2(string input)
        {
            int n = input.Length;
            int j = 0;      // lowest index
            int k = n - 1;  // highest index

            for (int i = 0; i < n / 2; i++)
            {
                if (!input[j].Equals(input[k]))
                {
                    return false;
                }

                j++;
                k--;
            }

            return true;
        }
    }
}