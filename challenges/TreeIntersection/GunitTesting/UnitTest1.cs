using BreadthFirst.Classes;
using System;
using TreeIntersection;
using Xunit;

namespace GunitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TesingMethodToShowDuplicates()
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
            bstTwo.Add(btTwo.Root, 2);
            bstTwo.Add(btTwo.Root, 4);
            bstTwo.Add(btTwo.Root, 9);

            int[] result = Program.TreeIntersection(bt, btTwo);
            int[] expected = { 5, 2 };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ChangingThePositionOfNodeIntheTreeWillReturnDifferntAnswer()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 2);
            bst.Add(bt.Root, 6);
            bst.Add(bt.Root, 7);

            BinaryTree btTwo = new BinaryTree(5);
            BinarySearchTree bstTwo = new BinarySearchTree();
            bstTwo.Add(btTwo.Root, 2);
            bstTwo.Add(btTwo.Root, 4);
            bstTwo.Add(btTwo.Root, 4);
            bstTwo.Add(btTwo.Root, 9);

            int[] result = Program.TreeIntersection(bt, btTwo);
            int[] expected = { 5, 2 };

            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void EdgeCaseOfHavingNoDuplicateNumber()
        {
            BinaryTree bt = new BinaryTree(5);
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(bt.Root, 1);
            bst.Add(bt.Root, 2);
            bst.Add(bt.Root, 3);
            bst.Add(bt.Root, 4);

            BinaryTree btTwo = new BinaryTree(15);
            BinarySearchTree bstTwo = new BinarySearchTree();
            bstTwo.Add(btTwo.Root, 12);
            bstTwo.Add(btTwo.Root, 14);
            bstTwo.Add(btTwo.Root, 14);
            bstTwo.Add(btTwo.Root, 19);

            int[] result = Program.TreeIntersection(bt, btTwo);


            Assert.Empty(result);
        }
    }
}
