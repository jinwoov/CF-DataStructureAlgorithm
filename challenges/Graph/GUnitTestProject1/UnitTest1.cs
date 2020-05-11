using Graph.Class;
using System;
using System.Collections.Generic;
using Xunit;

namespace GUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddVertexToTheGraph()
        {
            Graph<string> graph = new Graph<string>();

            var result = graph.AddNode("Hello");

            Assert.Equal("Hello", result.Value);

        }

        [Fact]
        public void EdgeCanBeAddedToGraph()
        { 
            Graph<string> graph = new Graph<string>();

            var HI = graph.AddNode("Hawaii");
            var WA = graph.AddNode("Washington");

            graph.AddUndirectedEdge(HI, WA, 20);

            var result = graph.GetNeighbors(HI);

            Assert.Equal(graph.AdjacencyList[HI], result);
        }

        [Fact]
        public void CollectionCanBeRetrieved()
        {
            Graph<string> graph = new Graph<string>();

            var HI = graph.AddNode("Hawaii");
            var WA = graph.AddNode("Washington");

            List<Vertex<string>> expectList = new List<Vertex<string>>();
            expectList.Add(HI);
            expectList.Add(WA);

            graph.AddDirectoinEdge(HI, WA, 20);

            var resultList = graph.GetAllVertices();

            Assert.Equal(expectList, resultList);
        }

        [Fact]
        public void AppropriateNeighBorCanBeRetrieved()
        {
            Graph<string> graph = new Graph<string>();

            var HI = graph.AddNode("Hawaii");
            var WA = graph.AddNode("Washington");

            graph.AddDirectoinEdge(HI, WA, 20);

           var result = graph.GetNeighbors(HI);

            Assert.Equal(graph.AdjacencyList[HI], result);

        }
        //Neighbors are returned with the weight between nodes included
        [Fact]
        public void NeighborsReturnsWeightBetweenNodes()
        {
            Graph<string> graph = new Graph<string>();

            var HI = graph.AddNode("Hawaii");
            var WA = graph.AddNode("Washington");

            graph.AddDirectoinEdge(HI, WA, 20);

            var result = graph.GetNeighbors(HI);
            Assert.Equal(20, result[0].Weight);
        }
        //The proper size is returned, representing the number of nodes in the graph
        [Fact]
        public void ProperSizeIsReturn()
        {
            Graph<string> graph = new Graph<string>();

            var HI = graph.AddNode("Hawaii");
            var WA = graph.AddNode("Washington");

            int size = graph.Size();

            Assert.Equal(2, size);
        }

        //A graph with only one node and edge can be properly returned
        [Fact]
        public void GraphWithOneNodeAndEdge()
        {
            Graph<string> graph = new Graph<string>();

            var HI = graph.AddNode("Hawaii");

            var result = graph.GetAllVertices();

            Assert.Equal(HI, result[0]);
        }

        //An empty graph properly returns null
        [Fact]
        public void EmptyGraphReturnsNull()
        {
            Graph<string> graph = new Graph<string>();

            Exception ex = Record.Exception(() => graph.GetAllVertices());

            Assert.Null(ex);
        }

    }
}
