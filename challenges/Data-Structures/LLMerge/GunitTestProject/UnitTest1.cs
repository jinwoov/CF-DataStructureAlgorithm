using LLMerge.Classes;
using System;
using Xunit;

namespace GunitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestForHappyTrail()
        {
            // creating first link list of nodes
            Linklist ll = new Linklist();
            ll.Append(1);
            ll.Append(2);
            ll.Append(3);
            ll.Append(4);


            Console.WriteLine($"This is first link list created: {ll.ToString()}");

            // Creating second link list of nodes
            Linklist llTwo = new Linklist();
            llTwo.Append(101);
            llTwo.Append(102);
            llTwo.Append(103);
            llTwo.Append(104);


            Linklist result = LLMerged.MergeLists(ll, llTwo);

            Assert.Equal("1 -> 101 -> 2 -> 102 -> 3 -> 103 -> 4 -> 104 -> NULL", result.ToString());
        }

        [Fact]
        public void WouldFailThisTestBecauseThereIsNothingToInFirstLinkList()
        {
            Linklist ll = new Linklist();

            Linklist llTwo = new Linklist();
            llTwo.Append(101);
            llTwo.Append(102);

            Exception error = Record.Exception(() => LLMerged.MergeLists(ll, llTwo));


            Assert.IsType<NullReferenceException>(error);
        }


    }
}
