using System;
using System.Collections.Generic;

namespace CodingQuestions.Array
{
    class Unique
    {
        static void Main()
        {
            int[] arr = { 5, 5, 6, 2, 7, 5, 8, 7 };
            var dict = FindUniqueElements(arr);

            foreach (var item in dict)
            {
                if (item.Value == -1)
                    Console.WriteLine($"{item.Key} is unique");
            }

            Console.Read();
        }

        static Dictionary<int, int> FindUniqueElements(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]] = arr[i];
                }
                else
                {
                    dict.Add(arr[i], -1);
                }
            }

            return dict;
        }
    }
}