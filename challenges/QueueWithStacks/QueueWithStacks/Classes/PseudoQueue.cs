using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        public Stack PseudoQ { get; set; }
        public Stack PseudoQTwo { get; set; }

        /// <summary>
        /// Constructor instantiate an object when PseudoQueue object is instantiated
        /// </summary>
        public PseudoQueue()
        {
            this.PseudoQ = new Stack();
            this.PseudoQTwo = new Stack();
        }

        /// <summary>
        /// Moving off all of the first stack object node to the second object then add it, then added back from second object
        /// </summary>
        /// <param name="value">Value that will be added to the new queue</param>
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

        /// <summary>
        /// This is to check if the object is empty first which will raise exception when it is, other wise it will pop the queue and return its value
        /// </summary>
        /// <returns>Popped value</returns>
        public int Dequeue()
        {
            return PseudoQ.Pop();
        }
    }
}
