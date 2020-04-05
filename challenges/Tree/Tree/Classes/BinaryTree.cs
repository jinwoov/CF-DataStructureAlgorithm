using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {

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
        public int[] InOrder(Node node)
        {

            if (node == null)
            {
                return InTree.ToArray();
            }

            InOrder(node.Left);

            InTree.Add(node.Value);

            InOrder(node.Right);

            return InTree.ToArray();
        }

        public int[] PostOrder(Node node)
        {

            if (node == null)
            {
                return InTree.ToArray();
            }

            PostOrder(node.Left);

            PostOrder(node.Right);

            InTree.Add(node.Value);

            return InTree.ToArray();
        }

    }
}
