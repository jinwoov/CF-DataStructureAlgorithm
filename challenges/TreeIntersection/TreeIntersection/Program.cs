using BreadthFirst.Classes;
using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    /// <summary>
    /// Bringing dependency from tree code challenge
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 2);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 7);

            BinaryTree btTwo = new BinaryTree(5);
            BinarySearchTree bstTwo = new BinarySearchTree();
            bstTwo.Add(btTwo.Root, 4);
            bstTwo.Add(btTwo.Root, 3);
            bstTwo.Add(btTwo.Root, 7);
            bstTwo.Add(btTwo.Root, 4);
            bstTwo.Add(btTwo.Root, 7);

            int[] firstTree = bt.PreOrder(bt.Root);
            int[] secondTree = btTwo.PreOrder(btTwo.Root);

            Console.WriteLine($"This is the first tree: {String.Join(", ", firstTree)}");
            Console.WriteLine($"This is the second tree: {String.Join(", ", secondTree)}");

            int[] finalArray = TreeIntersection(bt, btTwo);

            Console.WriteLine($"This is duplicated number: {String.Join(", ", finalArray)}");
        }

        /// <summary>
        /// Running each for loop iteration to mark how many are matching then create a array size using the matching counter then loop again to assigned element at each position
        /// </summary>
        /// <param name="bt">First binary tree</param>
        /// <param name="btTwo">Second binary tree</param>
        /// <returns>int array that has matching number</returns>
        public static int[] TreeIntersection(BinaryTree bt, BinaryTree btTwo)
        {
            int[] first = bt.PreOrder(bt.Root);
            int[] second = btTwo.PreOrder(btTwo.Root);
            int k = 0;

            for (int i = 0; i < first.Length; i++)
            {
                if(first[i] == second[i])
                {
                    k++;
                }
            }

            int[] result = new int[k];

            k = 0;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    result[k++] = first[i];
                }
            }

            return result;

        }

    }
}
