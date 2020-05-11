using System;
using System.Collections.Generic;
using System.Text;

namespace Graph.Class
{
    public class Graph<T>
    {
        //Hashtable of Vertex and list of edges that carries info of next vertex and weight
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }

        // Size of the graph
        private int _size;

        // Graph constructor that is being run every time graph is instantiated
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        // Adding a node to the graph
        public Vertex<T> AddNode(T value)
        {
            Vertex<T> node = new Vertex<T>(value);
            AdjacencyList.Add(node, new List<Edge<T>>());
            _size++;
            return node;
        }


        /// <summary>
        ///Adding unilateral edge from point A to point b with weight(distance) 
        /// </summary>
        /// <param name="a">Point A</param>
        /// <param name="b">Point B</param>
        /// <param name="weight">Distance</param>
        public void AddDirectoinEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(
                new Edge<T>
                {
                    Weight = weight,
                    Vertex = b
                }
                );
        }

        /// <summary>
        /// Adding bilateral direction to the graph
        /// </summary>
        /// <param name="a">Point A</param>
        /// <param name="b">Point B</param>
        /// <param name="weight">Distance between two</param>
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectoinEdge(a, b, weight);
            AddDirectoinEdge(b, a, weight);
        }

        /// <summary>
        /// Getting all the vertices in the graph
        /// </summary>
        /// <returns>returns the list of vertices</returns>
        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();
            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);
            }
            return vertices;
        }

        /// <summary>
        /// getting the vertex neighbor
        /// </summary>
        /// <param name="vertex">vertex you want to search neighbor of</param>
        /// <returns>neighbor</returns>
        public List<Edge<T>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        /// <summary>
        /// Getting the size
        /// </summary>
        /// <returns>Delegating private variable that stores the size of the graph</returns>
        public int Size() => _size;

        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                foreach (var edge in vertex.Value)
                {
                    Console.Write($"{edge.Vertex.Value} => ");
                }
            }
        }

    }
}
