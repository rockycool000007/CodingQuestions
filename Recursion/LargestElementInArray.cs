namespace CodingQuestions.Recursion
{
    public class LargestElementInArray
    {
        //static void Main()
        //{
        //    int[] arr = { 23, 42, 12, 34, 53, 24 };
        //    FindLargestElement(arr);
        //    Console.Read();
        //}

        //private static int FindLargestElement(int[] arr)
        //{
        //    int i = 0;
        //    if(i < arr.Length - 1)
        //    {

        //        i++;
        //    }
        //}

        #region Find Number Of Digits

        // Iterative solution
        int FindNumberOfDigits1(long num)
        {
            int count = 0;
            while (num != 0)
            {
                num = num / 10;
                ++count;
            }

            return count;
        }

        // Recursive solution
        int FindNumberOfDigits2(long num)
        {
            if (num == 0)
                return 0;

            return 1 + FindNumberOfDigits2(num / 10);
        }

        #endregion
    }
}