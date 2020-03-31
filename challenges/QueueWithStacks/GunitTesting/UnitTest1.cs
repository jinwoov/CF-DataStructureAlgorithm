using QueueWithStacks.Classes;
using System;
using Xunit;

namespace GunitTesting
{
    public class UnitTest1
    {
        [Fact]
        public void TestingToseeIFEnqueueCanAdd()
        {
            PseudoQueue psuedo = new PseudoQueue();

            psuedo.Enqueue(4);

            int result = psuedo.PseudoQ.Peek();

            Assert.Equal(4, result);
        }

        [Fact]
        public void CanEnqueueMutipleThings()
        {
            PseudoQueue psuedo = new PseudoQueue();

            psuedo.Enqueue(4);
            psuedo.Enqueue(5);
            psuedo.Enqueue(3);
            psuedo.Enqueue(2);


            int result = psuedo.PseudoQ.Peek();

            Assert.Equal(4, result);
        }
    }
}
