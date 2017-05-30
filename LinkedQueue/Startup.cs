namespace LinkedQueue
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            LinkedQueue<int> test = new LinkedQueue<int>();

            test.Enqueue(1);
            test.Enqueue(2);
            test.Enqueue(3);
            test.Enqueue(4);
            test.Enqueue(5);
            test.Enqueue(5);
            test.Enqueue(5);

            Console.WriteLine(string.Join(", ", test.ToArray()));

            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            test.Dequeue();
            Console.WriteLine(string.Join(", ", test.ToArray()));

        }
    }
}
