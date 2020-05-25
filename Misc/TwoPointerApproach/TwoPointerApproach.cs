using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.Misc.TwoPointerApproach
{

    /* Given a sorted array and a sum find if there is a pair with given sum */
    class TwoPointerApproach
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 8, 10, 15, 19, 21, 30 };
            int l = 0, r = arr.Length - 1;
            Console.WriteLine("Enter the total sum of the elements");
            int x = int.Parse(Console.ReadLine());
            bool exists = TwoPointer(arr, l, r, x);
            if (!exists)
                Console.WriteLine("Pair with sum not found");
            else
                Console.WriteLine("Pair with sum exists");
            Console.ReadLine();
        }

        public static bool TwoPointer(int[] arr, int l, int r, int x)
        {
            while (l < r)
            {
                if (arr[l] + arr[r] == x)
                    return true;
                else if (arr[l] + arr[r] > x)
                    r--;
                else
                    l++; 
            }
            return false;
        }
    }
}
