using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingQuestions.Collections
{
    class LinkedListCollection
    {
        static void Main()
        {
            // Example 1
            MyLinkedList mli = new MyLinkedList();
            mli.AddLast(10);
            mli.AddLast(30);
            mli.AddLast(20);

            var index = mli.IndexOf(30);
            var contains1 = mli.Contains(30);
            var contains2 = mli.Contains(40);

            // Example 2
            LinkedList<int> li = new LinkedList<int>();
            li.AddLast(23);
            li.AddLast(75);
            li.AddLast(16);
            li.AddLast(49);
            li.AddFirst(80);

            li.RemoveFirst();
            var firstNode = li.First();
            var lastNode = li.Last();
            var cnt = li.Count();

            Console.WriteLine(li.Contains(80));
            
            Console.Read();
        }
    }
}