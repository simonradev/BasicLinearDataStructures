namespace LinkedQueue
{
    using System;
    
    public class LinkedQueue<TType>
    {
        private class Node
        {
            private TType value;
            private Node nextElement;
            private Node previousElement;

            public Node(TType value)
                : this (value, default(Node))
            {
            }

            public Node(TType value, Node previousNode)
            {
                this.value = value;
                this.nextElement = default(Node);
                this.previousElement = previousNode;
            }

            public TType Value
            {
                get { return this.value; }
                set { this.value = value; }
            }

            public Node Next
            {
                get { return this.nextElement; }
                set { this.nextElement = value; }
            }

            public Node Previous
            {
                get { return this.previousElement; }
                set { this.previousElement = value; }
            }
        }

        private Node head;
        private Node tail;

        private int count;

        public LinkedQueue()
        {
            this.head = default(Node);
            this.tail = default(Node);

            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Enqueue(TType elementToAdd)
        {
            if (this.head == default(Node))
            {
                this.head = new Node(elementToAdd);

                this.tail = head;
            }
            else
            {
                Node toAdd = new Node(elementToAdd, this.tail);

                this.tail.Next = toAdd;

                this.tail = toAdd;
            }

            this.count++;
        }

        public TType Dequeue()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException();
            }

            TType toReturn = this.head.Value;

            if (this.count == 1)
            {
                this.head = default(Node);
                this.tail = default(Node);
            }
            else
            {
                this.head = this.head.Next;
                this.head.Previous = default(Node);
            }

            this.count--;

            return toReturn;
        }

        public TType[] ToArray()
        {
            TType[] arrayToReturn = new TType[this.count];

            Node currentNode = this.head;
            for (int currentElement = 0; currentElement < this.count && currentNode != default(Node); currentElement++)
            {
                arrayToReturn[currentElement] = currentNode.Value;

                currentNode = currentNode.Next;
            }

            return arrayToReturn;
        }
    }
}
