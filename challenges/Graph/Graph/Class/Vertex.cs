using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Class
{
    public class Vertex<T>
    {
        public T Value { get; set; }
        // Constuctor to instantiate a object with value
        public Vertex(T value)
        {
            Value = value;
        }
    }
}
