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
    }
}
