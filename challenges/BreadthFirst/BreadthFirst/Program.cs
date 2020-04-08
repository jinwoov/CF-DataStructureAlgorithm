using BreadthFirst.Classes;
using System;
using System.Collections.Generic;

namespace BreadthFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingMethod();
        }

        static void TestingMethod()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 2);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 7);

            List<int> list = BinaryTree.BreathFirst(bt);

            foreach (var item in list)
            {
                Console.Write($"{item} => ");
            }
            Console.Write("END");

        }
    }
}
