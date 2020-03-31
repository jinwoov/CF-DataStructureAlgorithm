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
            if (PseudoQ != null)
            { 
                while (PseudoQ.Top != null)
                {
                    PseudoQTwo.Push(PseudoQ.Pop());
                }
            }

            PseudoQ.Push(value);

            if(PseudoQTwo != null)
            {
                while(PseudoQTwo.Top != null)
                {
                    PseudoQ.Push(PseudoQTwo.Pop());
                }
            }
        }

    }
}
