using BreadthFirst.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestingToSeeIfTheBinaryTreeCanOutputExpectedList()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 2);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 7);

            List<int> result = BinaryTree.BreathFirst(bt);
            List<int> expect = new List<int> { 5, 1, 6, 2, 7 };

            Assert.Equal(expect, result);
        }

        [Fact]
        public void ExpectToFailCompareWithPreOrderOutPut()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 2);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 7);

            int[] result = BinaryTree.BreathFirst(bt).ToArray();
            int[] expect = bt.PreOrder(bt.Root);

            Assert.NotEqual(expect, result);
        }


    }
}
