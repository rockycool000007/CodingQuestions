using System;

namespace CodingQuestions.Array
{
    public class Reverse
    {
        static void Main()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ReverseArray(arr);
            Console.WriteLine();
            RevArray(arr, arr.Length - 1);
            Console.Read();
        }

        static void ReverseArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void RevArray(int[] arr, int len)
        {
            if (len < 0)
                return;

            Console.Write(arr[len] + " ");
            RevArray(arr, len - 1);
        }
    }
}