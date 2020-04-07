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
    }
}
