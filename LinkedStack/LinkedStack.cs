namespace LinkedStack
{
    using System;
    
    public class LinkedStack<TType>
    {
        private class Node
        {
            private TType value;
            private Node nextNode;

            public Node(TType value, Node nextNode = null)
            {
                this.value = value;
                this.nextNode = nextNode;
            }

            public TType Value
            {
                get { return this.value; }
                set { this.value = value; }
            }

            public Node Next
            {
                get { return this.nextNode; }
                set { this.nextNode = value; }
            }
        }

        private Node head;
        private int count;

        public LinkedStack()
        {
            this.head = default(Node);
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Push(TType elementToAdd)
        {
            if (this.head == default(Node))
            {
                this.head = new Node(elementToAdd);
            }
            else
            {
                Node toAdd = new Node(elementToAdd, this.head);

                this.head = toAdd;
            }

            this.count++;
        }

        public TType Pop()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException();
            }

            TType elementToReturn = this.head.Value;

            this.head = this.head.Next;

            this.count--;

            return elementToReturn;
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
