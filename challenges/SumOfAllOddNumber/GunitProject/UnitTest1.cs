using SumOfAllOddNumber.Classes;
using SumOfAllOddNumber;
using System;
using Xunit;

namespace GunitProject
{
    public class UnitTest1
    {
        [Fact]
        public void HappyTrailToPassing()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree(6);

            bst.Add(bst.Root, 3);
            bst.Add(bst.Root, 1);
            bst.Add(bst.Root, 4);
            bst.Add(bst.Root, 101);


            int result = Program.SumOfOddNumber(bst);

            Assert.Equal(105, result);
        }

        [Fact]
        public void ExpectToFail()
        {
            BinaryTree bt = new BinaryTree();
            BinarySearchTree bst = new BinarySearchTree(6);

            bst.Add(bst.Root, 4);
            bst.Add(bst.Root, 1);
            bst.Add(bst.Root, 4);
            bst.Add(bst.Root, 101);


            int result = Program.SumOfOddNumber(bst);

            Assert.NotEqual(100, result);
        }
    }
}
