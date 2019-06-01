using System;
using System.Collections;
using System.Collections.Generic;

namespace Graph.Problems
{
    public struct Edge<T>
    {
        public T Vertex1;
        public T Vertex2;
    }

    public class AdjacencyMatrix<T> 
    {
        private int[,] nodes;

        private IList<T> vertices;

        public AdjacencyMatrix(T[] vertices)
        {
            this.Count = vertices.Length;
            this.nodes = new int[this.Count, this.Count];
            this.vertices = vertices;
        }

        public int Count { get; }

        public void AddEdge(T vertexA, T vertexB)
        {
            var vertexAIndex = this.FindIndex(vertexA);
            var vertexBIndex = this.FindIndex(vertexB);

            if (nodes != null)
            {
                this.nodes[vertexAIndex, vertexBIndex] = 1;
                this.nodes[vertexBIndex, vertexAIndex] = 1;
            }
        }

        private int FindIndex(T vertex)
        {
            var indexOf = vertices.IndexOf(vertex);

            if (indexOf == -1)
                throw new Exception("Didn't find the vertex in the set of vertices");

            return indexOf;
        }

        private void AddVertex(T vertex)
        {
            if (this.vertices.Count <= Count)
                this.vertices.Add(vertex);
            else
                throw new Exception("You are trying to add more vertices than defined at the time of Graph construction");
        }

        public IList<Edge<T>> GetEdges()
        {
            var length = nodes.GetUpperBound(0);
            var edges = new List<Edge<T>>();

            for (int i = 0; i <= length; i++)
            {
                for (int j = 0; j <= length; j++)
                {
                    if (nodes[i, j] == 1)
                    {
                        edges.Add(new Edge<T>() { Vertex1 = vertices[i], Vertex2 = vertices[j] });
                    }
                }
            }

            return edges;
        }

        public int[,] GetAdjacencyMatrix()
        {
            return nodes;
        }
    }
}
