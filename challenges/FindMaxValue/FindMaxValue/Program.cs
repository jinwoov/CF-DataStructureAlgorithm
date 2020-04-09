using FindMaxValue.Classes;
using System;
using System.Collections.Generic;

namespace FindMaxValue
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingTree();
        }

        /// <summary>
        /// To test our MaxValue method
        /// </summary>
        static void TestingTree()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 2000);
            bst.Add(bt.Root, 7);
            bst.Add(bt.Root, 3);
            bst.Add(bt.Root, 8);

            int result = BinaryTree.FindMaxValue(bt);

            List<int> resultList = BinaryTree.BreathFirst(bt);

            Console.WriteLine("This is what's in the tree");
            foreach (var num in resultList)
            {
                Console.Write($"{num} => ");
            }
            Console.Write("END");

            Console.WriteLine();
            Console.WriteLine("The maximum value is: {0}", result);


        }
    }
}
