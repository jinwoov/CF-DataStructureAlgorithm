using FindMaxValue.Classes;
using System;
using Xunit;

namespace GunitProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestingToSeeIFTreeMaxNumberIsOutputted()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 420);
            bst.Add(bt.Root, 7);

            int blazeIt = BinaryTree.FindMaxValue(bt);

            Assert.Equal(420, blazeIt);
        }

        [Fact]
        public void ExpectNotEqual()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 7);

            int blazeIt = BinaryTree.FindMaxValue(bt);

            Assert.NotEqual(6, blazeIt);
        }

        [Fact]
        public void EdgeCaseIfIhaveDuplicateMaxNumber()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 6);

            int blazeIt = BinaryTree.FindMaxValue(bt);

            Assert.Equal(6, blazeIt);
        }
    }
}
