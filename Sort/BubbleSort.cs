using System;
using System.Threading.Tasks;

namespace CodingQuestions.Sort
{
    public class BubbleSort
    {
        static void Main()
        {
            int[] arr = { 1, 4, 3, 6, 2, 5 };
            int[] newArr = DoBubbleSort(arr);

            // int[] newArr = DoBubbleSort2(arr);

            //foreach(int item in newArr)
            //    Console.WriteLine(item);

            Parallel.ForEach(newArr, item =>
            {
                Console.WriteLine(item);
            });

            Console.Read();
        }


        // 1 4 3 6 2 5
        // i 
        //   j

        /*
         *  Logic :
         *  BubbleSort compares every adjacent item and swaps the position if the number on RHS is smaller than LHS number
         *  Eg : 
         *  In the above example, 1 < 4 => true, hence the position wont be swapped.                                        Array : { 1, 4, 3, 6, 2, 5 }
         *  4 < 3 => false, hence the positions must be swapped and 3 will be moved to LHS and 4 will be on RHS.            Array : { 1, 3, 4, 6, 2, 5 }
         *  4 < 6 => true, no swapping.                                                                                     Array : { 1, 3, 4, 6, 2, 5 }
         *  6 < 2 => false, swap positions                                                                                  Array : { 1, 3, 4, 2, 6, 5 }
         *  This process is repeated for all the items
        */
        private static int[] DoBubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            return arr;
        }

        private static int[] DoBubbleSort2(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if((arr[i] > arr[ i + 1]) && (i < arr.Length - 1))
                {
                    int tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                }
            }

            return arr;
        }
    }
}