namespace CodingQuestions.Collections
{
    class MyLinkedList
    {
        private Node Head;
        private Node Tail;

        #region Add First Node
        public void AddFirst(int item)
        {
            var node = new Node(item);
            var headNode = Head;

            // If head is null, it means the element is the first element
            if (Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }
        #endregion

        #region Add Last Node
        public void AddLast(int item)
        {
            var node = new Node(item);

            ///// If condition
            // If there is no node at the start
            // It means head and tail are pointing to null
            // Hence when we add the node, head and tail will be the same for the first element added in the linked list
            ///// Else condition
            // 1st node exists and now we are adding a new node
            // Head wont change. Tail will hence point to the last node
            // Tail will now leave the current node to be the new node. Hence, Tails next will have the reference of new node as its next.
            if (Head == null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
        #endregion

        #region Delete First Node
        public void DeleteFirst()
        {
            // If there is no node
            if (Head == null) return;

            // If there is only one node viz Head = Tail
            if(Head == Tail)
            {
                Head = Tail = null;
                return;
            }

            var newHeadNode = Head.Next;
            Head.Next = null;
            Head = newHeadNode;
        }
        #endregion

        #region Delete Last Node
        void DeleteLast()
        {
            // If there is no node
            if (Tail == null) return;

            // If there is only one node
            if(Head == Tail)
            {
                Head = Tail = null;
                return;
            }

            var currentNode = Head;
            while(currentNode != null)
            {
                if (currentNode.Next == Tail) break;
                currentNode = currentNode.Next;
            }
        }
        #endregion

        #region Contains Node
        public bool Contains(int item)
        {
            return IndexOf(item) < 0 ? false : true;
        }
        #endregion

        #region Index Of
        public int IndexOf(int item)
        {
            int index = 0;
            var current = Head;

            while (current != null)
            {
                if (current.Value.Equals(item)) return index;
                current = current.Next;
                index++;
            }

            return -1;
        }
        #endregion
    }
}