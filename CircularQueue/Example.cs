using System;

public class Example
{
    public static void Main()
    {
        CircularQueue<int> test = new CircularQueue<int>();

        test.Enqueue(1);
        test.Enqueue(2);
        test.Enqueue(3);
        test.Enqueue(4);
        test.Enqueue(5);
        test.Enqueue(6);
        test.Enqueue(7);
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        Console.WriteLine(string.Join(", ", test.ToArray()));
        test.Dequeue();

        Console.WriteLine(string.Join(", ", test.ToArray()));

        test.Enqueue(1);
        test.Enqueue(2);
        test.Enqueue(3);
        test.Enqueue(4);
        test.Enqueue(5);
        test.Enqueue(6);
        test.Enqueue(7);
        Console.WriteLine(string.Join(", ", test.ToArray()));
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();

        Console.WriteLine(string.Join(", ", test.ToArray()));


        test.Enqueue(1);
        test.Enqueue(2);
        test.Enqueue(3);
        test.Enqueue(4);
        test.Enqueue(5);
        test.Enqueue(6);
        test.Enqueue(7);
        Console.WriteLine(string.Join(", ", test.ToArray()));
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        Console.WriteLine(string.Join(", ", test.ToArray()));
        test.Dequeue();

        Console.WriteLine(string.Join(", ", test.ToArray()));

        test.Enqueue(1);
        test.Enqueue(2);
        test.Enqueue(3);
        test.Enqueue(4);
        test.Enqueue(5);
        test.Enqueue(6);
        test.Enqueue(7);
        Console.WriteLine(string.Join(", ", test.ToArray()));
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();
        test.Dequeue();

        Console.WriteLine(string.Join(", ", test.ToArray()));
    }
}
