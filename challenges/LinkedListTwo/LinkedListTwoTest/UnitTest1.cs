using System;
using Xunit;
using LinkedListTwo;
using LinkedListTwo.Classes;

namespace LinkedListTwoTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestingNodeIfItInsert()
        {
            Node node = new Node();
            node.Value = 12;

            Assert.Equal(12, node.Value);
        }

        public void CanAddNodeandHeadGetsAdded()
        {
            LinkList ll = new LinkList();
            
        }
    }
}
