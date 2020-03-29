using StacksAndQueues.Classes;
using System;
using Xunit;

namespace GUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOntoStack()
        {
            Stack stack = new Stack();

            stack.Push(5);

            bool result = stack.IsEmpty();

            Assert.False(result);
        }

        [Fact]
        public void CanPushMultipleValueOntoStack()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            int result = stack.Peek();

            Assert.Equal(5, result);
        }

        [Fact]
        public void CanPopOffFromStack()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            int result = stack.Pop();

            Assert.Equal(5, result);
        }

        [Fact]
        public void EmptyStackAfterPopPop()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);

            stack.Pop();
            stack.Pop();

            Exception error = Record.Exception(() => stack.Peek());

            Assert.IsType<IndexOutOfRangeException>(error);
        }

        [Fact]
        public void PeekTheNextItemOnTheList()
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            int result = stack.Peek();

            Assert.Equal(1, result);
        }

        [Fact]
        public void AbleToInstantiateEmptyStack()
        {
            Stack stack = new Stack();

            bool result = stack.IsEmpty();

            Assert.True(result);
        }

        [Fact]
        public void CallingEmptyStackCauseError()
        {
            Stack stack = new Stack();

            Exception err = Record.Exception(() => stack.Peek());

            Assert.IsType<IndexOutOfRangeException>(err);
        }

        [Fact]
        public void QueueIntoEnqueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(5);

            bool result = queue.IsEmpty();

            Assert.False(result);
        }

        [Fact]
        public void QueueMultipleEnqueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);

            int result = queue.Peek();

            Assert.Equal(5, result);
        }

        [Fact]
        public void DequeueOutOfQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(5);

            int result = queue.Dequeue();

            Assert.Equal(5, result);
        }

        [Fact]
        public void PeekIntoQueue()
        {
            Queue queue = new Queue();

            queue.Enqueue(5);

            int result = queue.Peek();

            Assert.Equal(5, result);
        }

        [Fact]
        public void EmptyTheQueueAfterMultipleDequeue()
        {
            Queue queue = new Queue();

            queue.Enqueue(5);
            queue.Enqueue(4);
            queue.Enqueue(3);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            bool result = queue.IsEmpty();

            Assert.True(result);
        }

        [Fact]
        public void CanInstantiateAnEmptyQueue()
        {
            Queue queue = new Queue();

            bool result = queue.IsEmpty();

            Assert.True(result);
        }

        [Fact] //
        public void DequeueEmptyQueueThrowsError()
        {
            Queue queue = new Queue();

            Exception err = Record.Exception(() => queue.Dequeue());

            Assert.IsType<IndexOutOfRangeException>(err);
        } 
    }
}
