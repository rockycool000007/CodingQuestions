using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.Misc.BinarySearch
{
    class BinarySearch
    {

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 34, 45, 67, 78, 94, 100 };
            int l = 0, h = arr.Length - 1;
            Console.WriteLine("Enter the element to be searched");
            int x = int.Parse(Console.ReadLine());
            int pos = BinarySearchRecursive(arr, l, h, x);
            if (pos == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element found at Position :" + pos);
            Console.ReadLine();
        }

        public static int BinarySearchRecursive(int[] arr, int l, int h, int x) 
        {
            if (l > h)
                return -1;

            int mid = l + (h - l) / 2;
            if (arr[mid] == x)
                return mid;
            if(arr[mid] > x)
            {
                return BinarySearchRecursive(arr, l, mid-1, x);
            }
            else
            {
                return BinarySearchRecursive(arr, mid + 1, h, x);
            }

        }

    }
}
