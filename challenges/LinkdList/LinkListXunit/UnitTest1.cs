using System;
using Xunit;
using LinkdList.Classes;

namespace LinkListXunit
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessfullyInstantiateEmptyLinkList()
        {
            Linklist linkList = new Linklist();
            Assert.Null(linkList.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);

            Assert.Equal(3, ll.Head.Data);
        }

        [Fact]
        public void HeadPropertyPointingToFirstNode()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            Assert.Equal(2, ll.Head.Data);
        }

        [Fact]
        public void CanInsertMultipleNodeIntoLinkedList()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            bool doesItHave = ll.Includes(4);

            Assert.True(doesItHave);
        }
    }
}
