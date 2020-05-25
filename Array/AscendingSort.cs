using System;
using System.Linq;

namespace CodingQuestions.Array
{
    class AscendingSort
    {
        static void Main()
        {
            int[] arr = { 6, 2, 4, 1, 7, 9, 2 };
            int[] ascSortArr = SortAscending(arr);

            ascSortArr.ToList().ForEach(item =>
            {
                Console.Write($"{item} ");
            });

            Console.Read();
        }

        // Sort by ascending and then,
        // To find second largest element, instead of returning the array, return arr[n-2]
        // For third largest element return arr[n-3]
        private static int[] SortAscending(int[] arr)
        {
            // Bubble Sort
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)    // arr.Length - 1 => since we are comparing with (j + 1)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }

            return arr;
        }
    }
}