using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Clear();
            stack.Push(1);
            
            Console.WriteLine(stack.Pop());


        }
    }
}
