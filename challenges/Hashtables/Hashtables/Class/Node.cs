using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Class
{
    public class Node
    {
        /// <summary>
        /// value for the node
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// next value for node
        /// </summary>
        public Node Next { get; set; }

        public Node(string val)
        {
            this.Value = val;
        }
    }
}
