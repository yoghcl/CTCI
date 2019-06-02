using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Graph.Problems.Tests
{
    [TestClass]
    public class AdjacencyListTests
    {
        [TestMethod]
        public void PrintNodes()
        {
            var graph = new AdjacencyList(5);
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 4);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            graph.PrintGraph();
        }
    }
}
