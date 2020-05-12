using System;

namespace CodingQuestions.Important
{
    public class FibonacciForARange
    {
        static void Main()
        {
            Console.Write("Enter 1st number of Fibonacci Series : ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number of Fibonacci Series : ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number till which you want to generate the fibonacci series : ");
            int rangeTo = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{firstNum} {secondNum} ");

            // length - 2 since 2 elements in the series are already initialized as firstNum and secondNum
            FindFibonacciSeries(firstNum, secondNum, rangeTo);

            // length - 2 since 2 elements in the series are already initialized as firstNum and secondNum
            // FindFibonacciSeriesWORecursion(firstNum, secondNum, length - 2);

            Console.Read();
        }

        // With Recursion => Ideal solution
        private static void FindFibonacciSeries(int firstNum, int secondNum, int rangeTo)
        {
            int thirdNum = firstNum + secondNum;

            if (thirdNum > rangeTo)
                return;

            Console.Write($"{thirdNum} ");

            firstNum = secondNum;
            secondNum = thirdNum;

            FindFibonacciSeries(firstNum, secondNum, rangeTo);
        }
    }
}