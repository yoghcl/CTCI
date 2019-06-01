using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Graph.Problems.Tests
{
    [TestClass]
    public class AdjacencyMatrixTests
    {
        [TestMethod]
        public void GraphTests_ShowGive2Record()
        {
            var vertices = new int[] { 'A', 'B', 'C', 'D', 'E' };
            var graph = new AdjacencyMatrix<int>(vertices);
            graph.AddEdge('A', 'B');

            Assert.AreEqual(2, graph.GetEdges().Count);
        }

        [TestMethod]
        public void GraphTests_ShowGive10Record()
        {
            var vertices = new int[] { 'A', 'B', 'C', 'D', 'E' };
            var graph = new AdjacencyMatrix<int>(vertices);
            graph.AddEdge('A', 'B');
            graph.AddEdge('B', 'C');
            graph.AddEdge('C', 'D');
            graph.AddEdge('D', 'E');
            graph.AddEdge('E', 'A');

            Assert.AreEqual(10, graph.GetEdges().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GraphTests_ShouldReturnException_ForInvalidVertix_Z()
        {
            var vertices = new int[] { 'A', 'B', 'C', 'D', 'E' };
            var graph = new AdjacencyMatrix<int>(vertices);
            graph.AddEdge('A', 'B');
            graph.AddEdge('B', 'Z');
        }


        [TestMethod]
        public void GraphTests_PrintAdjacencyMatrix()
        {
            var vertices = new int[] { 'A', 'B', 'C', 'D', 'E' };
            var graph = new AdjacencyMatrix<int>(vertices);
            graph.AddEdge('A', 'B');
            graph.AddEdge('B', 'C');
            graph.AddEdge('C', 'D');
            graph.AddEdge('D', 'E');
            graph.AddEdge('E', 'A');

            var matrix = graph.GetAdjacencyMatrix();
            var length = matrix.GetUpperBound(0);

            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length; j++)
                {
                    Trace.Write($"{matrix[i, j]} ");
                }
                Trace.WriteLine(string.Empty);
            }
        }

        [TestMethod]
        public void GraphTests_ShowGive25Records()
        {
            var vertices = new int[] { 'A', 'B', 'C', 'D', 'E' };
            var graph = new AdjacencyMatrix<int>(vertices);

            for (int i = 0; i < vertices.Length; i++)
            {
                for (int j = 0; j < vertices.Length; j++)
                {
                    graph.AddEdge(vertices[i], vertices[j]);
                }
            }

            Assert.AreEqual(25, graph.GetEdges().Count);

            var matrix = graph.GetAdjacencyMatrix();
            var length = matrix.GetUpperBound(0);

            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length; j++)
                {
                    Trace.Write($"{matrix[i, j]} ");
                }
                Trace.WriteLine(string.Empty);
            }
        }
    }
}
