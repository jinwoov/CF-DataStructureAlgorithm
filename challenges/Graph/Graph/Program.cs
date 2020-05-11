using Graph.Class;
using System;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<string> graph = new Graph<string>();

            var HI = graph.AddNode("Hawaii");
            var WA = graph.AddNode("Washington");
            var OR = graph.AddNode("Oregon");
            var TX = graph.AddNode("Texas");

            graph.AddDirectoinEdge(HI, WA, 500);
            graph.AddDirectoinEdge(WA, OR, 20);
            graph.AddDirectoinEdge(OR, TX, 200);
            graph.AddDirectoinEdge(TX, HI, 1000);


            graph.Print();
        }
    }
}
