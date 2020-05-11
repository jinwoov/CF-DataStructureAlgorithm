using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Class
{
    public class Vertex<T>
    {
        /// <summary>
        /// Value of the vertex, being T can be any type.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Constuctor to instantiate a object with value
        /// </summary>
        /// <param name="value">Generic value that will be inserted in to the vertex, node</param>
        public Vertex(T value)
        {
            Value = value;
        }
    }
}
