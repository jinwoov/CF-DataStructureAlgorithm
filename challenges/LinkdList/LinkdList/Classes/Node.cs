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
        /// This is to append node if its not available and recurse when next is not null.
        /// </summary>
        public void AppendNode(int input)
        {
            if (Next == null)
            {
                Next = new Node();
                Next.Data = input;
            }
            else 
            {
                Next.AppendNode(input);
            }
        }
    }
}
