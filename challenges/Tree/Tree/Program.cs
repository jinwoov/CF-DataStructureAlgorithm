using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("This is to check the PreOrder method");
            foreach (var item in result)
            {
                Console.Write($"{item} -> ");
            }
            Console.Write("End");
            Console.WriteLine();

            BinaryTree checkTree1 = new BinaryTree();

            result = checkTree1.InOrder(tree.Root);
            Console.WriteLine("This is to check the InOrder method");
            foreach (var item in result)
            {
                Console.Write($"{item} -> ");
            }
            Console.Write("End");

            Console.WriteLine();

            BinaryTree checkTree2 = new BinaryTree();


            result = checkTree2.PostOrder(tree.Root);
            Console.WriteLine("This is to check the PostOrder method");
            foreach (var item in result)
            {
                Console.Write($"{item} -> ");
            }
            Console.Write("End");

            Console.WriteLine();
            bool answer = tree.Contains(tree.Root, 4);

            Console.WriteLine($"Checking to see 4 exsits in the tree. Expected answer is True: {answer}");
        }
    }

  
}
