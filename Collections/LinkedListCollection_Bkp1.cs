using System;

namespace CodingQuestions.Collections
{
    class LinkedListCollection_Bkp1
    {
        static void Main()
        {
            //Node myNode = new Node(7);
            //myNode.next = new Node(4);
            //myNode.next.next = new Node(5);
            //myNode.next.next.next = new Node(10);
            //myNode.Print();

            Console.Read();
        }
    }

    #region Linked List

    //public class Node
    //{
    //    public int data;
    //    public Node next;

    //    public Node(int i)
    //    {
    //        data = i;
    //        next = null;
    //    }

    //    public void Print()
    //    {
    //        Console.Write("|" + data + "| => ");

    //        if(next != null)
    //        {
    //            next.Print();
    //        }
    //    }

    //    public void AddToEnd(int data)
    //    {
    //        if(next == null)
    //        {
    //            next = new Node(data);
    //        }
    //        else
    //        {
    //            next.AddToEnd(data);
    //        }
    //    }
    //}

    #endregion

    #region Single Linked List
    //internal class SingleLinkedList
    //{
    //    internal Node head;

    //    internal void InsertLast(SingleLinkedList singlyList, int new_data)
    //    {
    //        Node new_node = new Node(new_data);
    //        if (singlyList.head == null)
    //        {
    //            singlyList.head = new_node;
    //            return;
    //        }
    //        Node lastNode = GetLastNode(singlyList);
    //        lastNode.next = new_node;
    //    }

    //    internal Node GetLastNode(SingleLinkedList singlyList)
    //    {
    //        Node temp = singlyList.head;
    //        while (temp.next != null)
    //        {
    //            temp = temp.next;
    //        }
    //        return temp;
    //    }
    //}

    //internal class Node
    //{
    //    internal int data;
    //    internal Node next;
    //    public Node(int d)
    //    {
    //        data = d;
    //        next = null;
    //    }
    //}
    #endregion

    #region Double Linked List
    //internal class DoubleLinkedList
    //{
    //    internal DNode head;
    //}

    //internal class DNode
    //{
    //    internal int data;
    //    internal DNode prev;
    //    internal DNode next;
    //    public DNode(int d)
    //    {
    //        data = d;
    //        prev = null;
    //        next = null;
    //    }
    //}
    #endregion
}