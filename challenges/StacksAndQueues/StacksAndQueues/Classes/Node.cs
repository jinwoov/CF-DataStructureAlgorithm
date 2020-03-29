using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        /// <summary>
        /// Constructor to crate a node 
        /// </summary>
        /// <param name="value">assigns the value of the node when its instaniated</param>
        public Node(int value)
        {
            this.Value = value;
            Node Next = null;
        }
    }
}
