using StacksAndQueues.Classes;
using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {

            QueueImplementation();
        }

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

    }
}
