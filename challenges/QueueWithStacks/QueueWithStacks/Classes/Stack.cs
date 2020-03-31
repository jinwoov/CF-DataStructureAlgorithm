using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; } = null;

        /// <summary>
        /// Creating the new top node and moving the old top node to the bottom
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node oldTop = Top;
            Top = new Node(value);
            Top.Next = oldTop;
        }

        /// <summary>
        /// Getting the top node off from the stack
        /// </summary>
        /// <returns>value of node that has been popped</returns>
        public int Pop()
        {
            if (Top == null)
                throw new IndexOutOfRangeException("Index is out of range");

            Node Current = Top;

            Top = Top.Next;

            return Current.Value;
        }

        /// <summary>
        /// Peek to see if the top is there, if the stack doesn't have any node it will throw error.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (Top == null)
                throw new IndexOutOfRangeException("Index is out of range");

            return Top.Value;
        }

        /// <summary>
        /// Method that checks if the stack is empty.
        /// </summary>
        /// <returns>Returns true when the stack is empty, otherwise it wil return false</returns>
        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
