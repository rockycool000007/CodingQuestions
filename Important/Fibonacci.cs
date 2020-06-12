using System;

namespace CodingQuestions.Important
{
    public class Fibonacci
    {
        static void Main()
        {
            Console.Write("Enter 1st number of Fibonacci Series : ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number of Fibonacci Series : ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter length of fibonacci series : ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{firstNum} {secondNum} ");

            // To not pass firstNum and secondNum, you can declare them as global variables

            // length - 2 since 2 elements in the series are already initialized as firstNum and secondNum
            FindFibonacciSeries(firstNum, secondNum, length - 2);

            // length - 2 since 2 elements in the series are already initialized as firstNum and secondNum
            // FindFibonacciSeriesWORecursion(firstNum, secondNum, length - 2);

            Console.Read();
        }

        // Without Recursion
        private static void FindFibonacciSeriesWORecursion(int firstNum, int secondNum, int length)
        {
            for(int i = 0; i< length; i++)
            {
                int thirdNum = firstNum + secondNum;
                Console.Write($"{thirdNum} ");

                firstNum = secondNum;
                secondNum = thirdNum;
            }
        }

        // With Recursion => Ideal solution
        /*
         *  0   1   1   2   3   5   8   13...
            Logic :
            In Fibonacci series, addition of the first 2 numbers in the sequence gives the third number.
            Lets assume the first 2 numbers in the sequence are p1 and p2.
            Thus, to find the 3rd number in the sequence, we need to add p1 and p2. Thus, p1 + p2 = p3. 1 + 1 = 2
            Now, to generate the next number in the sequence, we need to add p2 and p3.
            So, the logic we use is to assign p3 to p2 and p2 to p1 viz p1 = 1 and p2 = 2 by shifting the positions by 1.
            Thus, the next number becomes p1 + p2 = p3 viz 1 + 2 = 3.

            The reason we pass in Main method(n - 2) is because we already have 2 number for which we dont have to loop through.
            With recursion, we pass method(n - 1) since we need to loop it by 1 less to finish the loop
        */
        private static void FindFibonacciSeries(int firstNum, int secondNum, int length)
        {
            if (length == 0)
                return;

            int thirdNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = thirdNum;

            Console.Write($"{thirdNum} ");

            FindFibonacciSeries(firstNum, secondNum, length - 1);
        }
    }
}