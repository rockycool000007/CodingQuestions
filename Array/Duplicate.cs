using System;
using System.Collections.Generic;

namespace CodingQuestions.Array
{
    class Duplicate
    {
        static void Main()
        {
            int[] arr = { 5, 5, 6, 2, 7, 5, 8, 7 };

            Dictionary<int, int> dict = FindDuplicateElements(arr);

            foreach(KeyValuePair<int, int> item in dict)
            {
                if(item.Value == -1)
                {
                    Console.WriteLine($"{item.Key} is a duplicate item");
                }
            }

            Console.Read();
        }

        private static Dictionary<int, int> FindDuplicateElements(int[] arr)
        {
            Dictionary<int, int> dups = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(!dups.ContainsKey(arr[i]))
                {
                    dups.Add(arr[i], arr[i]);
                }
                else
                {
                    dups[arr[i]] = -1;
                }
            }

            return dups;
        }
    }
}