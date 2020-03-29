using StacksAndQueues.Classes;
using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Stack-------");
            StackImplementation();
            Console.WriteLine("-------Queue-------");
            QueueImplementation();
        }

        /// <summary>
        /// Applying methods in Queue class
        /// </summary>
        static void QueueImplementation()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);

            int resultOfDequeue = queue.Dequeue();
            Console.WriteLine($"This is result from queue from dequeuing, expected output is 1: {resultOfDequeue}");

            bool resultBool = queue.IsEmpty();
            Console.WriteLine($"This is to check if the queue is empty, expected output is true: {resultBool}");

            queue.Enqueue(1);

            int resultQueueValue = queue.Peek();
            Console.WriteLine("This is the top node value, expected output is 1:{0}", resultQueueValue);
        }

        /// <summary>
        /// Applying methods in stack class
        /// </summary>
        static void StackImplementation()
        {
            Stack stack = new Stack();

            stack.Push(401);

            int resultPeek = stack.Peek();
            Console.WriteLine($"This is after adding number to the stack and peeking to see if number persists, expected output is 401: {resultPeek}");

            int resultPop = stack.Pop();
            Console.WriteLine($"This is after the top node is popped, expected output is 401: {resultPop}");

            bool resultEmpty = stack.IsEmpty();
            Console.WriteLine($"Is this stack empty or not, expected output is True: {resultEmpty}");
        }

    }
}
