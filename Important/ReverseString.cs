using System;

namespace CodingQuestions.Important
{
    public class ReverseString
    {
        static void Main()
        {
            Console.Write("Enter a word to reverse : ");
            string str = Console.ReadLine();

            Console.WriteLine(ReverseSentenceOrWord(str, str.Length - 1));
            Console.WriteLine(ReverseSentenceOrWordWORecursion(str));

            Console.ReadLine();
        }

        // Without Recursion
        private static string ReverseSentenceOrWordWORecursion(string str)
        {
            string reversestr = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str += str[i];
            }
            return reversestr;
        }

        // With Recursion => Ideal Solution
        private static string ReverseSentenceOrWord(string str, int length)
        {
            if (length < 0)
                return null;

            return str[length] + ReverseSentenceOrWord(str, length - 1);
        }
    }
}