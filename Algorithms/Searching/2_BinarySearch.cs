using System;

namespace CodingQuestions.Algorithms.Searching
{
    class BinarySearch
    {
        static void Main()
        {
            int[] arr = { 3, 5, 6, 9, 11, 18, 20, 21, 24, 30 };
            UseBinarySearch(arr, 6);

            Console.Read();
        }

        /*
            Time Complexity : O(log n) since after every pass it reduces the number of elements by half 

            3, 5, 6, 9, 11, 18, 20, 21, 24, 30          => (0 + 9) / 2


        */
        static int UseBinarySearch(int[] arr, int numberToSearch)
        {
            int left = 0;
            int right = arr.Length - 1;

            while(left <= right)
            {
                int middle = (left + right) / 2;

                if (arr[middle] == numberToSearch) return middle;

                if(arr[middle] > numberToSearch)    // numberToSearch is on the left side
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;      // Value does not exist
        }
    }
}