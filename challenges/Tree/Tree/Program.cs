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
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 12);
            tree.Add(tree.Root, 14);


            BinaryTree checkTree = new BinaryTree();

            int[] result = checkTree.PreOrder(tree.Root);

            foreach (var item in result)
            {
                Console.Write($"{item} -> ");
            }
            Console.Write("End");

            Console.WriteLine();
            bool boore = tree.Contains(tree.Root, 10);

            Console.WriteLine($"this is the answer {boore}");
        }
    }

  
}
