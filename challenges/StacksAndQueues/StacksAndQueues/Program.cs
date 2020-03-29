using StacksAndQueues.Classes;
using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            QueueImplementation();
        }

        static void QueueImplementation()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);

            int resultOfDequeue = queue.Dequeue();
            Console.WriteLine($"This is result from queue from dequeuing, expected output is 1: {resultOfDequeue}");

            
        }

    }
}
