using System;

namespace CodingQuestions.Recursion
{
    public class FetchElements
    {
        static void Main()
        {
            string str = "abcdefghijklmnopqrst";
            FindElements(str, 0);

            Console.Read();
        }

        private static void FindElements(string str, int index)
        {
            string subStr = string.Empty;
            index = index + 1;
            try
            {
                subStr = str.Substring(index, 1);
            }
            catch
            {
                return;
            }

            Console.Write(subStr);
            FindElements(str, index);
        }
    }
}