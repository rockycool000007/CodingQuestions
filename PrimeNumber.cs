using System;

namespace CodingQuestions
{
    class PrimeNumber
    {
        static void Main()
        {
            Console.Write("Enter Range From : ");
            int from = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Range To : ");
            int to = Convert.ToInt32(Console.ReadLine());

            FindPrimeNumberInaRange(from, to);

            Console.Read();
        }

        static void FindPrimeNumberInaRange(int a, int b)
        {
            if (a > b)
            {
                //// Swap the numbers is from > to viz 100 to 1
                //// We need the input from 1 to 100
                //b = (a + b) - b;
                //a = (a + b) - a;

                // Swap - Method 2
                int tmp = a;
                a = b;
                b = tmp;
            }

            // Run loop for all the numbers to check if every number is a prime
            int i = a;
            while (i <= b)
            {
                bool isPrimeNumber = true;
                // Run the number only till i since we have to divide i by j to find if its divisible by some other number than itself
                for (int j = 2; j <= i; j++)
                {
                    if (!(i.Equals(j)) && ((i % j).Equals(0)))
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }

                if (isPrimeNumber && (i > 1))
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }
    }
}