using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Class
{
    public class Edge<T>
    {
        // Weight of the from one node to other
        public int Weight { get; set; }
        // Next vertex
        public Vertex<T> Vertex { get; set; }
    }
}
