using System;
using System.Linq;

namespace CodingQuestions.Array
{
    class MaxMinItem
    {
        static void Main()
        {
            int[] arr = { 5, 7, 4, 3, 2 };
            var items = MaxAndMin(arr);
            Console.WriteLine($"Min: {items.Item1}, Max: {items.Item2}");
            Console.Read();
        }

        static (int, int) MaxAndMin(int[] arr)
        {
            // Approach 2
            int minItem = arr.Min(x => x);
            int maxItem = arr.Max(x => x);

            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }

                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return (min, max);
        }
    }
}