using FizzBuzzTree.Classes;
using FizzBuzzTree;
using System;
using Xunit;

namespace GUnitFiftyCents
{
    public class UnitTest1
    {
        [Fact]
        public void TestingToSeeIfTreeOutputsCorrectFizz()
        {
            BinarySearchTree bst = new BinarySearchTree(5);
            BinarySearchTree bts = Program.FizzBuzzTree(bst);

            Assert.Equal("Buzz", bts.Root.StringValue);
        }

        [Fact]
        public void TestingToSeeIfAddedThreeIsShowingFizz()
        {
            BinarySearchTree bst = new BinarySearchTree(5);
            bst.Add(bst.Root, 3);
            BinarySearchTree bts = Program.FizzBuzzTree(bst);

            string result = bts.Root.Left.StringValue;

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ExpectedFail()
        {
            BinarySearchTree bst = new BinarySearchTree(5);
            bst.Add(bst.Root, 5);
            BinarySearchTree bts = Program.FizzBuzzTree(bst);

            string result = bts.Root.Right.StringValue;

            Assert.NotEqual("FizzBuzz", result);
        }
    }
}
