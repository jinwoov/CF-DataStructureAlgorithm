using System;
using Tree.Classes;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TestingAllofTheMethod();
        }

        /// <summary>
        /// Testing all the methods from the classes
        /// </summary>
        static void TestingAllofTheMethod()
        {
            // Creating an objeect of BinarySearchTree to add node to the tree accordingly
            BinarySearchTree tree = new BinarySearchTree(3);
            tree.Add(tree.Root, 4);
            tree.Add(tree.Root, 1);
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 12);
            tree.Add(tree.Root, 14);

            // BinaryTree class objects
            BinaryTree checkTree = new BinaryTree();
            BinaryTree checkTree1 = new BinaryTree();
            BinaryTree checkTree2 = new BinaryTree();

            // variables that will be used later
            bool answer = tree.Contains(tree.Root, 4);
            int[] result = checkTree.PreOrder(tree.Root);

            // Priting out all of the node that is present in tree using PreOrderMethod
            Console.WriteLine("This is to check the PreOrder method");
            foreach (var item in result)
            {
                Console.Write($"{item} -> ");
            }
            Console.Write("End");
            Console.WriteLine();

            // Priting out all of the node that is present in tree using InOrderMethod
            result = checkTree1.InOrder(tree.Root);
            Console.WriteLine("This is to check the InOrder method");
            foreach (var item in result)
            {
                Console.Write($"{item} -> ");
            }
            Console.Write("End");

            Console.WriteLine();


            // Priting out all of the node that is present in tree using PostOrderMethod
            result = checkTree2.PostOrder(tree.Root);
            Console.WriteLine("This is to check the PostOrder method");
            foreach (var item in result)
            {
                Console.Write($"{item} -> ");
            }
            Console.Write("End");

            Console.WriteLine();

            // Testing contain method from BinarySearchTree class
            Console.WriteLine($"Checking to see 4 exsits in the tree. Expected answer is True: {answer}");
        }
    }

  
}
