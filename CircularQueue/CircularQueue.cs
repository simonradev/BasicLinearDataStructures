using System;

public class CircularQueue<TType>
{
    private const int DefaultCapacity = 4;

    private int count;
    private int currentCapacity;

    private int startIndex;
    private int endIndex;

    private int currentIndex;

    private TType[] allElements;
    
    public int Count { get { return this.count; } }

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.count = 0;
        this.currentCapacity = capacity;

        this.startIndex = 0;
        this.endIndex = 1;

        this.currentIndex = 0; 

        this.allElements = new TType[capacity];
    }

    public void Enqueue(TType element)
    {
        if (this.startIndex == this.endIndex && this.count != 0)
        {
            this.Resize();
        }

        this.allElements[this.currentIndex] = element;

        this.currentIndex = this.CalculateIndex(this.currentIndex + 1);
        this.endIndex = this.currentIndex;

        this.count++;
    }

    public TType Dequeue()
    {
        if (this.count == 0)
        {
            throw new InvalidOperationException();
        }

        TType elementToReturn = this.allElements[this.startIndex];

        this.startIndex = this.CalculateIndex(this.startIndex + 1);
        this.count--;

        if (this.count <= this.currentCapacity / 4)
        {
            this.Shrink();
        }

        return elementToReturn;
    }

    private void Shrink()
    {
        this.currentCapacity /= 2;
        TType[] arrayHolder = new TType[this.currentCapacity];

        this.CopyTheOriginalElements(arrayHolder);

        this.allElements = arrayHolder;

        this.startIndex = 0;
        this.endIndex = this.count;
        this.currentIndex = this.count;
    }
    
    private void Resize()
    {
        this.currentCapacity *= 2;

        TType[] holderArray = new TType[this.currentCapacity];

        int indexForAllElementsArray = this.startIndex;
        for (int currentElement = 0; currentElement < this.allElements.Length; currentElement++)
        {
            holderArray[currentElement] = this.allElements[this.CalculateIndex(indexForAllElementsArray++)];
        }

        this.allElements = holderArray;

        this.startIndex = 0;
        this.endIndex = indexForAllElementsArray;
        this.currentIndex = indexForAllElementsArray;
    }

    private void CopyAllElements(TType[] newArray)
    {
        newArray = this.ToArray();
    }
    
    public TType[] ToArray()
    {
        TType[] arrayToReturn = new TType[this.count];

        this.CopyTheOriginalElements(arrayToReturn);

        return arrayToReturn;
    }

    private void CopyTheOriginalElements(TType[] arrayHolder)
    {
        int loopStartIndex = this.startIndex;
        int loopEndIndex = this.startIndex + this.count;

        for (int currentElement = loopStartIndex, arrHolderElement = 0; currentElement < loopEndIndex; currentElement++, arrHolderElement++)
        {
            arrayHolder[arrHolderElement] = this.allElements[this.CalculateIndex(currentElement)];
        }
    }

    private int CalculateIndex(int indexToCalculate)
    {
        return indexToCalculate % this.allElements.Length;
    }
}
