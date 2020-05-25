using System;

namespace CodingQuestions.Array
{
    class Sum
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Sum of digits in array : " + SumArray(arr, arr.Length - 1));
            Console.Read();
        }

        static int SumArray(int[] arr, int index)
        {
            if (index < 0)
                return 0;

            return arr[index] + SumArray(arr, index - 1);
        }
    }
}