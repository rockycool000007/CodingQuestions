using System;

namespace CodingQuestions
{
    public class ReverseString
    {
        static void Main()
        {
            Console.Write("Enter String to Reverse : ");
            string str = Console.ReadLine();
            ReverseInputString1(str);
            ReverseInputString2(str);
            ReverseInputString3(str, str.Length - 1);
            Console.Read();
        }

        static void ReverseInputString1(string str)
        {
            string reverseString = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }

            Console.WriteLine($"Reverse of '{str}' is '{reverseString}'");
        }

        static void ReverseInputString2(string str)
        {
            string reverseString = string.Empty;
            int n = str.Length - 1;

            while(n >= 0)
            { 
                reverseString += str[n];
                n--;
            }

            Console.WriteLine($"Reverse of '{str}' is '{reverseString}'");
        }

        static string ReverseInputString3(string str, int length)
        {
            string reverseString = string.Empty;

            if (length >= 0)
                reverseString = str[length] + ReverseInputString3(str, length - 1);

            return reverseString;
        }
    }
}