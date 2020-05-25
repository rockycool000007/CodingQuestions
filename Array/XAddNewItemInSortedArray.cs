using System;

namespace CodingQuestions.Array
{
    public class XAddNewItemInSortedArray
    {
        static void Main()
        {
            int[] arr = { 1, 2, 4, 5, 6, 9 };
            int newItem = Convert.ToInt32(Console.ReadLine());
            int[] newArr = AddSortedItem(arr, newItem);

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine($"{newArr[i]} ");
            }

            Console.Read();
        }

        static int[] AddSortedItem(int[] arr, int itemToAdd)
        {
            int[] newArr = new int[arr.Length + 1];
            bool itemAdded = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > itemToAdd)
                {
                    int tmp = newArr[i];
                    newArr[i] = itemToAdd;
                    itemAdded = true;
                }
                else
                    newArr[i] = arr[i];
            }

            if (itemAdded)
                newArr[arr.Length] = arr[arr.Length - 1];
            else
                newArr[arr.Length] = itemToAdd;

            return newArr;
        }
    }
}