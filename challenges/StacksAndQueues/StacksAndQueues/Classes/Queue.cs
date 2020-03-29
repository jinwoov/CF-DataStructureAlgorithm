using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; } = null;
        public Node Rear { get; set; } = null;

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

        public bool IsEmpty()
        {
            return Front == null;
        }

        public int Peek()
        {
            if (Front == null)
                throw new IndexOutOfRangeException("Index is out of range");
            
            else
            {
                return Front.Value;
            }
        }

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
