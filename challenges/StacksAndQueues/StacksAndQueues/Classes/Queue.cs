using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; } = null;
        public Node Rear { get; set; } = null;

        /// <summary>
        /// Adding the Node to the back of the line if the front exists.
        /// </summary>
        /// <param name="value">value that will be attach to the inserted node</param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);

            if (Rear == null)
            {
                Rear = node;
                Front = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        /// <summary>
        /// Checking if the queue is empty
        /// </summary>
        /// <returns>Depending on presence of queue, it will return true or false</returns>
        public bool IsEmpty()
        {
            return Front == null;
        }

        /// <summary>
        /// Peek to output first node value if its present, otherwise it will throw an error
        /// </summary>
        /// <returns>value of the front node</returns>
        public int Peek()
        {
            if (Front == null)
                throw new IndexOutOfRangeException("Index is out of range");
            
            else
            {
                return Front.Value;
            }
        }

        /// <summary>
        /// To delete the queue from the front node and assign the value to the next node in the front
        /// </summary>
        /// <returns>return interger that has been dequeued</returns>
        public int Dequeue()
        {
            if (Front == null)
                throw new IndexOutOfRangeException("Index is out of range");

            Node temp = Front;

            Front = Front.Next;

            temp.Next = null;

            return temp.Value;
        }
    }
}
