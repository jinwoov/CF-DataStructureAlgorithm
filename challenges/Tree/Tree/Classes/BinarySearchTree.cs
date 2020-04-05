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

        //public override bool Contains(int value)
        //{
        //    if (this.Root == null)
        //    {
        //        return false;
        //    }


        //    while(Root != null)
        //    {
        //        if(Root.Value == value)
        //        {
        //            return true;
        //        }

        //        Root = Root.Left;
        //        Root = Root.
        //    }

        //}
    }
}
