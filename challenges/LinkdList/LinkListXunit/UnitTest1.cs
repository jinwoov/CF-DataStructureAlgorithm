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
        public void CanInsertMultipleNodeIntoLinkList()
        {
            Linklist ll = new Linklist();
            ll.Insert(4);
            ll.Insert(2);

            Node node = ll.Head.Next;


            Assert.Equal(4, node.Data);
        }

        [Fact]
        public void CanFindExistingNode()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            bool doesItHave = ll.Includes(4);

            Assert.True(doesItHave);
        }
        
        [Fact]
        public void CannnotFindNodeWhenNodeDoesntExist()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            bool doesItHave = ll.Includes(10);

            Assert.False(doesItHave);
        }

        [Fact]
        public void CanReturnAllofTheLinkList()
        {
            Linklist ll = new Linklist();

            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.ToString();
            string answer = "2 -> 4 -> 5 -> 3 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void AddingLinkListToEnd()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.Append(12);

            ll.ToString();
        }
    }
}
