using System;

namespace CodingQuestions.Important
{
    public class Anagram
    {
        static void Main()
        {
            Console.Write("Enter string 1 :");
            string str1 = Console.ReadLine();

            Console.Write("Enter string 2 :");
            string str2 = Console.ReadLine();

            Console.WriteLine($"Are the string anagram ? {FindIfAnagram1(str1, str2)}");

            Console.ReadLine();
        }

        private static bool FindIfAnagram1(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            int sum1 = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                sum1 += Convert.ToInt32(str1[i]);
            }

            int sum2 = 0;
            for (int j = 0; j < str2.Length; j++)
            {
                sum2 += Convert.ToInt32(str2[j]);
            }

            if (sum1.Equals(sum2))
                return true;
            else
                return false;
        }
    }
}