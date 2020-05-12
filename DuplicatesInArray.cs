using System;
using System.Collections.Generic;

namespace CodingQuestions
{
    public class DuplicatesInArray
    {
        static void Main()
        {
            int[] arr = { 2, 2, 2, 5, 7, 9, 5, 6, 3 };

            FindDuplicates3(arr);
            FindDuplicates(arr);
            FindDuplicates2(arr);
            Console.Read();
        }

        // Time Complexity : O(n * n) = O(n2)
        static void FindDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = (i + 1); j < arr.Length; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        Console.WriteLine($"{arr[i]} is a duplicate");
                        break;
                    }
                }
            }
        }

        // Time Complexity : O(n)
        static void FindDuplicates2(int[] arr)
        {
            int size = arr.Length;
            int[] count = new int[256];

            Console.Write("Repeated elements are: ");
            for (int i = 0; i < size; i++)
            {
                int arri = arr[i];
                int countarr = count[arr[i]];
                if (count[arr[i]] == 1)
                    Console.Write(arr[i] + " ");
                else
                    count[arr[i]]++;
            }
        }

        static void FindDuplicates3(int[] arr)
        {
            List<int> nonDuplicateList = new List<int>();
            
            foreach(int item in arr)
            {
                if(!nonDuplicateList.Contains(item))
                {
                    nonDuplicateList.Add(item);
                }
                else
                {
                    Console.WriteLine($"{item} is a duplicate !!!");
                }
            }

        }
    }
}
