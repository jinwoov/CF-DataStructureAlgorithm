using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; } = null;

        public void Push(int value)
        {
            Node OldTop = Top;
            Top = new Node(value);
            Top.Next = OldTop;
        }

        public int Pop()
        {
            if (Top == null)
                throw new IndexOutOfRangeException("Index is out of range");

            Node Current = Top;

            Top = Top.Next;

            return Current.Value;
        }

        public int Peek()
        {
            if (Top == null)
                throw new IndexOutOfRangeException("Index is out of range");

            return Top.Value;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
