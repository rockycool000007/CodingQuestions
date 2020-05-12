using System;

namespace CodingQuestions.Important
{
    public class PowerOfNumber
    {
        static void Main()
        {
            Console.Write("Enter a number to calculate its power : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the power : ");
            int power = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{number} ^ {power} = {FindPowerWORecursion(number, power)}");
            Console.WriteLine($"{number} ^ {power} = {FindPower(number, power)}");

            Console.ReadLine();
        }

        // Without Recursion
        private static int FindPowerWORecursion(int number, int power)
        {
            int returnNumber = 1;
            for (int i = 1; i <= power; i++)
            {
                returnNumber *= number;
            }

            return returnNumber;
        }

        // With Recursion => Ideal Solution
        private static int FindPower(int number, int power)
        {
            if (power == 0)
                return 1;

            return number * FindPower(number, power - 1);
        }
    }
}