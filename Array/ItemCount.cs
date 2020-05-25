using System;
using System.Collections.Generic;

namespace CodingQuestions.Array
{
    class ItemCount
    {
        static void Main()
        {
            int[] arr = { 6, 1, 2, 9, 2, 6, 1, 8, 2 };
            Dictionary<int, int> dict = FindElementCount(arr);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} appeared {item.Value} time(s)");
            }

            Console.Read();
        }

        private static Dictionary<int, int> FindElementCount(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], 1);                // set initial count to 1
                }
                else
                {
                    dict[arr[i]] = dict[arr[i]] + 1;    // dict[arr[i]] is the key and value will be the count
                }
            }

            return dict;
        }
    }
}