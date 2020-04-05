using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Testting();
        }
        static void Testting()
        {
            BinarySearchTree tree = new BinarySearchTree(3);
            tree.Add(tree.Root, 4);
            tree.Add(tree.Root, 1);


            BinaryTree checkTree = new BinaryTree();

            checkTree.Tree = tree;

            int[] result = checkTree.PreOrder(tree.Root);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }

  
}
