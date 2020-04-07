using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree.Classes
{
    public class BinaryTree
    {
        // List property that will be used to store all of the tree value and will be changed to array once everything is added
        public List<int> InTree = new List<int>();
        public List<string> InTree2 = new List<string>();


        /// <summary>
        /// Adding value to the list first then goes to the left then add again cycle continues until left is no longer available then pops off from the stack and moves to the right. NLR pattern
        /// </summary>
        /// <param name="node">root node of the tree</param>
        /// <returns>Integer array</returns>
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

        public string[] StringOrder(Node node)
        {
            if (node == null)
            {
                return InTree2.ToArray();
            }

            InTree2.Add(node.StringValue);

            StringOrder(node.Left);
            StringOrder(node.Right);
            return InTree2.ToArray();
        }

        /// <summary>
        /// Moves to the fartheset left first then adds to the list then pops off from the stack then adds to the list then moves to the right. This cycle continues. LNR pattern
        /// </summary>
        /// <param name="node">root of the tree</param>
        /// <returns>Integer array which has everything in the tree</returns>
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

        /// <summary>
        /// Moves to the farthest left then adds to the list, then moves back one and moves to the right if there is node present, then adds to the list. This cycle continues until everything is added to the list. LRN pattern
        /// </summary>
        /// <param name="node">Root of the node</param>
        /// <returns>Integer array of all the values of the tree</returns>
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
