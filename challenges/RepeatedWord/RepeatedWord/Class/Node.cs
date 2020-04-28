using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Class
{
    public class Node
    {
        /// <summary>
        /// Key for the node
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// value for the node
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// next value for node
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Constructor for this class
        /// </summary>
        /// <param name="key">key that will be stored</param>
        /// <param name="value">value that will be stored</param>
        public Node(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
