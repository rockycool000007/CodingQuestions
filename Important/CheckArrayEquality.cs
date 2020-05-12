using System;

namespace CodingQuestions.Important
{
    public class CheckArrayEquality
    {
        static void Main()
        {
            int[] intArr1 = { 3, 4, 8, 5, 1 };
            int[] intArr2 = { 3, 4, 8, 5 };
            int[] intArr3 = { 3, 7, 8, 5, 1 };
            int[] intArr4 = { 3, 4, 8, 5, 1 };

            Console.WriteLine(IsArrayEqual(intArr1, intArr2)); // False => Different length
            Console.WriteLine(IsArrayEqual(intArr1, intArr3)); // False => Different second element
            Console.WriteLine(IsArrayEqual(intArr1, intArr4)); // True

            Console.Read();
        }

        // Without Recursion
        private static string IsArrayEqual(int[] arr1, int[] arr2)
        {
            string notEqual = "Array not equal";
            string isEqual = "Array equal";

            if (arr1.Length != arr2.Length)
            {
                isEqual = notEqual;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)  // Since both arrays are of equal length as it passed above condition
                {
                    if (arr1[i] != arr2[i])
                    {
                        isEqual = notEqual;
                        break;
                    }
                }
            }

            return isEqual;
        }
    }
}