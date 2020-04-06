using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    /// <summary>
    /// Class is used to add and find if number is in the tree
    /// </summary>
    public class BinarySearchTree
    {
        // Root property
        public Node Root { get; set; }

        // Two constructors depending on if the value is given from get go
        public BinarySearchTree()
        {
            this.Root = null;
        }
        public BinarySearchTree(int value)
        {
            this.Root = new Node(value);
        }

        /// <summary>
        /// Add Node to the tree using the method
        /// </summary>
        /// <param name="node">This is where root is being taken</param>
        /// <param name="value">Inserted value</param>
        /// <returns></returns>
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

        /// <summary>
        /// Check to see if the tree contains value that we are searching for
        /// </summary>
        /// <param name="root"> the root node of the tree</param>
        /// <param name="value">search value</param>
        /// <returns>returns true/false depending on the presence of search value in the tree</returns>
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
