using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree()
        {
            this.Root = null;
        }
        public BinarySearchTree(int value)
        {
            this.Root = new Node(value);
        }

        public Node Add(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
            }
            else if (value < node.Value)
            {
                node.Left = Add(node.Left, value);
            }
            else
            {
                node.Right = Add(node.Right, value);
            }

           Root = node;
           return Root;
        }

        public bool Contains(Node root, int value)
        {
            if (root == null)
                return false;
            if (root.Value == value)
                return true;

            if (root.Value > value)
                Contains(root.Left, value);

            return Contains(root.Right, value);

        }
    }
}
