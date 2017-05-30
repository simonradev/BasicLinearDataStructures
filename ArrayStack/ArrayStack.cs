namespace ArrayStack
{
    using System;
    
    public class ArrayStack<TType>
    {
        private const int InitialCapacity = 16;
        
        private TType[] allElements;

        private int currentCapacity;

        private int count;
        private int currentIndex;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.currentCapacity = capacity;

            this.allElements = new TType[capacity];

            this.count = 0;
            this.currentIndex = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public void Push(TType elementToAdd)
        {
            if (this.count == this.currentCapacity)
            {
                this.DoubleTheSize();
            }

            this.allElements[currentIndex] = elementToAdd;

            this.IncrementDynamicValues();
        }

        public TType Pop()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException();
            }

            TType elementToReturn = this.allElements[this.currentIndex - 1];

            this.IncrementDynamicValues(-1);

            if (this.count <= this.currentCapacity / 4)
            {
                this.ShrinkSize();
            }

            return elementToReturn;
        }

        private void ShrinkSize()
        {
            this.currentCapacity /= 2;

            this.CopyElementsToArray(this.count);
        }

        private void DoubleTheSize()
        {
            this.currentCapacity *= 2;

            this.CopyElementsToArray(this.allElements.Length);
        }

        private void CopyElementsToArray(int elementsToCopy)
        {
            TType[] arrayHolder = new TType[this.currentCapacity];

            for (int currentElement = 0; currentElement < elementsToCopy; currentElement++)
            {
                arrayHolder[currentElement] = this.allElements[currentElement];
            }

            this.allElements = arrayHolder;
        }

        private void IncrementDynamicValues(int incrementor = 1)
        {
            this.count += incrementor;
            this.currentIndex += incrementor;
        }
    }
}
