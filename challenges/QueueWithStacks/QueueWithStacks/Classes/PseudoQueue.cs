using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack PseudoQ { get; set; }
        public Stack PseudoQTwo { get; set; }

        public PseudoQueue()
        {
            this.PseudoQ = new Stack();
            this.PseudoQTwo = new Stack();
        }

        public void Enqueue(int value)
        {
                while (PseudoQ.Top != null)
                {
                    PseudoQTwo.Push(PseudoQ.Pop());
                }

            PseudoQ.Push(value);

                while(PseudoQTwo.Top != null)
                {
                    PseudoQ.Push(PseudoQTwo.Pop());
                }
        }

        public int Dequeue()
        {
            if (PseudoQ == null) 
            {
                throw new IndexOutOfRangeException("Your queue is empty");
            }


            return PseudoQ.Pop();

        }
    }
}
