using System;

namespace CodingQuestions
{
    public class SumOfNaturalNumbers
    {
        static void Main()
        {
            Console.Write("Enter the number of natural numbers you want to add : ");
            int count = Convert.ToInt32(Console.ReadLine());

            FindSumOfNaturalNumbersWORecursion1(count);
            FindSumOfNaturalNumbersWORecursion2(count);
            Console.WriteLine($"Method 3 : Sum of the first {count} natural numbers is : {FindSumOfNaturalNumbersWithRecursion(count)}");

            Console.Read();
        }

        private static int FindSumOfNaturalNumbersWithRecursion(int count)
        {
            if (count.Equals(0))
                return 0;

            return count + FindSumOfNaturalNumbersWithRecursion(count - 1);
        }

        private static void FindSumOfNaturalNumbersWORecursion1(int count)
        {
            int i = count;
            int sum = 0;
            while (i > 0)
            {
                sum += i;
                i--;
            }

            Console.WriteLine($"Method 1 : Sum of the first {count} natural numbers is : {sum}");
        }

        private static void FindSumOfNaturalNumbersWORecursion2(int count)
        {
            int sum = 0;
            for (int i = 1; i <= count; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Method 2 : Sum of the first {count} natural numbers is : {sum}");
        }


    }
}
