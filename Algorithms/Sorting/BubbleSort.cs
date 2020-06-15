using System;

namespace CodingQuestions.Algorithms.Sorting
{
    public class BubbleSort
    {
        /*
                                Best Case (All items already Sorted)            Worst Case (Items Sorted In Reverse Order)
            Passes              O(1)                                            O(n)
            Comparisions        O(n)                                            O(n)
                                Linear : O(n)                                   Quadratic : O(n^2)

            How does Bubble Sort work ? i = (n - 1) passes, j > j-1 ? swap : as it is
            8   2   4   3   1
            
            1st pass : 
                8 > 2 ?     2   8   4   3   1   (swap)
                8 > 4 ?     2   4   8   3   1   (swap)
                8 > 3 ?     2   4   3   8   1   (swap)
                8 > 1 ?     2   4   3   1   8   (swap)
            2nd pass :
                2 > 4 ?     2   4   3   1   8
                4 > 3 ?     2   3   4   1   8   (swap)
                4 > 1 ?     2   3   1   4   8   (swap)
                4 > 8 ?     2   3   1   4   8   
            3rd pass :
                2 > 3 ?     2   3   1   4   8
                3 > 1 ?     2   1   3   4   8   (swap)
                3 > 4 ?     2   1   3   4   8
                4 > 8 ?     2   1   3   4   8
            4th pass :
                2 > 1 ?     1   2   3   4   8   (swap)
                2 > 3 ?     1   2   3   4   8
                3 > 4 ?     1   2   3   4   8
                4 > 8 ?     1   2   3   4   8
        */

        static void Main()
        {
            int[] arr = { 8, 2, 4, 3, 1 };
            int[] sortedArr = SortArray(arr);
            Console.Read();
        }

        static int[] SortArray(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[(j - 1)])          // arr[j] > arr[(j - 1)] for descending order
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}