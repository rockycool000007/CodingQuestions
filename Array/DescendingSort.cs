using System;
using System.Linq;

namespace CodingQuestions.Array
{
    class DescendingSort
    {
        static void Main()
        {
            int[] arr = { 6, 2, 4, 1, 7, 9, 2 };
            int[] ascSortArr = SortDescending(arr);

            ascSortArr.ToList().ForEach(item =>
            {
                Console.Write($"{item} ");
            });

            Console.Read();
        }

        private static int[] SortDescending(int[] arr)
        {
            // Bubble Sort
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)    // arr.Length - 1 => since we are comparing with (j + 1)
                {
                    if (arr[j] < arr[j + 1])
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