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

        public void PrintNode()
        {
            Console.Write($"{Data} ->");
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
