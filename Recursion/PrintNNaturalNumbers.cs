using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions.Recursion
{
    class PrintNNaturalNumbers
    {
        static void Main()
        {
            // Print 10 numbers
            int n = 10;
            Print(1, n);
            Console.WriteLine();
            PrintReverse(n);
            Console.WriteLine();
            Console.WriteLine(PrintSum(n));
            Console.Read();
        }

        private static void Print(int startNumber, int n)
        {
            if(startNumber <= n)
            {
                Console.Write($"{startNumber} ");
                Print(startNumber + 1, n);
            }
        }

        private static void PrintReverse(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                PrintReverse(n - 1);
            }
        }

        private static int PrintSum(int n)
        {
            if (n <= 0)
                return 0;

            return n + PrintSum(n - 1);
        }
    }
}