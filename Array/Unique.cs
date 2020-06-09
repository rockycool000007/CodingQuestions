using System;
using System.Collections.Generic;

namespace CodingQuestions.Array
{
    class Unique
    {
        static void Main()
        {
            int[] arr = { 5, 5, 6, 2, 7, 5, 8, 7 };
            var dict = FindUniques(arr);

            foreach (var item in dict)
            {
                if (item.Value == 1)
                    Console.WriteLine($"{item.Key} is unique");
            }

            Console.Read();
        }

        static Dictionary<int, int> FindUniques(int[] arr)
        {
            Dictionary<int, int> dup = new Dictionary<int, int>();

            for(int i=0; i<arr.Length; i++)
            {
                if (!dup.ContainsKey(arr[i]))
                {
                    dup.Add(arr[i], 1);
                }
                else
                {
                    dup[arr[i]] = dup[arr[i]] + 1;
                }
            }

            return dup;
        }
    }
}
