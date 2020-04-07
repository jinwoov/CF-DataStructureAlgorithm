using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class Node
    {
        /// <summary>
        /// Each Node has value and points to left and right
        /// </summary>
        public int Value { get; set; }
        public string StringValue { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node()
        {

        }

        /// <summary>
        /// This constructor is used when a tree is instantiating a node with value.
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }



    }
}
