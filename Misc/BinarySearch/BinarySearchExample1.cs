using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.Misc.BinarySearch
{

    //Given a sorted array with repetitions, find the left most index of the element
    class BinarySearchExample1
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 3, 3, 4, 4, 4, 4};
            int l = 0, h = arr.Length - 1;
            Console.WriteLine("Enter the element to be searched");
            int x = int.Parse(Console.ReadLine());
            int pos = LeftMostIndex(arr, l, h, x);
            if (pos == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element found at Position :" + pos);
            Console.ReadLine();
        }

        public static int LeftMostIndex(int[] arr, int l, int h, int x)
        {
            if (l > h)
                return -1;

            int mid = l + (h - l) / 2;
            if (arr[mid] == x && (mid == 0 || arr[mid-1] != x))
                return mid;
            if (arr[mid] >= x )
            {
                return LeftMostIndex(arr, l, mid - 1, x);
            }
            else
            {
                return LeftMostIndex(arr, mid + 1, h, x);
            }

        }

    }
}
