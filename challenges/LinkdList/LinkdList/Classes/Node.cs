using System;
using System.Collections.Generic;
using System.Text;

namespace LinkdList.Classes
{
    public class Node
    {
        /// <summary>
        /// data for the node
        /// </summary>
        public int Data { get; set; }

        /// <summary>
        /// next value for node
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Printing the nodes until the next is null
        /// </summary>
        public void PrintNode()
        {
            // printing out all of the data
            Console.Write($"{Data} ->");
            // if next is not a null which not a end of the list, call itself again when its null print 
            if (Next != null)
            {
                Next.PrintNode();
            }
            else
            {
            Console.Write("NULL");
            }
        }
    }
}
