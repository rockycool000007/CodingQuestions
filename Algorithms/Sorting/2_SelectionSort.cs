using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.Algorithms.Sorting
{
    class SelectionSort
    {
        /*
                                Best Case (All items already Sorted)            Worst Case (Items Sorted In Reverse Order)
            Passes              O(n)                                            O(n)
            Comparisions        O(n)                                            O(n)
                                Quadratic : O(n^2)                              Quadratic : O(n^2)

            How does Selection Sort work ?
            Selection Sort divides an array into Sorted and Unsorted list.
            In every pass, you find the smallest number and then add it to the sorted list. The rest items becomes unsorted list of which we have to find 
            minimum items in the next pass
            8   2   4   3   1

            1st pass :
                Find smallest number in the unsorted list, exchange its position with 0th index and consider it in the sorted list
                1   2   4   3   8           -- 1 is sorted list while others are unsorted
            2nd pass :
                1   2   4   3   8           -- 1, 2 is sorted list while others are unsorted
            3rd pass :
                1   2   3   4   8           -- 1, 2, 3 is sorted list while others are unsorted
            4th pass :
                1   2   3   4   8           -- 1, 2, 3, 4 is sorted list while others are unsorted
        */

        static void Main()
        {
            int[] arr = { 8, 2, 4, 3, 1 };
            int[] sortedArr = Sort(arr);
            Console.Read();
        }

        static int[] Sort(int[] arr)
        {
            return arr;
        }
    }
}