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

            string answer = "2 -> 4 -> 5 -> 3 -> 12 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void AddingMultipleLinkToEndOfTheList()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.Append(101);
            ll.Append(401);

            string answer = "2 -> 4 -> 5 -> 3 -> 101 -> 401 -> NULL";
            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void CanAddBeforeTheMiddleOfTheLinkList()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.InsertBefore(5, 10);
            string answer = "2 -> 4 -> 10 -> 5 -> 3 -> NULL";
            
            Assert.Equal(answer, ll.ToString());
        }


        [Fact]
        public void CanAddBeforeTheFirstNodeInTheLinkList()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.InsertBefore(2, 102);
            string answer = "102 -> 2 -> 4 -> 5 -> 3 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void CanAddAfterMiddleOftheLinkList()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.InsertAfter(4, 21);
            string answer = "2 -> 4 -> 21 -> 5 -> 3 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void CanAddAfterLastNode()
        {
            Linklist ll = new Linklist();
            ll.Insert(3);
            ll.Insert(5);
            ll.Insert(4);
            ll.Insert(2);

            ll.InsertAfter(3, 21);
            string answer = "2 -> 4 -> 5 -> 3 -> 21 -> NULL";

            Assert.Equal(answer, ll.ToString());
        }

        [Fact]
        public void KisGreaterThanLengthOfList()
        {
            Linklist ll = new Linklist();
            ll.Append(3);
            ll.Append(5);
            ll.Append(4);
            ll.Append(2);
            ll.Append(6);
            ll.Append(11);
            ll.Append(21);
            ll.Append(12);

            Exception error = Record.Exception(() => ll.kthFromEnd(20));

            Assert.IsType<Exception>(error);
        }

        [Fact]
        public void SameNumberOfKasLengthOfLL()
        {
            Linklist ll = new Linklist();
            ll.Append(3);
            ll.Append(5);
            ll.Append(4);
            ll.Append(2);
            ll.Append(6);
            ll.Append(11);
            ll.Append(21);
            ll.Append(12);

            Exception error = Record.Exception(() => ll.kthFromEnd(8));

            Assert.IsType<Exception>(error);
        }

        [Fact]
        public void KisNegativeValue()
        {
            Linklist ll = new Linklist();
            ll.Append(3);
            ll.Append(5);
            ll.Append(4);
            ll.Append(2);
            ll.Append(6);
            ll.Append(11);
            ll.Append(21);
            ll.Append(12);

            Exception error = Record.Exception(() => ll.kthFromEnd(-1));

            Assert.IsType<Exception>(error);
        }

        [Fact]
        public void LinkListSizeUno()
        {
            Linklist ll = new Linklist();
            ll.Append(69);

            var output = ll.kthFromEnd(0);

            Assert.Equal(69, output);
        }

        [Fact]
        public void KisInTheMiddleOfLinkListHappyTree()
        {
            Linklist ll = new Linklist();
            ll.Append(3);
            ll.Append(5);
            ll.Append(4);
            ll.Append(2);
            ll.Append(808);
            ll.Append(11);
            ll.Append(21);
            ll.Append(12);

            int output = ll.kthFromEnd(3);

            Assert.Equal(808, output);
        }

        [Fact]
        public void CheckingIfMiddleElementShowsWithThisMethod()
        {
            Linklist ll = new Linklist();
            ll.Append(3);
            ll.Append(5);
            ll.Append(4);
            ll.Append(808);
            ll.Append(2);
            ll.Append(11);
            ll.Append(21);

            int output = ll.kthFromMiddle();

            Assert.Equal(808, output);
        }

    }
}
