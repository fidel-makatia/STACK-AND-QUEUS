using System;

using System.Collections.Generic;

namespace STACK
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack

            Stack<int> myStack = new Stack<int>();

            myStack.Push(123);

            myStack.Push(345);
            myStack.Push(3425);

            int p = myStack.Pop();

            Console.WriteLine("********STACK************");
            Console.WriteLine(p);

            p = myStack.Peek();
            Console.WriteLine(p);
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }


            //Queue

            Console.WriteLine("********QUEUE************");

            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(3435);
            myQueue.Enqueue(2300);
            myQueue.Enqueue(565657);

            foreach(var item in myQueue)
            {
                Console.WriteLine(item);
            }

            int y = myQueue.Dequeue();

            Console.WriteLine(y);


            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
