using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public BinarySearchTree Tree { get; set; }

        public List<int> InTree = new List<int>();

        public int[] PreOrder(Node node)
        {

            if (node == null)
            {
                return InTree.ToArray();
            }

            InTree.Add(node.Value);

            PreOrder(node.Left);
            PreOrder(node.Right);
            return InTree.ToArray();
        }

        //public int Traversal(Node node)
        //{
        //    if (node.Left == null && node.Right == null)
        //        return node.Value
        //}
    }
}
