using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
    {
        public Node Top { get; set; } = null;

        public void Push(int value)
        {
            Node OldTop = Top;
            Top = new Node(value);
            Top.Next = OldTop;
        }

        public 
    }
}
