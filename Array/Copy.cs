using System;

namespace CodingQuestions.Array
{
    public class Copy
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] copyArr = CopyToArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{copyArr[i]} ");
            }

            Console.Read();
        }

        static int[] CopyToArray(int[] arr)
        {
            int[] copyArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                copyArr[i] = arr[i];
            }
            return copyArr;
        }
    }
}