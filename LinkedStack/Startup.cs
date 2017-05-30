namespace LinkedStack
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            LinkedStack<int> stack = new LinkedStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.WriteLine("array = " + string.Join(", ", stack.ToArray()));
        }
    }
}
