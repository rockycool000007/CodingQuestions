using System;

namespace CodingQuestions.Recursion
{
    public class PercentageForANumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number to find its percentage : ");
            int num = Convert.ToInt32(Console.ReadLine());

            FindPercentage(num, 1);

            Console.ReadLine();
        }

        static void FindPercentage(int num, int percent)
        {
            if (percent > 100)
                return;

            Console.WriteLine($"num % {percent} = {num * percent / 100}");

            FindPercentage(num, (percent + 1));
        }
    }
}