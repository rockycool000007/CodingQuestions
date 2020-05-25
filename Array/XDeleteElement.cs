using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.Array
{
    class XDeleteElement
    {
        static void Main()
        {
            int[] arr = { 3, 5, 6, 8, 9, 2 };
            int test = DeleteArrayElement(arr, arr.Length, 5);

            Console.Read();
        }

        private static int DeleteArrayElement(int[] arr, int n, int x)
        {
            // If x is the last element, dont do anything
            if (arr[n - 1] == x)
                return n - 1;

            // Start from right most element and keep moving elements one position ahead
            int prev = arr[n - 1], i = 0;

            for (i = n - 2; i >= 0 && arr[i] != x; i--)
            {
                int curr = arr[i];
                arr[i] = prev;
                prev = curr;
            }

            // If element is not found
            if (i < 0)
                return 0;

            // Else move next element in place of x
            arr[i] = prev;

            return (n - 1);
        }
    }
}