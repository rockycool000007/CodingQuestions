using System;

namespace CodingQuestions.Array
{
    public class Reverse
    {
        static void Main()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ReverseArray(arr);
            Console.Read();
        }

        static void ReverseArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}