using System;
using Tree.Classes;
using Xunit;

namespace GunitProject
{
    public class UnitTest1
    {
        [Fact]
        public void TeseIfCanInstantiateTree()
        {
            BinarySearchTree tree = new BinarySearchTree();

            Assert.IsType<BinarySearchTree>(tree);
        }

        [Fact]
        public void CanInstantiateATreeWithSingleNode()
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.Root = new Node(4);

            Assert.IsType<Node>(tree.Root);
        }

        [Fact]
        public void CanAddToLeft()
        {
            BinarySearchTree tree = new BinarySearchTree(5);

            tree.Add(tree.Root, 1);

            Assert.Equal(1, tree.Root.Left.Value);
        }

        [Fact]
        public void CanAddToRight()
        {
            BinarySearchTree tree = new BinarySearchTree(5);

            tree.Add(tree.Root, 10);

            Assert.Equal(10, tree.Root.Right.Value);
        }

        [Fact]
        public void CanTraversePreOrder()
        {
            BinarySearchTree tree = new BinarySearchTree(5);

            tree.Add(tree.Root, 1);
            tree.Add(tree.Root, 10);

            BinaryTree trees = new BinaryTree();

            int[] result = trees.PreOrder(tree.Root);

            int[] expectResult = { 5, 1, 10 };

            Assert.Equal(expectResult, result);
        }
        
        [Fact]
        public void CanTraverseInOrder()
        {
            BinarySearchTree tree = new BinarySearchTree(5);

            tree.Add(tree.Root, 1);
            tree.Add(tree.Root, 10);

            BinaryTree trees = new BinaryTree();

            int[] result = trees.InOrder(tree.Root);

            int[] expectResult = { 1, 5, 10 };

            Assert.Equal(expectResult, result);
        }

        [Fact]
        public void CanTraversePostOrder()
        {
            BinarySearchTree tree = new BinarySearchTree(5);
            tree.Add(tree.Root, 1);
            tree.Add(tree.Root, 10);

            BinaryTree trees = new BinaryTree();

            int[] result = trees.PostOrder(tree.Root);

            int[] expectResult = { 1, 10, 5 };

            Assert.Equal(expectResult, result);
        }
    }
}
