using System;

namespace CodingQuestions
{
    public class EvenOdd
    {
        public static void Main()
        {
            Console.Write("Enter Range From : ");
            int from = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Range To : ");
            int to = Convert.ToInt32(Console.ReadLine());
            FindEvenOddNumbersInaRange(from, to);
            Console.Read();
        }

        private static void FindEvenOddNumbersInaRange(int from, int to)
        {
            for(int i = from; i<= to; i++)
            {
                if((i % 2).Equals(0))
                    Console.WriteLine($"{i} is Even");
                else
                    Console.WriteLine($"{i} is Odd");
            }
        }
    }
}