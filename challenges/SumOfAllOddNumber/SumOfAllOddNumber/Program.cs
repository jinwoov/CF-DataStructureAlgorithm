using SumOfAllOddNumber.Classes;
using System;
using System.Collections.Generic;

namespace SumOfAllOddNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree(6);

            bst.Add(bst.Root, 3);
            bst.Add(bst.Root, 1);
            bst.Add(bst.Root, 4);
            bst.Add(bst.Root, 101);
            int result = SumOfOddNumber(bst);

            bt.Root = bst.Root;

            List<int> resultList = BinaryTree.BreathFirst(bt);

            Console.WriteLine("This is whats in the list");
            foreach (var numbe in resultList)
            {
                Console.Write($"{numbe} => ");
            }
            Console.Write("END");
            Console.WriteLine();

            Console.WriteLine("This is the expected sum: ");
            Console.WriteLine(result);
        }

        /// <summary>
        /// This is where the odd number is being added
        /// </summary>
        /// <param name="tree">tree that is passed to check for its odd number and sum it up</param>
        /// <returns>Sum total</returns>
        public static int SumOfOddNumber(BinarySearchTree tree)
        {
            Queue queue = new Queue();
            int result = 0;


            queue.Enqueue(tree.Root);

            while (!queue.IsEmpty())
            {
                Node front = queue.Dequeue();

                if (front.Value % 2 != 0)
                {
                    result += front.Value;
                }

                if (front.Left != null) { queue.Enqueue(front.Left); }
                if (front.Right != null) { queue.Enqueue(front.Right); }
            }

            return result;
        }
    }
}
