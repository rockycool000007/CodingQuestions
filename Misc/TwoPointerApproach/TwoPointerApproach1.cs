using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.Misc.TwoPointerApproach
{

    /* Given a sorted array and a sum find if there is a triplet with given sum */
    class TwoPointerApproachEample1
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 8, 10, 15, 19, 21, 30 };
            int l = 0, r = arr.Length - 1;
            Console.WriteLine("Enter the total sum of the elements");
            int x = int.Parse(Console.ReadLine());
            bool exists = isPair(arr, x);
            if (!exists)
                Console.WriteLine("Triplet with sum not found");
            else
                Console.WriteLine("Triplet with sum exists");
            Console.ReadLine();
        }

        public static bool isPair(int[] arr, int x)
        {
            int n = arr.Length - 1;
            for (int i = 0; i < n; i++)
            {
                if (TwoPointer(arr, i + 1, n, x - arr[i]))
                    return true;
                else
                    return false;
            }
            return false;
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
